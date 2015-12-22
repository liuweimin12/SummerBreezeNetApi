using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Distribution.Request
{
    /// <summary>
    /// 更新店铺内分销的利润分成等级
    /// chenggou.distribution.level.update
    /// </summary>
    public class UpdateDistributionLevelRequest : ITopRequest<BoolResultResponse>
    {

        /// <summary>
        /// 利润分成百分比，1-100%
        /// </summary>
        public double Proportion { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        /// <summary>
        /// 等级ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.level.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"proportion",Proportion},
                {"remark",Remark},
                {"id",Id}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("proportion", Proportion);
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
