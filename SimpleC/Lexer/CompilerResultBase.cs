using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleC.Base;
using SimpleC.Main;
using SimpleC.Main.Interface;

namespace SimpleC.Lexer
{
    public abstract class CompilerResultBase
    {
        public SimpleList<ICCompilerEventData> Events { get; private set; }
        public CCompilerPass Pass { get; private set; }

        public CompilerResultBase(IEnumerable<ICCompilerEventData> events, CCompilerPass pass)
        {
            this.Events = new SimpleList<ICCompilerEventData>(events);
            this.Pass = pass;
        }

        public bool Passed()
        {
            return !this.Events.Any(x => x.Severity == CCompilerEventSeverity.Error);
        }
    }
}
