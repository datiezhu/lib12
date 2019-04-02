﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace lib12.Collections
{
    /// <summary>
    /// Handles empty objects creation
    /// </summary>
    public static class Empty
    {
        /// <summary>
        /// Returns empty enumerable of given type
        /// </summary>
        public static IEnumerable<T> Enumerable<T>()
        {
            return System.Linq.Enumerable.Empty<T>();
        }

        /// <summary>
        /// Returns empty array of given type
        /// </summary>
        /// <typeparam name="T">Type of array</typeparam>
        /// <returns></returns>
        public static T[] Array<T>()
        {
            return new T[0];
        }

        /// <summary>
        /// Returns empty list of given type
        /// </summary>
        /// <typeparam name="T">Type of list</typeparam>
        /// <returns></returns>
        public static List<T> List<T>()
        {
            return new List<T>(0);
        }

        /// <summary>
        /// Returns empty dictionary of given type
        /// </summary>
        /// <typeparam name="TKey">Type of key</typeparam>
        /// <typeparam name="TValue">Type of value</typeparam>
        /// <returns></returns>
        public static Dictionary<TKey, TValue> Dictionary<TKey, TValue>()
        {
            return new Dictionary<TKey, TValue>(0);
        }

        /// <summary>
        /// Returns read only collection of given type
        /// </summary>
        /// <typeparam name="T">Type of collection</typeparam>
        /// <returns></returns>
        public static ReadOnlyCollection<T> ReadOnlyCollection<T>()
        {
            return new ReadOnlyCollection<T>(Empty.List<T>());
        }

        /// <summary>
        /// Returns read only dictionary of given type
        /// </summary>
        /// <typeparam name="TKey">Type of key</typeparam>
        /// <typeparam name="TValue">Type of value</typeparam>
        /// <returns></returns>
        public static ReadOnlyDictionary<TKey, TValue> ReadOnlyDictionary<TKey, TValue>()
        {
            return new ReadOnlyDictionary<TKey, TValue>(Empty.Dictionary<TKey, TValue>());
        }
    }
}