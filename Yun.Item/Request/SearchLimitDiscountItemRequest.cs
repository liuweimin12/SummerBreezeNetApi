using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 搜索限时折扣商品
    /// chenggou.limitdiscount.items.search
    /// </summary>
    public class SearchLimitDiscountItemRequest : ITopRequest<GetItemsResponse>
    {
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
        /// 图像尺寸
        /// </summary>
        public int? ImageSize { get; set; }


        /// <summary>
        /// 用户自定义类型
        /// </summary>
        public string UserType { get; set; }


        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }


        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// 商品字段
        /// </summary>
        public string Fields { get; set; }

        public string GetApiName()
        {
            return "chenggou.limitdiscount.items.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"imagesize",ImageSize},
                {"usertype",UserType},
                {"shopid",ShopId},
                {"companyid",CompanyId},
                {"fields",Fields}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("pagesize", PageSize, 100);
            RequestValidator.ValidateRequired("pagenum", PageNum);
         
        }
    }
}
