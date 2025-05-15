using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "specifier-declarator-list (base)",
             Description = "specifier-declarator-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public abstract class StructDeclaratorList : GrammarBase
    {
        protected StructDeclaratorList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "specifier-declarator-list (variant 1)",
             Description = "specifier-declarator-list: struct-declarator",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public class StructDeclaratorList_V1 : StructDeclaratorList
    {
        StructDeclarator StructDeclarator;

        public StructDeclaratorList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "specifier-declarator-list (variant 2)",
             Description = "specifier-declarator-list: struct-declarator-list , struct-declarator",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public class StructDeclaratorList_V2 : StructDeclaratorList
    {
        StructDeclaratorList StructDeclaratorList;
        public const char CommaSeparator = GrammarCConstants.Comma;
        StructDeclarator StructDeclarator;

        public StructDeclaratorList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
