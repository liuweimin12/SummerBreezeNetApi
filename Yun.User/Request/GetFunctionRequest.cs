using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    public class GetFunctionRequest : ITopRequest<FunctionResponse>  
    {
        /// <summary>
        /// 功能ID
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.permission.function.get";
        }

        public IDictionary<string, string> GetParameters()
        {
             var parameters = new YunDictionary
            {
                {"id", Id}
            };
            return parameters;
        }
        

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
