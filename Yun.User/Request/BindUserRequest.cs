using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class BindUserRequest : ITopRequest<IntResultResponse>
    {
        public string UserName { get; set; }

        public string Ip { get; set; }

        public string Note { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.cooperation.audit";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new TopDictionary
            {
                {"ip",Ip},
                {"note",Note},
                {"username",UserName}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("username", UserName);
            RequestValidator.ValidateRequired("ip", Ip);

        }
    }
}
