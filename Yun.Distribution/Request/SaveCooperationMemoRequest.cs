using System;
using System.Collections.Generic;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Distribution.Request
{
    public class SaveCooperationMemoRequest: ITopRequest<BoolResultResponse>
    {
        public int Id { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }

        public string GetApiName()
        {
            return "chenggou.distribution.cooperation.memo.save";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"note",Note}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("id", Id, 1);
        }
    }
}
