using System.Collections.Generic;
using Yun.Interface;
using Yun.Site.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 查找站内信息
    /// yun.site.station.message.get
    /// </summary>
    public class GetStationMessageRequest : ITopRequest<GetStationMessageResponse>
    {
        /// <summary>
        /// ID 
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "yun.site.station.message.get";
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
