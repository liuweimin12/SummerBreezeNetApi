using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class MoveOrganizationRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 对象ID
        /// </summary>
        public int MoveToId { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        public string GetApiName()
        {
            return "chenggou.permission.organization.move";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"movetoid", MoveToId},
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("movetoid", MoveToId);
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
