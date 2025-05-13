using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleC.Grammar.LexicalElements;

namespace SimpleC.Grammar.LexicalElements.HeaderNames
{
    /// <summary>
    /// Not sure if this should be an "expression". The documentation points to 
    /// this being sets of literal constants. So, this would be a static structure
    /// (obviously) for a header name to be evaluated. So, some of these lexical
    /// elements might be named otherwise. (not a token, but not an expression)
    /// </summary>
    public class HeaderName : GrammarBase
    {
        public const char CaretLeftPrefix1 = GrammarCConstants.CaretLeft;
        HCharSequence _hCharSequence1;
        public const char CaretRightSuffix1 = GrammarCConstants.CaretRight;

        public const char DoubleQuotePrefix2 = GrammarCConstants.DoubleQuote;
        QCharSequence _qCharSequence2;
        public const char DoubleQuoteSuffix2 = GrammarCConstants.DoubleQuote;

        public HCharSequence HCharSequence1
        {
            get { return _hCharSequence1; }
            set { this.RaiseAndSetIfChanged(ref _hCharSequence1, value); }
        }
        public QCharSequence QCharSequence2
        {
            get { return _qCharSequence2; }
            set { this.RaiseAndSetIfChanged(ref _qCharSequence2, value); }
        }

        public HeaderName()
        {
            this.HCharSequence1 = new HCharSequence();
            this.QCharSequence2 = new QCharSequence();
        }
    }
}
