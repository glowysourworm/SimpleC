using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class EqualityExpression : GrammarBase
    {
        RelationalExpression _relationalExpression1;

        EqualityExpression _equalityExpression2;
        public const string EqualityComparisonOperator2 = GrammarCOperators.Equality;
        RelationalExpression _relationalExpression2;

        EqualityExpression _equalityExpression3;
        public const string EqualityNOTComparisonOperator2 = GrammarCOperators.EqualityNOT;
        RelationalExpression _relationalExpression3;

        public RelationalExpression RelationalExpression1
        {
            get { return _relationalExpression1; }
            set { this.RaiseAndSetIfChanged(ref _relationalExpression1, value); }
        }
        public EqualityExpression EqualityExpression2
        {
            get { return _equalityExpression2; }
            set { this.RaiseAndSetIfChanged(ref _equalityExpression2, value); }
        }
        public RelationalExpression RelationalExpression2
        {
            get { return _relationalExpression2; }
            set { this.RaiseAndSetIfChanged(ref _relationalExpression2, value); }
        }
        public EqualityExpression EqualityExpression3
        {
            get { return _equalityExpression3; }
            set { this.RaiseAndSetIfChanged(ref _equalityExpression3, value); }
        }
        public RelationalExpression RelationalExpression3
        {
            get { return _relationalExpression3; }
            set { this.RaiseAndSetIfChanged(ref _relationalExpression3, value); }
        }

        public EqualityExpression()
        {
            this.EqualityExpression2 = new EqualityExpression();
            this.EqualityExpression3 = new EqualityExpression();
            this.RelationalExpression1 = new RelationalExpression();
            this.RelationalExpression2 = new RelationalExpression();
            this.RelationalExpression3 = new RelationalExpression();
        }
    }
}
