using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class ArgumentExpressionList : GrammarBase
    {
        AssignmentExpression _assignmentExpression1;

        ArgumentExpressionList _argumentExpressionList2;
        public const char CommaSeparator2 = GrammarCConstants.Comma;
        AssignmentExpression _assignmentExpression2;

        public AssignmentExpression AssignmentExpression1
        {
            get { return _assignmentExpression1; }
            set { this.RaiseAndSetIfChanged(ref _assignmentExpression1, value); }
        }
        public ArgumentExpressionList ArgumentExpressionList2
        {
            get { return _argumentExpressionList2; }
            set { this.RaiseAndSetIfChanged(ref _argumentExpressionList2, value); }
        }
        public AssignmentExpression AssignmentExpression2
        {
            get { return _assignmentExpression2; }
            set { this.RaiseAndSetIfChanged(ref _assignmentExpression2, value); }
        }

        public ArgumentExpressionList()
        {
            this.AssignmentExpression1 = new AssignmentExpression();
            this.AssignmentExpression2 = new AssignmentExpression();
            this.ArgumentExpressionList2 = new ArgumentExpressionList();
        }
    }
}
