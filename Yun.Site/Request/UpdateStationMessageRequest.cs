using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 更改站内信，包括是否阅读的修改
    /// yun.site.station.message.update
    /// </summary>
    public class UpdateStationMessageRequest :ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// ID 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }


        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }


        /// <summary>
        /// 是否阅读
        /// </summary>
        public bool? IsRead { get; set; }


        public string GetApiName()
        {
            return "yun.site.station.message.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"content",Content},
                {"id",Id},
                {"title",Title},
                {"isread",IsRead}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
