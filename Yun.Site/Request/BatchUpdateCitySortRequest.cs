using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 批量更新城市的排序
    /// chenggou.city.batchupdatesort
    /// </summary>
    public class BatchUpdateCitySortRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 排序内容，格式需要id:sort#id:sort以次进行循环
        /// </summary>
        public string SortContent { get; set; }

        public string GetApiName()
        {
            return "chenggou.city.batchupdatesort";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"sortcontent",SortContent}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("sortcontent", SortContent);
        }
    }
}
