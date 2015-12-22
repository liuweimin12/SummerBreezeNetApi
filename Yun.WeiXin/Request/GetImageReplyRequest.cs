using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.WeiXin.Response;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 获取图片回复
    /// </summary>
    public class GetImageReplyRequest:ITopRequest<GetImageResponse>
    {
        /// <summary>
        /// 账号ID
        /// </summary>
        public int RuleId { get; set; }
        public string GetApiName()
        {
            return "chenggou.weixin.imagereply.get";
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
