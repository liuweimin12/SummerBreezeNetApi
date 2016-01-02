using System.Collections.Generic;
using System.Linq;
using Yun.Interface;
using Yun.Response;

namespace Yun.Item.Request
{
    /// <summary>
    /// 批量更新组织机构的排序
    /// chenggou.permission.organization.batchupdate
    /// </summary>
    public class BatchUpdateOrganizationRequest : ITopRequest<BoolResultResponse>
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
            return "chenggou.permission.organization.batchupdate";
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
