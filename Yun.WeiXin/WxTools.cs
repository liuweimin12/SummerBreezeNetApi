using System.Collections.Generic;
using System.Linq;

namespace Yun.WeiXin
{
    public class WxTools
    {
        public static string TryGetKeywords(IList<KeyValuePair<TriggerTypeEnum, string>> keywords)
        {
            if (keywords == null || !keywords.Any()) return null;

            var r = keywords.Aggregate("", (current, pair) => current + string.Format("{0}^{1},", pair.Value, pair.Key));

            return r.Trim(',');
        }
    }
}
