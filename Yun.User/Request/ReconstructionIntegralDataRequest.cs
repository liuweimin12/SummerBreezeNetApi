using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.User.Request
{
    /// <summary>
    /// 重建积分数据
    /// yun.user.score.data.all.rebuild
    /// </summary>
    public class ReconstructionIntegralDataRequest : ITopRequest<IntResultResponse>
    {
        public string GetApiName()
        {
            return "yun.user.score.data.all.rebuild";
        }

        public IDictionary<string, string> GetParameters()
        {
            return new Dictionary<string, string>();
        }

        public void Validate()
        {
        }
    }
}
