using System;

using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace SimpleC.Workbench.Component.CodeAnalysis
{
    public class CParseTreeListener : CBaseListener
    {
        public event EventHandler<IErrorNode> VisitErrorNodeEvent;
        public event EventHandler<ITerminalNode> VisitTerminalEvent;

        public override void VisitErrorNode([NotNull] IErrorNode node)
        {
            base.VisitErrorNode(node);

            if (this.VisitErrorNodeEvent != null)
                this.VisitErrorNodeEvent(this, node);
        }

        public override void VisitTerminal([NotNull] ITerminalNode node)
        {
            base.VisitTerminal(node);

            if (this.VisitTerminalEvent != null)
                this.VisitTerminalEvent(this, node);
        }
    }
}
