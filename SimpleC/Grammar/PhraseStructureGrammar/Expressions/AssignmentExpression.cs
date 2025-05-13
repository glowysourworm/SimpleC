namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class AssignmentExpression : GrammarBase
    {
        ConditionalExpression _conditionalExpression1;

        UnaryExpression _unaryExpression2;
        AssignmentOperator _assignmentOperator2;
        AssignmentExpression _assignmentExpression2;

        public ConditionalExpression ConditionalExpression1
        {
            get { return _conditionalExpression1; }
            set { this.RaiseAndSetIfChanged(ref _conditionalExpression1, value); }
        }
        public UnaryExpression UnaryExpression2
        {
            get { return _unaryExpression2; }
            set { this.RaiseAndSetIfChanged(ref _unaryExpression2, value); }
        }
        public AssignmentOperator AssignmentOperator2
        {
            get { return _assignmentOperator2; }
            set { this.RaiseAndSetIfChanged(ref _assignmentOperator2, value); }
        }
        public AssignmentExpression AssignmentExpression2
        {
            get { return _assignmentExpression2; }
            set { this.RaiseAndSetIfChanged(ref _assignmentExpression2, value); }
        }

        public AssignmentExpression()
        {
            this.ConditionalExpression1 = new ConditionalExpression();
            this.UnaryExpression2 = new UnaryExpression();
            this.AssignmentOperator2 = new AssignmentOperator();
            this.AssignmentExpression2 = new AssignmentExpression();
        }
    }
}
