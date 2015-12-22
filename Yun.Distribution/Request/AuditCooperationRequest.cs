using System;
using System.Collections.Generic;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Distribution.Request
{
    public class AuditCooperationRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 绑定现有用户成为分销用户
        /// </summary>
        public string UserName { get; set; }

        public string Ip { get; set; }

        public string Note { get; set; }

        /// <summary>
        /// 上家的用户昵称
        /// </summary>
        public string SuperiorDistributor { get; set; }

        /// <summary>
        /// 上家的用户ID
        /// </summary>
        public int SuperiorDistributorId { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.cooperation.audit";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"username",UserName},
                {"ip",Ip},
                {"note",Note},
                {"superiordistributor",SuperiorDistributor},
                {"superiordistributorid",SuperiorDistributorId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ip", Ip);

        }
    }
}
