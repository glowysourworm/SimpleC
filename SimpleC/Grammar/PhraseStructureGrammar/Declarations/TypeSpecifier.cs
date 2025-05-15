using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "type-specifier (base)",
             Description = "type-specifier: (4 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2)]
    public abstract class TypeSpecifier : GrammarBase
    {
        protected TypeSpecifier(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "type-specifier (variant 1)",
             Description = "type-specifier: one of (...)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2)]
    public class TypeSpecifier_V1 : TypeSpecifier
    {
        // One of: void, char, short, int, long, float, double, signed, unsigned, _Bool, _Complex
        Keyword Keyword;

        public TypeSpecifier_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "type-specifier (variant 2)",
             Description = "type-specifier: struct-or-union-specifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2)]
    public class TypeSpecifier_V2 : TypeSpecifier
    {
        StructOrUnionSpecifier StructOrUnionSpecifier;

        public TypeSpecifier_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "type-specifier (variant 3)",
             Description = "type-specifier: enum-specifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2)]
    public class TypeSpecifier_V3 : TypeSpecifier
    {
        EnumSpecifier EnumSpecifier;    

        public TypeSpecifier_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "type-specifier (variant 4)",
             Description = "type-specifier: typedef-name",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2)]
    public class TypeSpecifier_V4 : TypeSpecifier
    {
        TypedefName TypedefName;

        public TypeSpecifier_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
