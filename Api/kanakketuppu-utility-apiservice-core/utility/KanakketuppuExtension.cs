using System.Linq;
using System.Collections.Generic;

namespace KanakketuppuUtilityApiServiceCore.Utility
{
    public static class KanakketuppuExtension
    {
        public static bool AnyWithNullCheck<TSource>(this IEnumerable<TSource> value)
        {
            if (value == null)
                return false;
            return value.Any();
        }

        public static bool IsEmpty(this object value)
        {
            return value == null;
        }
    }
}