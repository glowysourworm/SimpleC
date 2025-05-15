using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "struct-or-union-specifier (base)",
             Description = "struct-or-union-specifier: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public abstract class StructOrUnionSpecifier : GrammarBase
    {
        protected StructOrUnionSpecifier(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "struct-or-union-specifier (variant 1)",
             Description = "struct-or-union-specifier: struct-or-union identifier_opt { struct-declaration-list }",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public class StructOrUnionSpecifier_V1 : StructOrUnionSpecifier
    {
        StructOrUnion StructOrUnion;
        Identifier? Identifier;
        public const char StructDeclarationListBracketCurlyLeft = GrammarCConstants.BracketCurlyLeft;
        StructDeclaration StructDeclarationList;
        public const char StructDeclarationListBracketCurlyRight = GrammarCConstants.BracketCurlyRight;

        public StructOrUnionSpecifier_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "struct-or-union-specifier (variant 2)",
             Description = "struct-or-union-specifier: struct-or-union identifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_2_1)]
    public class StructOrUnionSpecifier_V2 : StructOrUnionSpecifier
    {
        StructOrUnion StructOrUnion;
        Identifier Identifier;

        public StructOrUnionSpecifier_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
