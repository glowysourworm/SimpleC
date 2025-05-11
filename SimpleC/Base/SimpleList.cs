using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Base
{
    public class SimpleList<T> : List<T>
    {
        public SimpleList()
        {
        }

        public SimpleList(IEnumerable<T> list) : base(list)
        {

        }
    }
}
