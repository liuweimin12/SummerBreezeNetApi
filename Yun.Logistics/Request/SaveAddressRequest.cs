using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 保存用户的收货地址
    /// 需要授权
    /// 新增/更改用户的收货地址
    /// </summary>
    public class SaveAddressRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        ///用户ID
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// 市
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 区
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// 街道
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string Zipcode { get; set; }
        /// <summary>
        /// 收件人姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 是否默认地址，1或者0
        /// </summary>
        public int IsDefault { get; set; }

        /// <summary>
        /// 地址类型，默认为0
        /// </summary>
        public int AddressType { get; set; }


        /// <summary>
        /// 地址详情
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 镇
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// 省ID
        /// </summary>
        public int? ProvinceId { get; set; }

        /// <summary>
        /// 区ID
        /// </summary>
        public int? AreaId { get; set; }

        /// <summary>
        /// 城市ID
        /// </summary>
        public int? CityId { get; set; }

        /// <summary>
        /// 城镇ID
        /// </summary>
        public int? TownId { get; set; }

        public string GetApiName()
        {
            return "chenggou.user.address.save";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id},
                {"province", Province},
                {"area", Area},
                {"city", City},
                {"street", Street},
                {"zipcode", Zipcode},
                {"name", Name},
                {"mobile", Mobile},
                {"isdefault", IsDefault},
                {"addresstype", AddressType},
                {"detail", Detail},
                {"town",Town },
                {"provinceid", ProvinceId},
                {"areaid", AreaId},
                {"cityid", CityId},
                {"townid", TownId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("mame", Name);
            RequestValidator.ValidateRequired("mobile", Mobile);
            RequestValidator.ValidateRequired("street", Street);
        }
    }
}
