using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.WeiXin.Response;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 获取语音回复
    /// </summary>
    public class GetVoiceReplyRequest:ITopRequest<GetVoiceRepliesResponse>
    {
        /// <summary>
        /// 账号ID
        /// </summary>
        public int RuleId { get; set; }

        public string GetApiName()
        {
            return "chenggou.weixin.voicereply.get";
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
