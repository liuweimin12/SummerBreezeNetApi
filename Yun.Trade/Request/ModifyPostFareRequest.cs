using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class ModifyPostFareRequest : ITopRequest<BoolResultResponse>
    {
        public int Id { get; set; }

        public double Postfee { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.postage.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"postfee", Postfee}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("postfee", Postfee);
            RequestValidator.ValidateMinValue("postfee", Postfee, 0);
        }
    }
}
