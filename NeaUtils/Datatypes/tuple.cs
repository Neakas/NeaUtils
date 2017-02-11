using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeaUtils.Datatypes
{
    public class Tuple<T1, T2, T3> : IEquatable<object>
    {
        public T1 Item1 { get; set; }

        public T2 Item2 { get; set; }

        public T3 Item3 { get; set; }

        public Tuple(T1 Item1, T2 Item2, T3 Item3)
        {
            this.Item1 = Item1;
            this.Item2 = Item2;
            this.Item3 = Item3;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Tuple)) return false;
            var tuple = (Tuple<T1, T2, T3>) obj;
            return Item1.Equals(tuple.Item1) && Item2.Equals(tuple.Item2) && Item3.Equals(tuple.Item3);
        }

        public override int GetHashCode() => Item1.GetHashCode() ^ Item2.GetHashCode() ^ Item3.GetHashCode();
    }
}
