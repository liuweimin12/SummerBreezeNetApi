using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Shop.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 获取公司信息
    /// chenggou.company.get
    /// </summary>
    public class GetCompanyRequest : ITopRequest<GetCompanyResponse>
    {
        /// <summary>
        /// 公司ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.company.get";
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
