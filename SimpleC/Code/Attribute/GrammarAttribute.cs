using SimpleC.Base.Standard;

namespace SimpleC.Code.Attribute
{
    public class GrammarAttribute : System.Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ISOCStandardAnnexSection Section { get; set; }
        public ISOCStandardAnnexSubSection SubSection { get; set; }
        public ISOCStandardAnnexSubSectionChapter SubSectionChapter { get; set; }
    }
}
