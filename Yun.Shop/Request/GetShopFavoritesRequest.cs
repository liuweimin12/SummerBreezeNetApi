using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Shop.Response;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 获取用户店铺收藏列表
    /// yun.shop.favorite.list.get
    /// 如果用户在登录情况下，获取登录人的店铺收藏列表
    /// </summary>
    public class GetShopFavoritesRequest:ITopRequest<GetShopFavoritesResponse>
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

        public string GetApiName()
        {
            return "yun.shop.favorite.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"userid", UserId}
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
