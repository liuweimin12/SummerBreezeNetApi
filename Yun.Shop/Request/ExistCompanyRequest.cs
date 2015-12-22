using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class ExistCompanyRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 待查询字段
        /// </summary>
        public string Content { get; set; }


        public string GetApiName()
        {
            return "chenggou.company.exist";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"content", Content}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("content", Content);
        }
    }
}
