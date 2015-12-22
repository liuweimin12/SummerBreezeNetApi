using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Distribution.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Distribution.Request
{
    /// <summary>
    /// 获取单条分销分成信息
    /// chenggou.distribution.level.get
    /// </summary>
    public class GetDistributionLevelRequest : ITopRequest<GetDistributionLevelResponse>
    {
        /// <summary>
        /// 等级ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.level.get";
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
