namespace SimpleC.Base.Standard
{
    /// <summary>
    /// Class for data about referencing the ISO C Standard
    /// </summary>
    public class ISOCStandardRef : ModelBase
    {
        ISOCStandard _standard;
        string _chapter;
        string _heading;
        string _section;
        string _subSection;

        public ISOCStandard Standard
        {
            get { return _standard; }
            set { this.RaiseAndSetIfChanged(ref _standard, value); }
        }
        public string Chapter
        {
            get { return _chapter; }
            set { this.RaiseAndSetIfChanged(ref _chapter, value); }
        }
        public string Heading
        {
            get { return _heading; }
            set { this.RaiseAndSetIfChanged(ref _heading, value); }
        }
        public string Section
        {
            get { return _section; }
            set { this.RaiseAndSetIfChanged(ref _section, value); }
        }
        public string SubSection
        {
            get { return _subSection; }
            set { this.RaiseAndSetIfChanged(ref _subSection, value); }
        }

        // KLUDGY:  There may be a better way to structure this ISO standards data.. Perhaps with attribute tags, or 
        //          something after it's well understood.

        public static string ANNEX = "Annex";

        public static ISOCStandardRef GetLexicalGrammarAnnex(string section, string subSection)
        {
            return new ISOCStandardRef(ANNEX + " A", "A.1", section, subSection);
        }

        public ISOCStandardRef(string chapter, string heading, string section, string subSection)
        {
            this.Chapter = string.Empty;
            this.Heading = string.Empty;
            this.Section = string.Empty;
            this.SubSection = string.Empty;
        }
    }
}
