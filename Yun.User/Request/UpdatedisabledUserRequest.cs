using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class UpdateDisabledUserRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 是否禁用
        /// </summary>
        public bool IsDisabled { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }


        public string GetApiName()
        {
            return "chenggou.permission.user.updatedisabled";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"isdisabled", IsDisabled},
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("isdisabled", IsDisabled);
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
