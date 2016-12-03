using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class GerPermissionUserRequest : ITopRequest<UserDetailResponse>
    {
        public string GetApiName()
        {
            return "chenggou.permission.user.get";
        }


        public int Id { get; set; }

        public string Fields { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"fields",Fields}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
