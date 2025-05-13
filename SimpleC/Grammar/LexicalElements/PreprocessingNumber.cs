using SimpleC.Grammar.LexicalElements.Constants;
using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.LexicalElements
{
    public class PreprocessingNumber : GrammarBase
    {
        Digit _digit1;

        public const char PeriodPrefix2 = GrammarCConstants.Period;
        Digit _digit2;

        PreprocessingNumber _preProcessingNumber3;
        Digit _digit3;

        PreprocessingNumber _preProcessingNumber4;
        IdentifierNonDigit _identifierNonDigit4;

        PreprocessingNumber _preProcessingNumber5;
        public const char eConstant5 = GrammarCConstants.Letter_e;
        Sign _sign5;

        PreprocessingNumber _preProcessingNumber6;
        public const char EConstant6 = GrammarCConstants.Letter_E;
        Sign _sign6;

        PreprocessingNumber _preProcessingNumber7;
        public const char PConstant7 = GrammarCConstants.Letter_P;
        Sign _sign7;

        PreprocessingNumber _preProcessingNumber8;
        public const char pConstant8 = GrammarCConstants.Letter_p;
        Sign _sign8;

        PreprocessingNumber _preProcessingNumber9;
        public const char PeriodSuffix9 = GrammarCConstants.Period;

        public Digit Digit1
        {
            get { return _digit1; }
            set { this.RaiseAndSetIfChanged(ref _digit1, value); }
        }
        public Digit Digit2
        {
            get { return _digit2; }
            set { this.RaiseAndSetIfChanged(ref _digit2, value); }
        }
        public PreprocessingNumber PreProcessingNumber3
        {
            get { return _preProcessingNumber3; }
            set { this.RaiseAndSetIfChanged(ref _preProcessingNumber3, value); }
        }
        public Digit Digit3
        {
            get { return _digit3; }
            set { this.RaiseAndSetIfChanged(ref _digit3, value); }
        }
        public PreprocessingNumber PreProcessingNumber4
        {
            get { return _preProcessingNumber4; }
            set { this.RaiseAndSetIfChanged(ref _preProcessingNumber4, value); }
        }
        public IdentifierNonDigit IdentifierNonDigit4
        {
            get { return _identifierNonDigit4; }
            set { this.RaiseAndSetIfChanged(ref _identifierNonDigit4, value); }
        }
        public PreprocessingNumber PreProcessingNumber5
        {
            get { return _preProcessingNumber5; }
            set { this.RaiseAndSetIfChanged(ref _preProcessingNumber5, value); }
        }
        public Sign Sign5
        {
            get { return _sign5; }
            set { this.RaiseAndSetIfChanged(ref _sign5, value); }
        }
        public PreprocessingNumber PreProcessingNumber6
        {
            get { return _preProcessingNumber6; }
            set { this.RaiseAndSetIfChanged(ref _preProcessingNumber6, value); }
        }
        public Sign Sign6
        {
            get { return _sign6; }
            set { this.RaiseAndSetIfChanged(ref _sign6, value); }
        }
        public PreprocessingNumber PreProcessingNumber7
        {
            get { return _preProcessingNumber7; }
            set { this.RaiseAndSetIfChanged(ref _preProcessingNumber7, value); }
        }
        public Sign Sign7
        {
            get { return _sign7; }
            set { this.RaiseAndSetIfChanged(ref _sign7, value); }
        }
        public PreprocessingNumber PreProcessingNumber8
        {
            get { return _preProcessingNumber8; }
            set { this.RaiseAndSetIfChanged(ref _preProcessingNumber8, value); }
        }
        public Sign Sign8
        {
            get { return _sign8; }
            set { this.RaiseAndSetIfChanged(ref _sign8, value); }
        }
        public PreprocessingNumber PreProcessingNumber9
        {
            get { return _preProcessingNumber9; }
            set { this.RaiseAndSetIfChanged(ref _preProcessingNumber9, value); }
        }

        public PreprocessingNumber()
        {
            this.Digit1 = new Digit();
            this.Digit2 = new Digit();
            this.Digit3 = new Digit();
            this.IdentifierNonDigit4 = new IdentifierNonDigit();
            this.PreProcessingNumber3 = new PreprocessingNumber();
            this.PreProcessingNumber4 = new PreprocessingNumber();
            this.PreProcessingNumber5 = new PreprocessingNumber();
            this.PreProcessingNumber6 = new PreprocessingNumber();
            this.PreProcessingNumber7 = new PreprocessingNumber();
            this.PreProcessingNumber8 = new PreprocessingNumber();
            this.PreProcessingNumber9 = new PreprocessingNumber();
            this.Sign5 = new Sign();
            this.Sign6 = new Sign();
            this.Sign7 = new Sign();
            this.Sign8 = new Sign();
        }
    }
}
