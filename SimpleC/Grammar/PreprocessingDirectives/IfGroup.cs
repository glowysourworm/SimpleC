using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "if-group (base)",
             Description = "if-group: (3 variants)",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public abstract class IfGroup : GrammarBase
    {
        protected IfGroup(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "if-group (variant 1)",
             Description = "if-group: # if constant-expression new-line group_opt",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class IfGroup_V1 : IfGroup
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        public const string IfKeyword = GrammarCKeywords.Keyword_if;
        ConstantExpression ConstantExpression;
        NewLine NewLine;
        Group? Group;

        public IfGroup_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "if-group (variant 2)",
             Description = "if-group: # ifdef identifier new-line group_opt",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class IfGroup_V2 : IfGroup
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        public const string IfdefKeyword = GrammarCKeywords.Keyword_ifdef;
        Identifier Identifier;
        NewLine NewLine;
        Group? Group;

        public IfGroup_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "if-group (variant 3)",
             Description = "if-group: # ifndef identifier new-line group_opt",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class IfGroup_V3 : IfGroup
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        public const string IfndefKeyword = GrammarCKeywords.Keyword_ifndef;
        Identifier Identifier;
        NewLine NewLine;
        Group? Group;

        public IfGroup_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
