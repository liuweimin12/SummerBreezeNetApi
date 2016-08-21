using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 更新公司信息
    /// chenggou.company.update
    /// </summary>
    public class UpdateCompanyRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 公司ID
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// 店名
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 分成比例
        /// </summary>
        public double? PayDeduction { get; set; }

        

        public string GetApiName()
        {
            return "chenggou.company.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"name",Name},
                {"paydeduction",PayDeduction}
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
