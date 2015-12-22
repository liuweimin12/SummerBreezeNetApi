using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 更改商品状态，可自定义的
    /// chenggou.item.state.modify
    /// </summary>
    public class UpdateItemStateRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int StateCode { get; set; }


        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.state.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"statecode",StateCode},
                {"itemid",ItemId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("statecode", StateCode);
            RequestValidator.ValidateRequired("itemid", ItemId);
        }
    }
}
