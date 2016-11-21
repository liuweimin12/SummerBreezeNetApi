
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Shop.Response
{
    [XmlRoot("get_shop_financial_summary_response")]
    public class GetShopFinancialSummaryResponse : YunResponse
    {
        /// <summary>
        /// 店铺财务记录
        /// </summary>
        [XmlElement("shop_financial_summary")]
        public ShopFinancialSummary ShopFinancialSummary { get; set; }
    }
}
