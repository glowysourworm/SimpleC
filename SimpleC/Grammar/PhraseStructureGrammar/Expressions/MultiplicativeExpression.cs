using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class MultiplicativeExpression : GrammarBase
    {
        CastExpression _castExpression1;

        MultiplicativeExpression _multiplicativeExpression2;
        public const string MultiplicationOperator = GrammarCOperators.Multiplication;
        CastExpression _castExpression2;

        MultiplicativeExpression _multiplicativeExpression3;
        public const string DivisionOperator = GrammarCOperators.Division;
        CastExpression _castExpression3;

        MultiplicativeExpression _multiplicativeExpression4;
        public const string ModuloOperator = GrammarCOperators.Modulo;
        CastExpression _castExpression4;

        public CastExpression CastExpression1
        {
            get { return _castExpression1; }
            set { this.RaiseAndSetIfChanged(ref _castExpression1, value); }
        }
        public MultiplicativeExpression MultiplicativeExpression2
        {
            get { return _multiplicativeExpression2; }
            set { this.RaiseAndSetIfChanged(ref _multiplicativeExpression2, value); }
        }
        public CastExpression CastExpression2
        {
            get { return _castExpression2; }
            set { this.RaiseAndSetIfChanged(ref _castExpression2, value); }
        }
        public MultiplicativeExpression MultiplicativeExpression3
        {
            get { return _multiplicativeExpression3; }
            set { this.RaiseAndSetIfChanged(ref _multiplicativeExpression3, value); }
        }
        public CastExpression CastExpression3
        {
            get { return _castExpression3; }
            set { this.RaiseAndSetIfChanged(ref _castExpression3, value); }
        }
        public MultiplicativeExpression MultiplicativeExpression4
        {
            get { return _multiplicativeExpression4; }
            set { this.RaiseAndSetIfChanged(ref _multiplicativeExpression4, value); }
        }
        public CastExpression CastExpression4
        {
            get { return _castExpression4; }
            set { this.RaiseAndSetIfChanged(ref _castExpression4, value); }
        }

        public MultiplicativeExpression()
        {
            this.CastExpression1 = new CastExpression();
            this.CastExpression2 = new CastExpression();
            this.CastExpression3 = new CastExpression();
            this.CastExpression4 = new CastExpression();
            this.MultiplicativeExpression2 = new MultiplicativeExpression();
            this.MultiplicativeExpression3 = new MultiplicativeExpression();
            this.MultiplicativeExpression4 = new MultiplicativeExpression();
        }
    }
}
