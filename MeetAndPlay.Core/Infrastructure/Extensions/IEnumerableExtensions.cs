using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MeetAndPlay.Core.Infrastructure.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<IEnumerable<T>> AsGroups<T>(this IEnumerable<T> enumerable, int groupCount)
        {
            if (enumerable == null)
                throw new ArgumentNullException(nameof(IEnumerable<T>));
            
            if (groupCount < 0)
                throw new ArgumentException("Group count should be positive.");
            
            var currentGroup = new List<T>();
            foreach (var item in enumerable)
            {
                if (currentGroup.Count < groupCount)
                    currentGroup.Add(item);

                if (currentGroup.Count != groupCount) 
                    continue;
                
                yield return currentGroup;
                currentGroup = new List<T>();
            }

            if (currentGroup.Any())
                yield return currentGroup;
        }
        
        public static IQueryable<TEntity> TakePage<TEntity>(this IQueryable<TEntity> query, int pageSize, int pageNumber)
            where TEntity : class
        {
            query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return query;
        }

    }
}