using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    public class SaveMemoRequest : ITopRequest<BoolResultResponse>
    {
        public int Id { get; set; }

        public string Memo { get; set; }

        public int Flag { get; set; }

        public int SlaveFlag { get; set; }

        public string GetApiName()
        {
            return "chenggou.trade.memo.save";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"memo", Memo},
                {"flag", Flag},
                {"slaveflag",SlaveFlag },
                {"slaveflag",SlaveFlag }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
            RequestValidator.ValidateRequired("flag", Flag);
        }
    }
}
