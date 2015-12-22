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
    /// 添加店铺内分销的利润分成等级
    /// chenggou.distribution.level.add
    /// </summary>
    public class AddDistributionLevelRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 分销等级模板
        /// </summary>
        public int TemplateId { get; set; }


        /// <summary>
        /// 利润分成百分比，1-100%
        /// </summary>
        public double Proportion { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.level.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"proportion",Proportion},
                {"remark",Remark},
                {"templateid",TemplateId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("proportion", Proportion);
        }
    }
}
