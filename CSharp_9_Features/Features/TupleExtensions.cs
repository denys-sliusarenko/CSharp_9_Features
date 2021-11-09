using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9_Features.Features
{
    public static class TupleExtensions
    {
        public static IEnumerator<T>
            GetEnumerator<T>(this ValueTuple<T, T, T, T> tuple)
        {
            yield return tuple.Item1;
            yield return tuple.Item2;
            yield return tuple.Item3;
            yield return tuple.Item4;
        }

        public static IEnumerator<Index> GetEnumerator(this Range number)
        {
            for (Index i = number.Start; i.Value < number.End.Value; i = i.Value + 1)
            {
                yield return i;
            }
        }
    }
}
