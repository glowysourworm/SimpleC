using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class StructDeclarator : GrammarBase
    {
        Declarator _declarator1;

        Declarator? _declarator2;
        public const char ColorSeparator2 = GrammarCConstants.Colon;
        ConstantExpression _constantExpression2;

        public Declarator Declarator1
        {
            get { return _declarator1; }
            set { this.RaiseAndSetIfChanged(ref _declarator1, value); }
        }
        public Declarator? Declarator2
        {
            get { return _declarator2; }
            set { this.RaiseAndSetIfChanged(ref _declarator2, value); }
        }
        public ConstantExpression ConstantExpression2
        {
            get { return _constantExpression2; }
            set { this.RaiseAndSetIfChanged(ref _constantExpression2, value); }
        }

        public StructDeclarator()
        {
            this.Declarator1 = new Declarator();
            this.Declarator2 = null;
            this.ConstantExpression2 = new ConstantExpression();
        }
    }
}
