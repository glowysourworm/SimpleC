using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "enumerator-list (base)",
             Description = "enumerator-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_2)]
    public abstract class EnumeratorList : GrammarBase
    {
        protected EnumeratorList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "enumerator-list (variant 1)",
             Description = "enumerator-list: enumerator",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_2)]
    public class EnumeratorList_V1 : EnumeratorList
    {
        Enumerator Enumerator;

        public EnumeratorList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "enumerator-list (variant 2)",
             Description = "enumerator-list: enumerator-list , enumerator",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_2)]
    public class EnumeratorList_V2 : EnumeratorList
    {
        EnumeratorList EnumeratorList;
        public const char CommaSeparator = GrammarCConstants.Comma;
        Enumerator Enumerator;

        public EnumeratorList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
