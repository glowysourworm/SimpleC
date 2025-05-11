using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleC.Code
{
    /// <summary>
    /// String that encapsulates searching / indexing / regex for a char[]. The point is to avoid
    /// Linq syntax, and to pin down any performance enhancements. The usage of this class should
    /// be for the ScopeBlock - which is the primary string encapsulator for a code file. This
    /// (recursive) structure will have instances of CodeString - which are going to supply any
    /// searches that are warranted by the compiler.
    /// </summary>
    public class CodeString
    {
        private readonly string _string;

        /// <summary>
        /// Trimming is assumed during construction of CodeString. Whitespace will be trimmed.
        /// </summary>
        /// <param name="anyString"></param>
        public CodeString(string anyString)
        {
            _string = anyString.Trim();
        }

        public string[] Split(char[] chars)
        {
            return _string.Split(chars);
        }

        public int First(string subString)
        {
            if (string.IsNullOrEmpty(subString))
                return -1;

            var searchIndex = 0;
            var index = 0;

            for (index = 0; index < _string.Length && searchIndex < subString.Length; index++)
            {
                if (_string[index] == subString[searchIndex])
                    searchIndex++;

                else
                    searchIndex = 0;
            }

            // Found (index will be (at most) one of length) (searchIndex will be at length)
            if (searchIndex > 0)
            {
                return index - searchIndex + 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return _string;
        }
    }
}
