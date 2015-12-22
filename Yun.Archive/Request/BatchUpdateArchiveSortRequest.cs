using System.Collections.Generic;
using System.Linq;
using Yun.Interface;
using Yun.Response;

namespace Yun.Item.Request
{
    /// <summary>
    /// 批量更新文章分类排序
    /// chenggou.archive.category.batchupdate
    /// </summary>
    public class BatchUpdateArchiveSortRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// id,排序
        /// </summary>
        public Dictionary<int, int> Sort { get; set; }

        private static string ConvertSort(Dictionary<int, int> sort)
        {
            if (sort == null || !sort.Any())
            {
                return "";
            }

            var s = "";
            foreach (var i in sort)
            {
                s += string.Format("{0}:{1}#", i.Key, i.Value);
            }

            return s.Trim('#');
        }

        public string GetApiName()
        {
            return "chenggou.archive.category.batchupdate";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"sortcontent", ConvertSort(Sort)}
            };
            return parameters;
        }

        public void Validate()
        {
           
        }
    }
}
