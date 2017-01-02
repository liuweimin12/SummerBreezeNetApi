using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 删除站内信
    /// yun.site.station.message.delete
    /// </summary>
    public class DeleteStationMessageRequest:ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// ID 
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "yun.site.station.message.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
