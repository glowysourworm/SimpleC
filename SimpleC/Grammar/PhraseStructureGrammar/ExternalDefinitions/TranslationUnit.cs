using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.ExternalDefinitions
{
    [Grammar(Name = "translation-unit (base)",
             Description = "translation-unit: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_9)]
    public abstract class TranslationUnit : GrammarBase
    {
        protected TranslationUnit(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "translation-unit (variant 1)",
             Description = "translation-unit: external-declaration",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_9)]
    public class TranslationUnit_V1 : TranslationUnit
    {
        ExternalDeclaration ExternalDeclaration;

        public TranslationUnit_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "translation-unit (variant 2)",
             Description = "translation-unit: translation-unit external-declaration",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_9)]
    public class TranslationUnit_V2 : TranslationUnit
    {
        TranslationUnit TranslationUnit;
        ExternalDeclaration ExternalDeclaration;

        public TranslationUnit_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
