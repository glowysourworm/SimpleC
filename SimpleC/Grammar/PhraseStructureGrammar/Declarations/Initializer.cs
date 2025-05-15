using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "initializer (base)",
             Description = "initializer: (3 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public abstract class Initializer : GrammarBase
    {
        protected Initializer(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "initializer (variant 1)",
             Description = "initializer: assignment-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public class Initializer_V1 : Initializer
    {
        public AssignmentExpression AssignmentExpression;

        public Initializer_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "initializer (variant 2)",
             Description = "initializer: { initializer-list }",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public class Initializer_V2 : Initializer
    {
        public const char InitializerListBracketOpen = GrammarCConstants.BracketCurlyLeft;
        InitializerList InitializerList;
        public const char InitializerListBracketClose = GrammarCConstants.BracketCurlyRight;

        public Initializer_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "initializer (variant 3)",
             Description = "initializer: { initializer-list , }",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_8)]
    public class Initializer_V3 : Initializer
    {
        public const char InitializerListBracketOpen = GrammarCConstants.BracketCurlyLeft;
        InitializerList InitializerList;
        public const char CommaSeparator = GrammarCConstants.Comma;
        public const char InitializerListBracketClose = GrammarCConstants.BracketCurlyRight;

        public Initializer_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
