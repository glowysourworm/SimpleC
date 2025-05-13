namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class Constant : GrammarBase
    {
        IntegerConstant _integerConstant;
        FloatingConstant _floatingConstant;
        EnumerationConstant _enumerationConstant;
        CharacterConstant _characterConstant;

        public IntegerConstant IntegerConstant
        {
            get { return _integerConstant; }
            set { this.RaiseAndSetIfChanged(ref _integerConstant, value); }
        }
        public FloatingConstant FloatingConstant
        {
            get { return _floatingConstant; }
            set { this.RaiseAndSetIfChanged(ref _floatingConstant, value); }
        }
        public EnumerationConstant EnumerationConstant
        {
            get { return _enumerationConstant; }
            set { this.RaiseAndSetIfChanged(ref _enumerationConstant, value); }
        }
        public CharacterConstant CharacterConstant
        {
            get { return _characterConstant; }
            set { this.RaiseAndSetIfChanged(ref _characterConstant, value); }
        }


        public Constant()
        {
            this.IntegerConstant = new IntegerConstant();
            this.FloatingConstant = new FloatingConstant();
            this.EnumerationConstant = new EnumerationConstant();
            this.CharacterConstant = new CharacterConstant();
        }
    }
}
