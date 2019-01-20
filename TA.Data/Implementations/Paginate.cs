using System;
using System.Collections.Generic;
using System.Linq;
using TA.Data.Interfaces;

namespace TA.Data.Implementations
{
    public class Paginate<T> : IPaginate<T>
    {
        public int From { get; set; }

        public int Index { get; set; }

        public int Size { get; set; }

        public int Count { get; set; }

        public int Pages { get; set; }

        public IList<T> Items { get; set; }

        public bool HasPrevious => Index - From > 0;

        public bool HasNext => Index - From + 1 < Pages;

        internal Paginate(IEnumerable<T> source, int index, int size, int from)
        {
            var enumerable = source as T[] ?? source.ToArray();
            if (from > index)
            {
                throw new ArgumentException($"From: {from} must be < than Index: {index}");
            }
            else if (source is IQueryable<T> queryable)
            {
                Index = index;
                Size = size;
                From = from;
                Count = queryable.Count();
                Pages = (int)Math.Ceiling(Count / (double)Size);

                Items = queryable.Skip((Index - From) * Size).Take(Size).ToList();
            }
            else
            {
                Index = index;
                Size = size;
                From = from;
                Count = enumerable.Count();
                Pages = (int)Math.Ceiling(Count / (double)Size);
                Items = enumerable.Skip((Index - From) * Size).Take(Size).ToList();
            }
        }
        internal Paginate() => Items = new T[0];
    }
}
