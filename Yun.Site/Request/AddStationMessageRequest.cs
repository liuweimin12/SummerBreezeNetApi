using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 新增站内信
    /// yun.site.station.message.add
    /// </summary>
    public class AddStationMessageRequest: ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 接收人ID
        /// </summary>
        public int ReceiverId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }


        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }


        public string GetApiName()
        {
            return "yun.site.station.message.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"content",Content},
                {"receiverid",ReceiverId},
                {"title",Title}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("receiverid", ReceiverId, 1);
            RequestValidator.ValidateRequired("title", Title);
        }
    }
}
