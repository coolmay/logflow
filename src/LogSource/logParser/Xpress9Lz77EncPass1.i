#ifndef LZ77_MIN_MTF_MATCH_LENGTH
#error  LZ77_MIN_MTF_MATCH_LENGTH must be defined
#endif

#ifndef LZ77_MIN_PTR_MATCH_LENGTH
#error  LZ77_MIN_PTR_MATCH_LENGTH must be defined
#endif


#if LZ77_MTF == 4
// index -- Index of the offset, 0 => MtfOffset0, 1 => MtfOffset1 and so on.
// 
#define UPDATE_MTF(iIndex,iOffset) do {             \
    xint _iOffset = (iOffset);                      \
    if ((iIndex) >= 3) iMtfOffset3 = iMtfOffset2;   \
    if ((iIndex) >= 2) iMtfOffset2 = iMtfOffset1;   \
    iMtfOffset1 = iMtfOffset0;                      \
    iMtfOffset0 = _iOffset;                         \
} while (0)
#elif LZ77_MTF == 2
#define UPDATE_MTF(iIndex,iOffset) do {             \
    xint _iOffset = (iOffset);                      \
    iMtfOffset1 = iMtfOffset0;                      \
    iMtfOffset0 = _iOffset;                         \
} while (0)
#endif /* LZ77_MTF == 2 */

