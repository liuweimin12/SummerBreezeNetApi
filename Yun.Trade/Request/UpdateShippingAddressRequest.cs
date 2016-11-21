using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 更新收货人信息
    /// chenggou.trade.shippingaddress.update
    /// 卖家专用
    /// </summary>
    public class UpdateShippingAddressRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        public string Zipcode { get; set; }

        /// <summary>
        /// 递送方式的备注，一般用于系统内在递送时候的补充备注
        /// </summary>
        public string DeliveryNote { get; set; }

        /// <summary>
        /// 省ID
        /// </summary>
        public int ProvinceId { get; set; }

        /// <summary>
        /// 市ID
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// 区ID
        /// </summary>
        public int AreaId { get; set; }

        /// <summary>
        /// 镇ID
        /// </summary>
        public int TownId { get; set; }


        public string GetApiName()
        {
            return "chenggou.trade.shippingaddress.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"orderid", OrderId},
                {"realname", RealName},
                {"mobile", Mobile},
                {"address", Address},
                {"zipcode", Zipcode},
                {"deliverynote",DeliveryNote },
                {"provinceid",ProvinceId},
                {"cityid", CityId},
                {"areaid", AreaId},
                {"townid", TownId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("orderid", OrderId);
            RequestValidator.ValidateRequired("realName", RealName);
            RequestValidator.ValidateRequired("mobile", Mobile);
        }
    }
}
