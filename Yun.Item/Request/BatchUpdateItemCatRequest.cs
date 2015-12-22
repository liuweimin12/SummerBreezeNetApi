using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 批量修改店铺内商品分类排序
    /// chenggou.itemcat.batchupdatesort
    /// </summary>
    public class BatchUpdateItemCatRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 排序内容，格式需要id:sort#id:sort以次进行循环
        /// </summary>
        public string SortContent { get; set; }

        public string GetApiName()
        {
            return "chenggou.itemcat.batchupdatesort";
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
