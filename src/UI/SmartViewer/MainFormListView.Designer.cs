﻿namespace SmartViewer
{
    partial class MainFormListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormListView));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("<no doc>");
            this.panelTop = new System.Windows.Forms.Panel();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxPattern = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButtonTag = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButtonFind = new System.Windows.Forms.ToolStripSplitButton();
            this.findPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonCount = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelCount = new System.Windows.Forms.ToolStripLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.splitterBottom = new System.Windows.Forms.Splitter();
            this.panelView = new System.Windows.Forms.Panel();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.splitterRight = new System.Windows.Forms.Splitter();
            this.splitterLeft = new System.Windows.Forms.Splitter();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.treeViewDoc = new System.Windows.Forms.TreeView();
            this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.filterToolStripMenuItemDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fastListViewMain = new SmartViewer.FastListView();
            this.panelTop.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.panelView.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.contextMenuStripTreeView.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.toolStripMain);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 24);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(921, 30);
            this.panelTop.TabIndex = 0;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxPattern,
            this.toolStripButtonFilter,
            this.toolStripSplitButtonTag,
            this.toolStripSplitButtonFind,
            this.toolStripButtonCount,
            this.toolStripLabelCount});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(553, 25);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripTextBoxPattern
            // 
            this.toolStripTextBoxPattern.Name = "toolStripTextBoxPattern";
            this.toolStripTextBoxPattern.Size = new System.Drawing.Size(300, 25);
            this.toolStripTextBoxPattern.TextChanged += new System.EventHandler(this.toolStripTextBoxPattern_TextChanged);
            // 
            // toolStripButtonFilter
            // 
            this.toolStripButtonFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonFilter.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFilter.Image")));
            this.toolStripButtonFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFilter.Name = "toolStripButtonFilter";
            this.toolStripButtonFilter.Size = new System.Drawing.Size(37, 22);
            this.toolStripButtonFilter.Text = "Filter";
            this.toolStripButtonFilter.Click += new System.EventHandler(this.toolStripButtonFilter_Click);
            // 
            // toolStripSplitButtonTag
            // 
            this.toolStripSplitButtonTag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonTag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonTag.Name = "toolStripSplitButtonTag";
            this.toolStripSplitButtonTag.Size = new System.Drawing.Size(42, 22);
            this.toolStripSplitButtonTag.Text = "Tag";
            // 
            // toolStripSplitButtonFind
            // 
            this.toolStripSplitButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonFind.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findPreviousToolStripMenuItem,
            this.findNextToolStripMenuItem});
            this.toolStripSplitButtonFind.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonFind.Image")));
            this.toolStripSplitButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonFind.Name = "toolStripSplitButtonFind";
            this.toolStripSplitButtonFind.Size = new System.Drawing.Size(46, 22);
            this.toolStripSplitButtonFind.Text = "Find";
            // 
            // findPreviousToolStripMenuItem
            // 
            this.findPreviousToolStripMenuItem.Name = "findPreviousToolStripMenuItem";
            this.findPreviousToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.findPreviousToolStripMenuItem.Text = "Find Previous";
            this.findPreviousToolStripMenuItem.Click += new System.EventHandler(this.findPreviousToolStripMenuItem_Click);
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.findNextToolStripMenuItem.Text = "Find Next";
            this.findNextToolStripMenuItem.Click += new System.EventHandler(this.findNextToolStripMenuItem_Click);
            // 
            // toolStripButtonCount
            // 
            this.toolStripButtonCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCount.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCount.Image")));
            this.toolStripButtonCount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCount.Name = "toolStripButtonCount";
            this.toolStripButtonCount.Size = new System.Drawing.Size(44, 22);
            this.toolStripButtonCount.Text = "Count";
            this.toolStripButtonCount.Click += new System.EventHandler(this.toolStripButtonCount_Click);
            // 
            // toolStripLabelCount
            // 
            this.toolStripLabelCount.AutoSize = false;
            this.toolStripLabelCount.Name = "toolStripLabelCount";
            this.toolStripLabelCount.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabelCount.Text = "0";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(921, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.toolsToolStripMenuItem.Text = "Tool";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelMiddle);
            this.panelMain.Controls.Add(this.splitterRight);
            this.panelMain.Controls.Add(this.splitterLeft);
            this.panelMain.Controls.Add(this.panelRight);
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 54);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(921, 414);
            this.panelMain.TabIndex = 7;
            // 
            // panelMiddle
            // 
            this.panelMiddle.Controls.Add(this.splitterBottom);
            this.panelMiddle.Controls.Add(this.panelView);
            this.panelMiddle.Controls.Add(this.panelDetail);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(163, 0);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(551, 414);
            this.panelMiddle.TabIndex = 4;
            // 
            // splitterBottom
            // 
            this.splitterBottom.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterBottom.Location = new System.Drawing.Point(0, 315);
            this.splitterBottom.Name = "splitterBottom";
            this.splitterBottom.Size = new System.Drawing.Size(551, 7);
            this.splitterBottom.TabIndex = 2;
            this.splitterBottom.TabStop = false;
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.Thistle;
            this.panelView.Controls.Add(this.fastListViewMain);
            this.panelView.Controls.Add(this.progressBarMain);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(551, 322);
            this.panelView.TabIndex = 1;
            // 
            // progressBarMain
            // 
            this.progressBarMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarMain.Location = new System.Drawing.Point(0, 0);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(551, 5);
            this.progressBarMain.TabIndex = 1;
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDetail.Location = new System.Drawing.Point(0, 322);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(551, 92);
            this.panelDetail.TabIndex = 0;
            // 
            // splitterRight
            // 
            this.splitterRight.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterRight.Location = new System.Drawing.Point(714, 0);
            this.splitterRight.Name = "splitterRight";
            this.splitterRight.Size = new System.Drawing.Size(7, 414);
            this.splitterRight.TabIndex = 3;
            this.splitterRight.TabStop = false;
            // 
            // splitterLeft
            // 
            this.splitterLeft.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitterLeft.Location = new System.Drawing.Point(156, 0);
            this.splitterLeft.Name = "splitterLeft";
            this.splitterLeft.Size = new System.Drawing.Size(7, 414);
            this.splitterLeft.TabIndex = 2;
            this.splitterLeft.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(721, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(200, 414);
            this.panelRight.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelLeft.Controls.Add(this.treeViewDoc);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(156, 414);
            this.panelLeft.TabIndex = 0;
            // 
            // treeViewDoc
            // 
            this.treeViewDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewDoc.ContextMenuStrip = this.contextMenuStripTreeView;
            this.treeViewDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDoc.FullRowSelect = true;
            this.treeViewDoc.HideSelection = false;
            this.treeViewDoc.Location = new System.Drawing.Point(0, 0);
            this.treeViewDoc.Name = "treeViewDoc";
            treeNode1.Name = "Node0";
            treeNode1.Text = "<no doc>";
            this.treeViewDoc.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewDoc.ShowLines = false;
            this.treeViewDoc.Size = new System.Drawing.Size(156, 414);
            this.treeViewDoc.TabIndex = 0;
            this.treeViewDoc.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewDoc_BeforeSelect);
            this.treeViewDoc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDoc_AfterSelect);
            // 
            // contextMenuStripTreeView
            // 
            this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItemDoc});
            this.contextMenuStripTreeView.Name = "contextMenuStripTreeView";
            this.contextMenuStripTreeView.Size = new System.Drawing.Size(110, 26);
            // 
            // filterToolStripMenuItemDoc
            // 
            this.filterToolStripMenuItemDoc.Name = "filterToolStripMenuItemDoc";
            this.filterToolStripMenuItemDoc.Size = new System.Drawing.Size(109, 22);
            this.filterToolStripMenuItemDoc.Text = "Filter...";
            this.filterToolStripMenuItemDoc.Click += new System.EventHandler(this.filterToolStripMenuItemDoc_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStripMain.Location = new System.Drawing.Point(0, 446);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStripMain.Size = new System.Drawing.Size(921, 22);
            this.statusStripMain.TabIndex = 8;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // fastListViewMain
            // 
            this.fastListViewMain.AllowColumnReorder = true;
            this.fastListViewMain.AlternateBackColor = System.Drawing.Color.RoyalBlue;
            this.fastListViewMain.AlternateBackColorBrush = null;
            this.fastListViewMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fastListViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastListViewMain.FullRowSelect = true;
            this.fastListViewMain.GridLineColor = System.Drawing.Color.Gray;
            this.fastListViewMain.GridLineColorPen = null;
            this.fastListViewMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.fastListViewMain.HideSelection = false;
            this.fastListViewMain.LabelWrap = false;
            this.fastListViewMain.Location = new System.Drawing.Point(0, 5);
            this.fastListViewMain.Name = "fastListViewMain";
            this.fastListViewMain.OwnerDraw = true;
            this.fastListViewMain.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.fastListViewMain.SelectionBackColorBrush = null;
            this.fastListViewMain.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.fastListViewMain.SelectionForeColorBrush = null;
            this.fastListViewMain.ShowGroups = false;
            this.fastListViewMain.Size = new System.Drawing.Size(551, 317);
            this.fastListViewMain.TabIndex = 2;
            this.fastListViewMain.UseCompatibleStateImageBehavior = false;
            this.fastListViewMain.View = System.Windows.Forms.View.Details;
            this.fastListViewMain.VirtualMode = true;
            this.fastListViewMain.CacheVirtualItems += new System.Windows.Forms.CacheVirtualItemsEventHandler(this.fastListViewMain_CacheVirtualItems);
            this.fastListViewMain.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.fastListViewMain_DrawColumnHeader);
            this.fastListViewMain.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.fastListViewMain_DrawItem);
            this.fastListViewMain.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.fastListViewMain_DrawSubItem);
            this.fastListViewMain.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.fastListViewMain_RetrieveVirtualItem);
            this.fastListViewMain.Resize += new System.EventHandler(this.fastListViewMain_Resize);
            // 
            // MainFormListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 468);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainFormListView";
            this.Text = "Smart Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMiddle.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.contextMenuStripTreeView.ResumeLayout(false);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Splitter splitterRight;
        private System.Windows.Forms.Splitter splitterLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Splitter splitterBottom;
        private System.Windows.Forms.TreeView treeViewDoc;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItemDoc;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPattern;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonFilter;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonTag;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonFind;
        private System.Windows.Forms.ToolStripMenuItem findPreviousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCount;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCount;
        private FastListView fastListViewMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

