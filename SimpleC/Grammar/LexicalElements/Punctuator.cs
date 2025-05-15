using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements
{
    [Grammar(Name = "punctuator",
             Description = "punctuator: one of (...)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_7,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_6)]
    public class Punctuator : Token
    {
        public Punctuator(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
