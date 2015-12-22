using System.Collections.Generic;
using System.Linq;
using Yun.Domain;

namespace Yun.Util
{
    public static class DateConvert
    {
        public static string ConvertMeta<T, V>(this IDictionary<T, V> dic)
        {
            if (dic != null && dic.Any())
            {
                var r = dic.Aggregate("", (current, v) => current + string.Format("{0}:{1}^", v.Key, v.Value));
                return r.Trim('^');
            }

            return null;
        }

        public static string GetValue(this IList<LongKeyValuePair> pair, long key)
        {
            var v = pair.FirstOrDefault(e => e.Key==key);
            return v != null ? v.Value : null;
        }

        public static string GetValue(this IList<StringKeyValuePair> pair, string key)
        {
            var v = pair.FirstOrDefault(e => e.Key == key);
            return v != null ? v.Value : null;
        }
    }
}
