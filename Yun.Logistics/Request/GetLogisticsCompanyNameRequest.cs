using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Logistics.Response;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 获取可查询物流走单记录的物流公司名字
    /// chenggou.logistics.companies.get
    /// </summary>
    public class GetLogisticsCompanyNameRequest : ITopRequest<GetLogisticsCompanyNameResponse>
    {
        public string GetApiName()
        {
            return "chenggou.logistics.companies.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {

            };
            return parameters; 
        }

        public void Validate()
        {
            
        }
    }
}
