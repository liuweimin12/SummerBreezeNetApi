using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Site.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 获取城市信息
    /// chenggou.city.get
    /// </summary>
    public class GetCityRequest : ITopRequest<GetCityResponse>
    {
        /// <summary>
        /// 城市ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.city.get";
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
