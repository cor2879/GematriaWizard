using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GematriaWizard.Utility.Extensions
{
    public static class IEnumerableExtension
    {
        public static bool ValueEquals<T>(this IEnumerable<T> ienumerable, IEnumerable<T> other)
            where T : IEquatable<T>
        {
            if (ienumerable == null)
            {
                throw new ArgumentNullException(nameof(ienumerable));
            }

            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));  
            }

            var equal = ienumerable.Count().Equals(other.Count());
            var index = ienumerable.Count() - 1;

            while (equal)
            {
                equal = ienumerable.ElementAt(index).Equals(other.ElementAt(index));
                --index;
            }

            return equal;
        }       
    }
}
