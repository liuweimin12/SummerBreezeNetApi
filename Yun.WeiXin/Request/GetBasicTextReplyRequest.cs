using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.WeiXin.Response;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 获取文字回复内容
    /// </summary>
    public class GetBasicTextReplyRequest : ITopRequest<GetBasicRepliesResponse>
     {
         /// <summary>
         /// 规则ID
         /// </summary>
         public int RuleId { get; set; }
         public string GetApiName()
         {
             return "chenggou.weixin.textreply.get";
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
