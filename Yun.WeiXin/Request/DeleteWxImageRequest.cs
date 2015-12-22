using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 删除图片回复
    /// </summary>
    public class DeleteWxImageRequest:ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 规则ID
        /// </summary>
        public int RuleId { get; set; }
        public string GetApiName()
        {
            return "chenggou.weixin.imagereply.delete";
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