static
void
Xpress9Lz77EncPass1 (
    LZ77_PASS1_STATE *pState
)
{
    const UInt8    *pData           = STATE.m_EncodeData.m_pData;
    UInt16         *pIrPtr          = (UInt16 *) STATE.m_Pass2.m_Ir.m_pIrPtr;
    uxint           uPosition       = STATE.m_EncodeData.m_uEncodePosition;
#if LZ77_MTF >= 2
    xint            iMtfLastPtr     = STATE.m_EncodeData.m_Mtf.m_iMtfLastPtr;
    xint            iMtfOffset0     = STATE.m_EncodeData.m_Mtf.m_iMtfOffset[0];
    xint            iMtfOffset1     = STATE.m_EncodeData.m_Mtf.m_iMtfOffset[1];
#endif /* LZ77_MTF >= 2 */
#if LZ77_MTF >= 4
    xint            iMtfOffset2     = STATE.m_EncodeData.m_Mtf.m_iMtfOffset[2];
    xint            iMtfOffset3     = STATE.m_EncodeData.m_Mtf.m_iMtfOffset[3];
#endif /* LZ77_MTF >= 4 */
#if DEEP_LOOKUP
    uxint           uMaxDepth       = STATE.m_Params.m_Current.m_uLookupDepth;
#endif /* DEEP_LOOKUP */
    const uxint     uDataSize       = STATE.m_EncodeData.m_uDataSize;
    const UInt8    * const pEndData = pData + uDataSize;  // Used in lookup.
    const uxint     uStopPosition   = STATE.m_EncodeData.m_uHashInsertPosition; // We have inserted into the hash table till this point.

    //These are the two values we are looking to populate.
    uxint           uBestLength; 
    xint            iBestOffset;

    ASSERT ((DEEP_LOOKUP == 0) == (STATE.m_Params.m_Current.m_uLookupDepth == 0), "");
    ASSERT (LZ77_MTF == STATE.m_Params.m_Current.m_uMtfEntryCount, "");
    ASSERT (LZ77_MIN_MTF_MATCH_LENGTH == STATE.m_Params.m_Current.m_uMtfMinMatchLength, "");
    ASSERT (LZ77_MIN_PTR_MATCH_LENGTH == STATE.m_Params.m_Current.m_uPtrMinMatchLength, "");

#if DEEP_LOOKUP
    uMaxDepth += 1;
#endif /* DEEP_LOOKUP */

#if 0 && LZ77_MTF >= 2
    if (iMtfLastPtr)
    {
        // see whether we can continue
        const UInt8 *_pComp;
        _pComp = pData + uPosition;
        CHECK_MTF (uPosition, iMtfOffset0, 0, 3);
    }
#endif /* LZ77_MTF >= 2 */

    do
    {
#if LZ77_MTF >= 2
        {
            const UInt8 *_pComp;
            _pComp = pData + uPosition;

            if (_pComp + LZ77_MIN_MTF_MATCH_LENGTH <= pEndData)
            {
                if (!iMtfLastPtr)
                {
                    CHECK_MTF (uPosition, iMtfOffset0, 0, 0);
                }
                CHECK_MTF (uPosition, iMtfOffset1, 1, 1 + iMtfLastPtr); // This may jump to EncodeMtfPtr if check succeeds.
#if LZ77_MTF >= 4
                CHECK_MTF (uPosition, iMtfOffset2, 2, 2 + iMtfLastPtr);
                CHECK_MTF (uPosition, iMtfOffset3, 3, 3 + iMtfLastPtr);
#endif /* LZ77_MTF >= 4 */
            }
        }
#endif /* LZ77_MTF >= 2 */

        if (pNext[uPosition] == 0)
        {
            // End of a hash chain.
            goto Literal;
        }

        pNext[0] = (LZ77_INDEX) uPosition;
        uBestLength = LZ77_MIN_PTR_MATCH_LENGTH - 1;
        iBestOffset = 0;        // keep compiler happy

#include "Xpress9Lookup.i"

        if (uBestLength >= LZ77_MIN_PTR_MATCH_LENGTH)
        {
            ENCODE_PTR (uPosition, uBestLength, LZ77_MIN_PTR_MATCH_LENGTH, iBestOffset);

#if LZ77_MTF >= 2
            UPDATE_MTF (LZ77_MTF - 1, iBestOffset);
EncodeMtfPtr:
            iMtfLastPtr = -1;
#endif /* LZ77_MTF >= 2 */

            uPosition += uBestLength;
        }
        else
        {
            uxint _uCandidate;
Literal:
#if LZ77_MTF >= 2
            iMtfLastPtr = 0;
#endif /* LZ77_MTF >= 2 */

            do
            {
                ENCODE_LIT (uPosition);
                uPosition += 1;
                if (uPosition >= uStopPosition)
                    goto L_DoneEncoding;
#pragma warning(suppress:6385)
                _uCandidate = pNext[uPosition];
            }
            while (
                _uCandidate == 0
#if LZ77_MIN_PTR_MATCH_LENGTH == 4
                || * (UInt32 *) (pData + uPosition) != * (UInt32 *) (pData + _uCandidate)
#else
                || pData[uPosition] != pData[_uCandidate] ||
                pData[uPosition + 1] != pData[_uCandidate + 1] ||
                pData[uPosition + 2] != pData[_uCandidate + 2]
#endif /* LZ77_MIN_PTR_MATCH_LENGTH == 4 */
            );
        }
    }
    while (uPosition < uStopPosition);
	
L_DoneEncoding:

    STATE.m_Pass2.m_Ir.m_pIrPtr                 = (UInt8 *) pIrPtr;
    STATE.m_EncodeData.m_uEncodePosition        = uPosition;
#if LZ77_MTF >= 2
    STATE.m_EncodeData.m_Mtf.m_iMtfLastPtr      = iMtfLastPtr;
    STATE.m_EncodeData.m_Mtf.m_iMtfOffset[0]    = iMtfOffset0;
    STATE.m_EncodeData.m_Mtf.m_iMtfOffset[1]    = iMtfOffset1;
#endif /* LZ77_MTF >= 2 */
#if LZ77_MTF >= 4
    STATE.m_EncodeData.m_Mtf.m_iMtfOffset[2]    = iMtfOffset2;
    STATE.m_EncodeData.m_Mtf.m_iMtfOffset[3]    = iMtfOffset3;
#endif /* LZ77_MTF >= 4 */

}

#undef UPDATE_MTF

#undef DEEP_LOOKUP
#undef LZ77_MTF
#undef LZ77_MIN_MTF_MATCH_LENGTH
#undef LZ77_MIN_PTR_MATCH_LENGTH
#undef TAIL_T
#undef Xpress9Lz77EncPass1
