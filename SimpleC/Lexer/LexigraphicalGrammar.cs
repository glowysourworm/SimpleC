using SimpleC.Base;
using SimpleC.Base.Standard;
using SimpleC.Grammar.LexicalElements;

namespace SimpleC.Lexer
{
    public class LexigraphicalGrammar : ModelBase
    {
        ISOCStandard _standard;

        /// <summary>
        /// The basic tokens are the primitive pieces of the language syntax, before identifying anything
        /// defined by the user. Examples include:  Keywords, and Punctuators
        /// </summary>
        public SimpleList<Token> BasicTokens { get; private set; }

        /// <summary>
        /// User tokens are Identifiers, Constants, and Literals that are defined in the program code.
        /// </summary>
        public SimpleList<Token> UserTokens { get; private set; }

        public ISOCStandard CStandard
        {
            get { return _standard; }
            set { this.RaiseAndSetIfChanged(ref _standard, value); }
        }

        public LexigraphicalGrammar(IEnumerable<Token> tokens)
        {
            this.BasicTokens = new SimpleList<Token>(tokens);
            this.UserTokens = new SimpleList<Token>();

            this.CStandard = ISOCStandard.C89;      // Need to verify with WD65816 docs!
        }

        //public IEnumerable<Token> GetKeywords()
        //{
        //    return this.BasicTokens.Where(x => x.Type == TokenType.Keyword);
        //}
        //public IEnumerable<Token> GetPunctuators()
        //{
        //    return this.BasicTokens.Where(x => x.Type == TokenType.Punctuator);
        //}
    }
}
