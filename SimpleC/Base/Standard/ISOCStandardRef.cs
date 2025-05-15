namespace SimpleC.Base.Standard
{
    /// <summary>
    /// Class for data about referencing the ISO C Standard. Most of the detail can be referenced via the Annexes. So, the
    /// enums are to specify where those are pointing. The page number is also included; and the ISO standard (which we're 
    /// assuming to be C99 for this branch)
    /// </summary>
    public class ISOCStandardRef : ModelBase
    {
        ISOCStandard _standard;

        ISOCStandardAnnexSection _section;
        ISOCStandardAnnexSubSection _subSection;
        ISOCStandardAnnexSubSectionChapter _subSectionChapterRef;

        int _pageNumber;

        public ISOCStandard Standard
        {
            get { return _standard; }
            set { this.RaiseAndSetIfChanged(ref _standard, value); }
        }
        public ISOCStandardAnnexSection Section
        {
            get { return _section; }
            set { this.RaiseAndSetIfChanged(ref _section, value); }
        }
        public ISOCStandardAnnexSubSection SubSection
        {
            get { return _subSection; }
            set { this.RaiseAndSetIfChanged(ref _subSection, value); }
        }
        public ISOCStandardAnnexSubSectionChapter SubSectionChapterRef
        {
            get { return _subSectionChapterRef; }
            set { this.RaiseAndSetIfChanged(ref _subSectionChapterRef, value); }
        }
        public int PageNumber
        {
            get { return _pageNumber; }
            set { this.RaiseAndSetIfChanged(ref _pageNumber, value); }
        }

        public ISOCStandardRef(ISOCStandardAnnexSection section, 
                               ISOCStandardAnnexSubSection subSection, 
                               ISOCStandardAnnexSubSectionChapter chapterRef,
                               int pageNumber)
        {
            this.Standard = ISOCStandard.C99;
            this.Section = section;
            this.SubSection = subSection;
            this.SubSectionChapterRef = chapterRef;
            this.PageNumber = pageNumber;
        }
    }
}
