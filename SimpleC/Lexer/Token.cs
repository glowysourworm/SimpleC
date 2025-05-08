using SimpleC.Base;

namespace SimpleC.Lexer
{
    public enum TokenType
    {
        Identifier = 0,
        Keyword = 1,
        ArrayPairedDelimeter = 2,           // []                                           INPUT
        FunctionPairedDelimiter = 3,        // Abstract meaning of () - This one pairs...   INPUT
        ScopePairedDelimeter = 4,           // Abstract meaning of {} - ...with this one    OUTPUT
        Punctuator = 5,
        Operator = 6,
        Literal = 7,
        Comment = 8,
        Whitespace = 9
    }

    public class Token : ModelBase
    {
        string _name;
        TokenType _type;

        public string Name
        {
            get { return _name; }
            set { this.RaiseAndSetIfChanged(ref _name, value); }
        }
        public TokenType Type
        {
            get { return _type; }
            set { this.RaiseAndSetIfChanged(ref _type, value); }
        }
    }
}
