using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class Expression : GrammarBase
    {
        AssignmentExpression _assignmentExpression1;

        Expression _expression2;
        public const char CommaSeparator2 = GrammarCConstants.Comma;
        AssignmentExpression _assignmentExpression2;

        public AssignmentExpression AssignmentExpression1
        {
            get { return _assignmentExpression1; }
            set { this.RaiseAndSetIfChanged(ref _assignmentExpression1, value); }
        }
        public Expression Expression2
        {
            get { return _expression2; }
            set { this.RaiseAndSetIfChanged(ref _expression2, value); }
        }
        public AssignmentExpression AssignmentExpression2
        {
            get { return _assignmentExpression2; }
            set { this.RaiseAndSetIfChanged(ref _assignmentExpression2, value); }
        }

        public Expression()
        {
            this.AssignmentExpression2 = new AssignmentExpression();
            this.Expression2 = new Expression();
            this.AssignmentExpression1 = new AssignmentExpression();
        }
    }
}
