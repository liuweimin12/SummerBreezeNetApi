using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class SaveRelationRoleFunctionRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 功能ID，多个功能之间用英文逗号分隔
        /// </summary>
        public string FunctionIds { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleId { get; set; }


        public string GetApiName()
        {
            return "chenggou.permission.role.function.saverelation";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"functionids", FunctionIds},
                {"roleid",RoleId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("functionids", FunctionIds);
            RequestValidator.ValidateRequired("roleid", RoleId);
        }
    }
}
