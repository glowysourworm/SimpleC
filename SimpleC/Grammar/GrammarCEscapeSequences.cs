namespace SimpleC.Grammar
{
    public static class GrammarCEscapeSequences
    {
        public const string SingleQuoteEscaped = @"\'";
        public const string DoubleQuoteEscaped = "\\\"";
        public const string QuestionMarkEscaped = @"\?";
        public const string BackSlashEscaped = @"\\";
        public const string aEscaped = @"\a";
        public const string bEscaped = @"\b";
        public const string fEscaped = @"\f";
        public const string nEscaped = @"\n";
        public const string rEscaped = @"\r";
        public const string tEscaped = @"\t";
        public const string vEscaped = @"\v";

        public const string UnicodePrefix1 = @"\u";
        public const string UnicodePrefix2 = @"\U";     // Should be for twice the word length

        public const string HexadecimalEscape = @"\x";
    }
}
