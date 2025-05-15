using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "nonzero-digit",
             Description = "nonzero-digit: one of (...)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class NonZeroDigit : GrammarConstant
    {
        // ONE OF:  1 2 3 4 5 6 7 8 9
        public NonZeroDigit(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
