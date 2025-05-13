using SimpleC.Grammar.LexicalElements.Constants;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.LexicalElements.StringLiterals;

namespace SimpleC.Grammar.LexicalElements
{
    /// <summary>
    /// (See A.1.1 -> 6.4) token:
    /// </summary>
    public class Token : GrammarBase
    {
        Keyword _keyword;
        Identifier _identifier;
        Constant _constant;
        StringLiteral _stringLiteral;
        Punctuator _punctuator;

        public Keyword Keyword
        {
            get { return _keyword; }
            set { this.RaiseAndSetIfChanged(ref _keyword, value); }
        }
        public Identifier Identifier
        {
            get { return _identifier; }
            set { this.RaiseAndSetIfChanged(ref _identifier, value); }
        }
        public Constant Constant
        {
            get { return _constant; }
            set { this.RaiseAndSetIfChanged(ref _constant, value); }
        }
        public StringLiteral StringLiteral
        {
            get { return _stringLiteral; }
            set { this.RaiseAndSetIfChanged(ref _stringLiteral, value); }
        }
        public Punctuator Punctuator
        {
            get { return _punctuator; }
            set { this.RaiseAndSetIfChanged(ref _punctuator, value); }
        }

        public Token()
        {
            this.Keyword = new Keyword();
            this.Identifier = new Identifier();
            this.Constant = new Constant();
            this.StringLiteral = new StringLiteral();
            this.Punctuator = new Punctuator();
        }
    }
}
