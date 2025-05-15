using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "declaration-specifiers (base)",
             Description = "declaration: (4 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7)]
    public abstract class DeclarationSpecifiers : GrammarBase
    {
        protected DeclarationSpecifiers(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "declaration-specifiers (variant 1)",
             Description = "declaration: storage-class-specifier declaration-specifiers_opt",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7)]
    public class DeclarationSpecifiers_V1 : DeclarationSpecifiers
    {
        StorageClassSpecifier StorageClassSpecifier;
        DeclarationSpecifiers? DeclarationSpecifiers;

        public DeclarationSpecifiers_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "declaration-specifiers (variant 2)",
             Description = "declaration: type-specifier declaration-specifiers_opt",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7)]
    public class DeclarationSpecifiers_V2 : DeclarationSpecifiers
    {
        TypeSpecifier TypeSpecifier;
        DeclarationSpecifiers? DeclarationSpecifiers;

        public DeclarationSpecifiers_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "declaration-specifiers (variant 3)",
             Description = "declaration: type-qualifier declaration-specifiers_opt",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7)]
    public class DeclarationSpecifiers_V3 : DeclarationSpecifiers
    {
        TypeQualifier TypeQualifier;
        DeclarationSpecifiers? DeclarationSpecifiers;

        public DeclarationSpecifiers_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "declaration-specifiers (variant 4)",
             Description = "declaration: function-specifier declaration-specifiers_opt",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7)]
    public class DeclarationSpecifiers_V4 : DeclarationSpecifiers
    {
        FunctionSpecifier FunctionSpecifier;
        DeclarationSpecifiers? DeclarationSpecifiers;

        public DeclarationSpecifiers_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
