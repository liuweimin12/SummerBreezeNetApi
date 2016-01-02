using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class GetFunctionsRequest : ITopRequest<FunctionsResponse>  
    {
        public int? FunctionType { get; set; }

        /// <summary>
        /// 是否只筛选显示的内容
        /// </summary>
        public bool OnlyShowDisplay { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.functions.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"onlyshowdisplay", OnlyShowDisplay},
                {"functiontype",FunctionType},
                {"companyid",CompanyId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
