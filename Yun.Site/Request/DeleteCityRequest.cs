using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.Site.Request
{
    /// <summary>
    /// 删除自定义城市
    /// chenggou.city.delete
    /// </summary>
    public class DeleteCityRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 城市ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.city.delete";
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

        }
    }
}
