using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 删除语音回复
    /// </summary>
    public class DeleteWxVoiceRequest:ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 规则ID
        /// </summary>
        public int RuleId { get; set; }
        public string GetApiName()
        {
            return "chenggou.weixin.voicereply.delete";
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
