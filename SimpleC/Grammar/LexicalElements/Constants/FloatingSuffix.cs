using SimpleC.Base.Exception;
using SimpleC.Base.Standard;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class FloatingSuffix : GrammarConstant
    {
        // ONE OF: f l F L

        public FloatingSuffix(/* char grammarCConstant */)
        {
            /*
            switch (grammarCConstant)
            {
                case 'f':
                case 'l':
                case 'F':
                case 'L':
                    break;

                default:
                    throw new InvalidGrammarCConstantException(grammarCConstant, ISOCStandardRef.GetLexicalGrammarAnnex("A.1.5", "(6.4.4.2) floating-suffix:"));
            }
            */
        }
    }
}
