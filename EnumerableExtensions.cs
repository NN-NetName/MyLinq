﻿using System;
using System.Collections.Generic;

namespace MuLinq
{
    public static class EnumerableExtensions
    {
        public static TSource[] Where<TSource>(this IEnumerable<TSource> source, Predicate<TSource> criterion)
        {

            if (source == null)
                throw new InvalidOperationException();

            var result = new List<TSource>();
            foreach (var item in source)
            {
                if (criterion?.Invoke(item) == true)
                    result.Add(item);
            }

            return result.ToArray();    
        }
        public static TSource First<TSource>(this IEnumerable<TSource> source)
        {
            foreach (var item in source)
                return item;

            throw new InvalidOperationException();
        }
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            foreach (var item in source)
                return item;

            return default(TSource);
        }
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Predicate<TSource> criterion)
        {
            foreach (var item in source)
                if (criterion?.Invoke(item) is true)
                    return item;

            return default(TSource);
        }
    }
}