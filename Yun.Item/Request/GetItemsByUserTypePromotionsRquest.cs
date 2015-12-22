using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 根据用户的自定义促销标识获取商品信息
    /// chenggou.promotion.usertype.items.get
    /// </summary>
    public class GetItemsByUserTypePromotionsRquest : ITopRequest<GetItemsResponse>
    {
        /// <summary>
        /// 商品字段
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 图像尺寸
        /// </summary>
        public int? ImageSize { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum
        {
            get { return _pageNum; }
            set
            {
                _pageNum = value < 1 ? 1 : value;
            }
        }

        private int _pageNum = 1;



        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = value < 1 ? 1 : value;
            }
        }

        private int _pageSize = 1;


        /// <summary>
        /// 用户类型
        /// </summary>
        public string UserType { get; set; }


        /// <summary>
        /// 是否需要促销的信息
        /// </summary>
        public bool NeedPromotion { get; set; }



        /// <summary>
        /// 商品ID
        /// </summary>
        public string ItemIds { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        public string GetApiName()
        {
            return "chenggou.promotion.usertype.items.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"imagesize", ImageSize},
                {"fields", Fields},
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"shopid", ShopId},
                {"needpromotion", NeedPromotion},
                {"itemids", ItemIds},
                {"imagesize", ImageSize},
                {"companyid",CompanyId},
                {"usertype",UserType}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("usertype", UserType);
        }
    }
}
