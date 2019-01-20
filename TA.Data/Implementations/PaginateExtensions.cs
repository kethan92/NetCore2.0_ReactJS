using System.Collections.Generic;
using TA.Data.Interfaces;

namespace TA.Data.Implementations
{
    public static class PaginateExtensions
    {
        public static IPaginate<T> ToPaginate<T>(this IEnumerable<T> source, int index, int size, int from = 0) => new Paginate<T>(source, index, size, from);
    }
}
