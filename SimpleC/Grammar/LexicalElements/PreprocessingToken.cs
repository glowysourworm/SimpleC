using SimpleC.Grammar.LexicalElements.Constants;
using SimpleC.Grammar.LexicalElements.HeaderNames;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.LexicalElements.StringLiterals;

namespace SimpleC.Grammar.LexicalElements
{
    /// <summary>
    /// (See A.1.1 -> 6.4:  preprocessing-token)
    /// </summary>
    public class PreprocessingToken : Token
    {
        HeaderName _headerName;
        Identifier _identifier;
        PreprocessingNumber _preprocessingNumber;
        CharacterConstant _characterConstant;
        StringLiteral _stringLiteral;
        Punctuator _punctuator;

        // TODO: "Each non-white space character that cannot be one of the above"

        public HeaderName HeaderName
        {
            get { return _headerName; }
            set { this.RaiseAndSetIfChanged(ref _headerName, value); }
        }
        public Identifier Identifier
        {
            get { return _identifier; }
            set { this.RaiseAndSetIfChanged(ref _identifier, value); }
        }
        public PreprocessingNumber PreprocessingNumber
        {
            get { return _preprocessingNumber; }
            set { this.RaiseAndSetIfChanged(ref _preprocessingNumber, value); }
        }
        public CharacterConstant CharacterConstant
        {
            get { return _characterConstant; }
            set { this.RaiseAndSetIfChanged(ref _characterConstant, value); }
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


        public PreprocessingToken()
        {
            this.HeaderName = new HeaderName();
            this.Identifier = new Identifier();
            this.PreprocessingNumber = new PreprocessingNumber();
            this.CharacterConstant = new CharacterConstant();
            this.StringLiteral = new StringLiteral();
            this.Punctuator = new Punctuator();
        }
    }
}
