using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取充值卡统计信息
    /// </summary>
    public class GetPrepaidTypeStatisticsRequest : ITopRequest<GetPrepaidTypeStatisticsResponse>
    {
        /// <summary>
        /// 绑定的店铺ID
        /// </summary>
        public int BindShopId { get; set; }

        /// <summary>
        /// 绑定的公司ID
        /// </summary>
        public int BindCompanyId { get; set; }


        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        public int PrepaidCardTypeId { get; set; }


        /// <summary>
        /// 用户昵称，需要对某用户进行统计
        /// </summary>
        public string UserNick { get; set; }



        public string GetApiName()
        {
            return "chenggou.prepaidcard.statistics.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"bindshopid", BindShopId},
                {"bindcompanyid", BindCompanyId},
                {"prepaidcardtypeid", PrepaidCardTypeId},
                {"usernick", UserNick}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
