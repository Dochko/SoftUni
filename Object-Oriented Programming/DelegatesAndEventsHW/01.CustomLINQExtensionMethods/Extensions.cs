using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomLINQExtensionMethods
{
    public static class Extensions
    {
        
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(element => !predicate(element)).ToList();
        }

        public static TSelector Max<TSource, TSelector>(
            this IEnumerable<TSource> collection,
            Func<TSource, TSelector> criteria)
            where TSelector : IComparable<TSelector>
        {
            TSelector max = criteria(collection.First());

            foreach (var item in collection.Where(item => max.CompareTo(criteria(item)) < 0))
            {
                max = criteria(item);
            }

            return max;
        }

        public static TSelector Min<TSource, TSelector>(
            this IEnumerable<TSource> collection,
            Func<TSource, TSelector> criteria)
            where TSelector : IComparable<TSelector>
        {
            TSelector min = criteria(collection.First());

            foreach (var item in collection.Where(item => min.CompareTo(criteria(item)) > 0))
            {
                min = criteria(item);
            }

            return min;
        }

        public static TSource MaxStudent<TSource, TSelector>(
            this IEnumerable<TSource> collection,
            Func<TSource, TSelector> criteria)
            where TSelector : IComparable<TSelector>
        {
            return collection.OrderByDescending(criteria).First();
        }

        public static TSource MinStudent<TSource, TSelector>(
            this IEnumerable<TSource> collection,
            Func<TSource, TSelector> criteria)
            where TSelector : IComparable<TSelector>
        {
            return collection.OrderBy(criteria).First();
        }
    }
}