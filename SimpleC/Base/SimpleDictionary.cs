using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Base
{
    internal class SimpleDictionary<TKey, TValue> : Dictionary<TKey, TValue>
    {
        public SimpleDictionary()
        {
        }

        public SimpleDictionary(IDictionary<TKey, TValue> dictionary) : base(dictionary)
        {
        }

        public SimpleDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection) : base(collection)
        {
        }

        public SimpleDictionary(IEqualityComparer<TKey>? comparer) : base(comparer)
        {
        }

        public SimpleDictionary(int capacity) : base(capacity)
        {
        }

        public SimpleDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey>? comparer) : base(dictionary, comparer)
        {
        }

        public SimpleDictionary(IEnumerable<KeyValuePair<TKey, TValue>> collection, IEqualityComparer<TKey>? comparer) : base(collection, comparer)
        {
        }

        public SimpleDictionary(int capacity, IEqualityComparer<TKey>? comparer) : base(capacity, comparer)
        {
        }

        protected SimpleDictionary(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public override bool Equals(object? obj)
        {
            return obj is SimpleDictionary<TKey, TValue> dictionary &&
                   EqualityComparer<IEqualityComparer<TKey>>.Default.Equals(this.Comparer, dictionary.Comparer) &&
                   this.Count == dictionary.Count &&
                   EqualityComparer<KeyCollection>.Default.Equals(this.Keys, dictionary.Keys) &&
                   EqualityComparer<ValueCollection>.Default.Equals(this.Values, dictionary.Values);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Comparer, this.Count, this.Keys);
        }
    }
}
