using SimpleC.Grammar.LexicalElements;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    /// <summary>
    /// (see A.2.2 -> 6.7.3) type-qualifier: This class should be just a keyword; but there may be other contextual data.
    /// </summary>
    public class TypeQualifier : GrammarBase
    {
        Keyword _keyword;
    }
}
