namespace SimpleC.Base.Standard
{
    /// <summary>
    /// Points to ISO C Standard Annex A -> Section header
    /// </summary>
    public enum ISOCStandardAnnexSection
    {
        A_1,
        A_2,
        A_3,
    }

    /// <summary>
    /// Points to ISO C Standard Annex A -> Sub-Section header
    /// </summary>
    public enum ISOCStandardAnnexSubSection
    {
        /// <summary>
        /// No subsection specified
        /// </summary>
        None,

        A_1_1,
        A_1_2,
        A_1_3,
        A_1_4,
        A_1_5,
        A_1_6,
        A_1_7,
        A_1_8,
        A_1_9,

        A_2_1,
        A_2_2,
        A_2_3,
        A_2_4,
    }

    /// <summary>
    /// Points to ISO C Standard Annex A -> Sub-Section -> ... (essentially back to the chapter about the sub-sub-section)
    /// </summary>
    public enum ISOCStandardAnnexSubSectionChapter
    {
        s6_4,
        s6_4_1,
        s6_4_2_1,
        s6_4_3,
        s6_4_4,
        s6_4_4_1,
        s6_4_4_2,
        s6_4_4_3,
        s6_4_4_4,
        s6_4_5,
        s6_4_6,
        s6_4_7,
        s6_4_8,

        s6_5_1,
        s6_5_2,
        s6_5_3,
        s6_5_4,
        s6_5_5,
        s6_5_6,
        s6_5_7,
        s6_5_8,
        s6_5_9,
        s6_5_10,
        s6_5_11,
        s6_5_12,
        s6_5_13,
        s6_5_14,
        s6_5_15,
        s6_5_16,
        s6_5_17,

        s6_6,

        s6_7,
        s6_7_1,
        s6_7_2,
        s6_7_2_1,
        s6_7_2_2,
        s6_7_3,
        s6_7_4,
        s6_7_5,
        s6_7_6,
        s6_7_7,
        s6_7_8,

        s6_8,
        s6_8_1,
        s6_8_2,
        s6_8_3,
        s6_8_4,
        s6_8_5,
        s6_8_6,

        s6_9,
        s6_9_1,

        s6_10,
    }
}
