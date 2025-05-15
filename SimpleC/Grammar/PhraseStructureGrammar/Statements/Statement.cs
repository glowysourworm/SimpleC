using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    [Grammar(Name = "statement (base)",
             Description = "statement: (6 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8)]
    public abstract class Statement : GrammarBase
    {
        public Statement(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "statement (variant 1)",
             Description = "statement: labeled-statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8)]
    public class Statement_V1 : Statement
    {
        LabeledStatement LabeledStatement;

        public Statement_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "statement (variant 2)",
             Description = "statement: compound-statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8)]
    public class Statement_V2 : Statement
    {
        CompoundStatement CompoundStatement;

        public Statement_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "statement (variant 3)",
             Description = "statement: expression-statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8)]
    public class Statement_V3 : Statement
    {
        ExpressionStatement ExpressionStatement;

        public Statement_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "statement (variant 4)",
             Description = "statement: selection-statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8)]
    public class Statement_V4 : Statement
    {
        SelectionStatement SelectionStatement;

        public Statement_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "statement (variant 5)",
             Description = "statement: iteration-statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8)]
    public class Statement_V5 : Statement
    {
        IterationStatement IterationStatement;

        public Statement_V5(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "statement (variant 6)",
             Description = "statement: jump-statement",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_3,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_8)]
    public class Statement_V6 : Statement
    {
        JumpStatement JumpStatement;

        public Statement_V6(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
