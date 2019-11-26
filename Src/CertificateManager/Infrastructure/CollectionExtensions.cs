using System;
using System.Collections.Generic;
using System.Linq;

namespace CertificateManager.Infrastructure
{
    public static class CollectionExtensions
    {
        public static void AddAll<T>(this ICollection<T> collection, IEnumerable<T> itemsToAdd)
        {
            foreach (T item in itemsToAdd)
            {
                collection.Add(item);
            }
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return collection == null || !collection.Any();
        }

        public static bool IsStringListNullOrEmpty(this IEnumerable<string> collection)
        {
            return collection == null || collection.All(String.IsNullOrWhiteSpace);
        }
    }
}