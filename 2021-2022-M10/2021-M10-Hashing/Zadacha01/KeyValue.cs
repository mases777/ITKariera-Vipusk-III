using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    public class KeyValue<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public KeyValue(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        public override bool Equals(object obj)
        {
            KeyValue<TKey, TValue> element = (KeyValue<TKey, TValue>)obj;
            bool equals = Object.Equals(this.Key, element.Key) &&
                object.Equals(this.Value, element.Value);
            return equals;
        }

        public override int GetHashCode()
        {
            return this.CombineHashCode
                (
                    this.Key.GetHashCode(),
                    this.Value.GetHashCode()
                );
        }
        private int CombineHashCode(int v1, int v2)
        {
            return ((v1 << 5) + v1) ^ v2;
        }

        public override string ToString()
        {
            return $"[{this.Key} -> {this.Value}]";
        }
    }
}
