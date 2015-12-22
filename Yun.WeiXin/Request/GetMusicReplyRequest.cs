using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.WeiXin.Response;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 获取音乐回复
    /// </summary>
    public class GetMusicReplyRequest:ITopRequest<GetMusicRepliesResponse>
    {
        /// <summary>
        /// 规则ID
        /// </summary>
        public int RuleId { get; set; }
        public string GetApiName()
        {
            return "chenggou.weixin.musicreply.get";
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
