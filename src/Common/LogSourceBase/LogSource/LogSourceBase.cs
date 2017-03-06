﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LogFlow.DataModel
{
    public abstract class LogSourceBase<T> : ILogSource<T> where T : DataItemBase
    {
        protected LogSourceBase()
        {
            var currentType = typeof(T);

            this.propertyInfos = new List<PropertyInfo>(0);

            while (currentType != null)
            {
                this.propertyInfos = currentType.GetProperties()
                    .Where(f => f.IsDefined(typeof(ColumnInfoAttribute), true) && f.DeclaringType == currentType).Concat(this.propertyInfos).ToList();

                currentType = currentType.BaseType;
            }

            this.columnInfos = this.PropertyInfos.Select(p => p.GetCustomAttribute<ColumnInfoAttribute>(true)).ToList();
        }

        public abstract string Name { get; }

        public IReadOnlyList<T> Items => this.items;

        protected List<T> items = new List<T>();

        public IReadOnlyList<string> Templates => this.templates;
        private List<string> templates = new List<string>();
        private Dictionary<string, int> templatesIndex = new Dictionary<string, int>();

        public IReadOnlyList<PropertyInfo> PropertyInfos => this.propertyInfos;
        private List<PropertyInfo> propertyInfos;

        public IReadOnlyList<ColumnInfoAttribute> ColumnInfos => this.columnInfos;
        private List<ColumnInfoAttribute> columnInfos;

        public IReadOnlyList<IFilter> GroupFilters => InnerGroupFilters;
        protected List<IFilter> InnerGroupFilters = null;

        //public IReadOnlyList<KeyValuePair<string, InnerGroupData>> GroupData => this.InnerGroupData;
        //protected List<KeyValuePair<string, InnerGroupData>> InnerGroupData = null;

        // for performance, only pass int value
        public event EventHandler<int> ItemAdded;
        protected void OnItemAdded(int index)
        {
            this.ItemAdded?.Invoke(this, index);
        }

        protected void AddItem(T item)
        {
            this.items.Add(item);
            item.Id = this.items.Count - 1;
            this.OnItemAdded(item.Id);
        }

        protected int AddTemplate(string template)
        {
            template = string.Intern(template);

            int index;
            if (this.templatesIndex.TryGetValue(template, out index))
            {
                return index;
            }
            else
            {
                this.templates.Add(template);
                return this.templatesIndex[template] = index = this.templates.Count - 1;
            }
        }

        public virtual object GetColumnValue(int rowIndex, int columnIndex)
        {
            var dataItem = this.Items[rowIndex];

            PropertyInfo pi = this.PropertyInfos[columnIndex];

            ColumnInfoAttribute ci = this.ColumnInfos[columnIndex];

            if (!ci.Computed)
            {
                return pi.GetMethod.Invoke(dataItem, null);
            }
            else if (ci.Name == "Text")
            {
                return new ParametricString(
                    this.Templates[dataItem.TemplateId],
                    dataItem.Parameters);
            }
            else
            {
                return null;
            }
        }

        private bool firstBatchLoaded = false;
        protected int currentId = 0;

        public virtual IEnumerable<int> Load(IFilter filter)
        {
            if (firstBatchLoaded) { return this.LoadIncremental(filter); }
            else { firstBatchLoaded = true; return this.LoadFirst(filter); }
        }

        protected virtual IEnumerable<int> LoadFirst(IFilter filter) { yield break; }
        protected virtual IEnumerable<int> LoadIncremental(IFilter filter) { yield break; }
    }
}