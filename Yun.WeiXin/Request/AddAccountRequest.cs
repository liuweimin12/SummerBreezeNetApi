using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.WeiXin.Request
{
   public class AddAccountRequest:ITopRequest<IntResultResponse>
   {
       /// <summary>
       /// 公众号名称
       /// </summary>
       public string Name { get; set; }

       /// <summary>
       /// 微信公众号描述
       /// </summary>
       public string Description { get; set; }

       /// <summary>
       /// 公众号帐号
       /// </summary>
       public string Account { get; set; }

       /// <summary>
       /// 原始ID
       /// </summary>
       public string Original { get; set; }

       /// <summary>
       /// 级别,0:普通订阅号,1:认证订阅号/普通服务号,2:认证服务号
       /// </summary>
       public int Level { get; set; }

       /// <summary>
       /// APPID
       /// </summary>
       public string AppId { get; set; }

       /// <summary>
       /// AppSecret
       /// </summary>
       public string AppSecret { get; set; }

       /// <summary>
       /// 二维码
       /// </summary>
       public string Qrcode { get; set; }

       /// <summary>
       /// 头像
       /// </summary>
       public string Avatar { get; set; }

       public string GetApiName()
       {
           return "chenggou.weixin.account.add";
       }

       public IDictionary<string, string> GetParameters()
       {
           var parameters = new YunDictionary
            {
                {"name", Name},
                {"description",Description},
                {"account",Account},
                {"original",Original},
                {"level",Level},
                {"appid",AppId},
                {"appsecret",AppSecret},
                {"qrcode",Qrcode},
                {"avatar",Avatar}
            };
           return parameters;
       }

       public void Validate()
       {
           RequestValidator.ValidateRequired("name", Name);
       }
   }
}
