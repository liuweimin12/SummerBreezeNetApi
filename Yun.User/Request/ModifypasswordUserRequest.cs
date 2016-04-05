using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 修改子账号的密码
    /// 修改当前登录人员的子账号密码
    /// 必须授权
    /// </summary>
    public class ModifyPasswordUserRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 子帐号ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.user.modifypassword";
        }

        /// <summary>
        /// APP密匙
        /// 不要写入文档
        /// </summary>
        public string AppSecret { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"password", TopUtils.EncryptAes(Password, AppSecret)},
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("password", Password);
        }
    }
}
