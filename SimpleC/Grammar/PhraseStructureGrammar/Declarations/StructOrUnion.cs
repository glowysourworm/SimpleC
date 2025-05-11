using SimpleC.Grammar.LexicalElements;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    /// <summary>
    /// (see A.2.2 -> 6.7.2.1) struct-or-union: This class should be just a keyword; but there may be other contextual data.
    /// </summary>
    public class StructOrUnion : GrammarBase
    {
        Keyword _keyword;
    }
}
