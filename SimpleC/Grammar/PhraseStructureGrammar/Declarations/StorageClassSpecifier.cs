using SimpleC.Grammar.LexicalElements;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    /// <summary>
    /// (see A.2.2 -> 6.7.1) storage-class-specifier: This class should be just a keyword; but there may be other contextual data.
    /// </summary>
    public class StorageClassSpecifier : GrammarBase
    {
        Keyword _keyword;
    }
}
