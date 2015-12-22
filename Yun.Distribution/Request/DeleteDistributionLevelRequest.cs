using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Distribution.Request
{
    /// <summary>
    /// 删除店铺内分销的利润分成等级
    /// chenggou.distribution.level.delete
    /// </summary>
    public class DeleteDistributionLevelRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 等级ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.level.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
