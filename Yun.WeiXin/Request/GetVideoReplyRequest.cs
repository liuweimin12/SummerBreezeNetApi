using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.WeiXin.Response;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 获取视频回复
    /// </summary>
    public class GetVideoReplyRequest:ITopRequest<GetVideoRepliesResponse>
    {
        /// <summary>
        /// 账号ID
        /// </summary>
        public int RuleId { get; set; }
        public string GetApiName()
        {
            return "chenggou.weixin.videoreply.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ruleid",RuleId}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
