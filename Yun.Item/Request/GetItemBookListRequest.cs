using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Item.Response;

namespace Yun.Item.Request
{
    /// <summary>
    /// 获取预定列表
    /// chenggou.item.book.list.get
    /// </summary>
    public class GetItemBookListRequest : ITopRequest<GetItemBookListResponse>
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
        /// 用户昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 店铺ID 
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }


        /// <summary>
        /// 商品ID 
        /// </summary>
        public int ItemId { get; set; }


        /// <summary>
        /// 状态
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// 排序，支持iddesc,id,statusdesc,status
        /// </summary>
        public string Sort { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.book.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"nick", Nick},
                {"shopid", ShopId},
                {"companyid", CompanyId},
                {"itemid", ItemId},
                {"status", Status},
                {"sort", Sort}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
