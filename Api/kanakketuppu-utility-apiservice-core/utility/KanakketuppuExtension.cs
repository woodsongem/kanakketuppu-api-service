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

        public static bool IsEmpty(this string value)
        {
            if (value == null)
                return true;
            return string.IsNullOrWhiteSpace(value);
        }

        public static long ToLong(this string value)
        {
            if (value.IsEmpty())
                return 0;
            if (long.TryParse(value, out long result))
                return 0;
            return result;
        }
    }
}