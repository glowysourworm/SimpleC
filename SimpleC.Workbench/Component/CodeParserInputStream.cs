using System;

using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

namespace SimpleC.Workbench.Component
{
    public class CodeParserInputStream : ICharStream
    {
        private string _codeString;

        public int Index { get; private set; }
        public int Size { get; private set; }
        public string SourceName { get; private set; }

        public CodeParserInputStream()
        {
            _codeString = "";
        }

        public void Consume()
        {
            this.Index++;
        }

        [return: NotNull]
        public string GetText(Interval interval)
        {
            return _codeString.Substring(interval.a, interval.b - interval.a + 1);
        }

        public int LA(int i)
        {
            if (i < -1)
                throw new ArgumentException("ICharStream.LA must have a value greater than or equal to -1");

            // Copied from BaseCharInputStream
            if (i == 0)
            {
                return 0;
            }

            if (i < 0)
            {
                i++;    // ??? This won't be saved to the input integer
                if (this.Index + i - 1 < 0)
                {
                    return -1;
                }
            }

            if (this.Index + i - 1 >= _codeString.Length)
            {
                return -1;
            }

            return _codeString[this.Index + i - 1];
        }

        public void Load(string codeString)
        {
            _codeString = codeString;
        }

        public int Mark()
        {
            return -1; // SEE BaseCharInputStream (!)
        }

        public void Release(int marker)
        {
            // SEE BaseCharInputStream (!)
        }

        public void Seek(int index)
        {
            this.Index = index;
        }
    }
}
