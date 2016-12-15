using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Item.Response;

namespace Yun.Item.Request
{
    /// <summary>
    /// 获取用户商品收藏夹内的商品
    /// yun.item.favorites.get
    /// 不是必须授权，传入授权码后自动获取授权码关联的用户信息
    /// </summary>
    public class GetFavoritesItemRequest : ITopRequest<GetFavoritesItemResponse>
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
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 是否需要促销的信息
        /// </summary>
        public bool NeedPromotion { get; set; }

        /// <summary>
        /// 图像尺寸
        /// </summary>
        public int? ImageSize { get; set; }

        /// <summary>
        /// 商品字段
        /// </summary>
        public string Fields { get; set; }



        public string GetApiName()
        {
            return "yun.item.favorites.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"userid", UserId},
                {"needpromotion", NeedPromotion},
                {"imagesize", ImageSize},
                {"fields", Fields},
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
