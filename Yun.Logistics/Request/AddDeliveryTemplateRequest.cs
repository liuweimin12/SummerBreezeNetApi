using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Logistics.Request
{
    public class AddDeliveryTemplateRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 模板名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 免邮数量，0不包邮
        /// </summary>
        public int Farefree { get; set; }


        /// <summary>
        ///物流运费价格
        /// </summary>
        public List<LogisticsPriceJson> LogisticsPrice { get; set; }


        /// <summary>
        /// 促销战略（包邮）
        /// </summary>
        public List<FareFreeJson> FareFreeStrategy { get; set; }


        /// <summary>
        /// 计费方式
        /// 0：按件数，1：按重量，2：按体积
        /// </summary>
        public int PriceType { get; set; }

        public string GetApiName()
        {
            return "chenggou.delivery.template.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"title",Title},
                {"farefree", Farefree},
                {"logisticsprice",LogisticsPrice},
                {"farefreestrategy",FareFreeStrategy},
                {"pricetype",PriceType}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("title", Title);
            RequestValidator.ValidateRequired("farefree", Farefree);
        }
    }
}
