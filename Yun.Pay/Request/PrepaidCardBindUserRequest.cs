using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 充值卡和用户进行绑定
    /// chenggou.prepaidcard.binduser
    /// </summary>
    public class PrepaidCardBindUserRequest : ITopRequest<IntResultResponse>
     {
         /// <summary>
         /// APP密匙
         /// </summary>
         public string AppSecret { get; set; }

         /// <summary>
         /// 卡号
         /// </summary>
         public string CardNumber { get; set; }


         /// <summary>
         /// 需要被绑定的用户名
         /// </summary>
         public string BoundNick { get; set; }


         /// <summary>
         /// IP地址
         /// </summary>
         public string IpAddress { get; set; }


         /// <summary>
         /// 卡密码
         /// </summary>
         public string CardPassword { get; set; }

         /// <summary>
         /// 是否允许强制绑定
         /// </summary>
         public bool CanStrictBind { get; set; }

         public string GetApiName()
         {
             return "chenggou.prepaidcard.binduser";
         }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"cardnumber", CardNumber},
                {"boundnick", BoundNick},
                {"ipaddress", IpAddress},
                {"cardpassword", TopUtils.EncryptAes(CardPassword, AppSecret)},
                {"canstrictbind", CanStrictBind}
            };
            return parameters;
        }

        public void Validate()
         {
             RequestValidator.ValidateRequired("cardnumber", this.CardNumber);
             RequestValidator.ValidateRequired("boundnick", this.BoundNick);
         }
     }
}
