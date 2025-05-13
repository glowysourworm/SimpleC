namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class RelationalExpression : GrammarBase
    {
        ShiftExpression _shiftExpression1;

        RelationalExpression _relationExpression2;
        public const string LessThanOperator2 = GrammarCOperators.LessThan;
        ShiftExpression _shiftExpression2;

        RelationalExpression _relationExpression3;
        public const string GreaterThanOperator3 = GrammarCOperators.GreaterThan;
        ShiftExpression _shiftExpression3;

        RelationalExpression _relationExpression4;
        public const string LessThanOrEqualToOperator4 = GrammarCOperators.LessThanOrEqualTo;
        ShiftExpression _shiftExpression4;

        RelationalExpression _relationExpression5;
        public const string GreaterThanOrEqualToOperator5 = GrammarCOperators.GreaterThanOrEqualTo;
        ShiftExpression _shiftExpression5;

        public ShiftExpression ShiftExpression1
        {
            get { return _shiftExpression1; }
            set { this.RaiseAndSetIfChanged(ref _shiftExpression1, value); }
        }
        public RelationalExpression RelationExpression2
        {
            get { return _relationExpression2; }
            set { this.RaiseAndSetIfChanged(ref _relationExpression2, value); }
        }
        public ShiftExpression ShiftExpression2
        {
            get { return _shiftExpression2; }
            set { this.RaiseAndSetIfChanged(ref _shiftExpression2, value); }
        }
        public RelationalExpression RelationExpression3
        {
            get { return _relationExpression3; }
            set { this.RaiseAndSetIfChanged(ref _relationExpression3, value); }
        }
        public ShiftExpression ShiftExpression3
        {
            get { return _shiftExpression3; }
            set { this.RaiseAndSetIfChanged(ref _shiftExpression3, value); }
        }
        public RelationalExpression RelationExpression4
        {
            get { return _relationExpression4; }
            set { this.RaiseAndSetIfChanged(ref _relationExpression4, value); }
        }
        public ShiftExpression ShiftExpression4
        {
            get { return _shiftExpression4; }
            set { this.RaiseAndSetIfChanged(ref _shiftExpression4, value); }
        }
        public RelationalExpression RelationExpression5
        {
            get { return _relationExpression5; }
            set { this.RaiseAndSetIfChanged(ref _relationExpression5, value); }
        }
        public ShiftExpression ShiftExpression5
        {
            get { return _shiftExpression5; }
            set { this.RaiseAndSetIfChanged(ref _shiftExpression5, value); }
        }

        public RelationalExpression()
        {
            this.RelationExpression2 = new RelationalExpression();
            this.RelationExpression3 = new RelationalExpression();
            this.RelationExpression4 = new RelationalExpression();
            this.RelationExpression5 = new RelationalExpression();
            this.ShiftExpression1 = new ShiftExpression();
            this.ShiftExpression2 = new ShiftExpression();
            this.ShiftExpression3 = new ShiftExpression();
            this.ShiftExpression4 = new ShiftExpression();
            this.ShiftExpression5 = new ShiftExpression();
        }
    }
}
