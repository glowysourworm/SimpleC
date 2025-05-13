namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class EscapeSequence : GrammarBase
    {
        // ONE OF:  \' \" \? \\ \a \b \f \n \r \t \v

        // Using static constants to preserve memory
        //
        public static string SingleQuoteEscaped = @"\'";
        public static string DoubleQuoteEscaped = "\\\"";
        public static string QuestionMarkEscaped = @"\?";
        public static string BackSlashEscaped = @"\\";
        public static string aEscaped = @"\a";
        public static string bEscaped = @"\b";
        public static string fEscaped = @"\f";
        public static string nEscaped = @"\n";
        public static string rEscaped = @"\r";
        public static string tEscaped = @"\t";
        public static string vEscaped = @"\v";

        public EscapeSequence()
        {
            // Validate against one of the above
        }
    }
}
