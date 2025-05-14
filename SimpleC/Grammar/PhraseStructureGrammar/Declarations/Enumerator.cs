using SimpleC.Grammar.LexicalElements.Constants;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class Enumerator : GrammarBase
    {
        EnumerationConstant _enumerationConstant1;

        EnumerationConstant _enumerationConstant2;
        public const string AssignmentOperator2 = GrammarCOperators.Assignment;
        ConstantExpression _constantExpression2;

        public EnumerationConstant EnumerationConstant1
        {
            get { return _enumerationConstant1; }
            set { this.RaiseAndSetIfChanged(ref _enumerationConstant1, value); }
        }
        public EnumerationConstant EnumerationConstant2
        {
            get { return _enumerationConstant2; }
            set { this.RaiseAndSetIfChanged(ref _enumerationConstant2, value); }
        }
        public ConstantExpression ConstantExpression2
        {
            get { return _constantExpression2; }
            set { this.RaiseAndSetIfChanged(ref _constantExpression2, value); }
        }

        public Enumerator()
        {
            this.EnumerationConstant1 = new EnumerationConstant();
            this.EnumerationConstant2 = new EnumerationConstant();
            this.ConstantExpression2 = new ConstantExpression();
        }
    }
}
