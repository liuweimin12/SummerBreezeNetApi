using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Logistics.Request
{
    public class DeleteDeliveryTemplateRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 模板id
        /// </summary>
        public int Id { get; set; }

        public string GetApiName()
        {
            return "chenggou.delivery.template.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id}
            };
            return parameters; 
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
