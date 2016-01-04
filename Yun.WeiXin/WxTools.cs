using System.Collections.Generic;
using System.Linq;

namespace Yun.WeiXin
{
    public class WxTools
    {
        public static List<TriggerTypeJson> TryGetKeywords(IList<KeyValuePair<TriggerTypeEnum, string>> keywords)
        {
            if (keywords == null || !keywords.Any()) return null;

            return
                keywords.Select(m => new TriggerTypeJson {keyword = m.Value, trigger_type = m.Key.ToString().ToLower()})
                    .ToList();
        }
    }
}
