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
        Punctuator _punctuation;

        // TODO: "Each non-white space character that cannot be one of the above"

        public PreprocessingToken()
        {
        }
    }
}
