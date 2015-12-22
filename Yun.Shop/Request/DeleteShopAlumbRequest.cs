using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class DeleteShopAlumbRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 照片的id，多个ID用英文逗号分割
        /// </summary>
        public string Ids { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.alumb.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"ids", Ids}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ids", Ids);
        }
    }
}
