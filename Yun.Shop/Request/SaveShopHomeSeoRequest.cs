using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class SaveShopHomeSeoRequest : ITopRequest<BoolResultResponse>
    {
        public string Title { get; set; }

        public string Keyword { get; set; }

        public string Description { get; set; }


        public string GetApiName()
        {
            return "chenggou.shop.home.seo.save";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"title", Title},
                {"keyword",Keyword},
                {"description",Description}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("title", this.Title, 1000);
            RequestValidator.ValidateMaxLength("keyword", this.Keyword, 2000);
            RequestValidator.ValidateMaxLength("description", this.Description, 2000);
        }
    }
}
