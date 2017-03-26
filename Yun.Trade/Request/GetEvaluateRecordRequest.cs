using System.Collections.Generic;
using Yun.Interface;
using Yun.Trade.Response;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 获取评价
    ///yun.trade.evaluates.get
    /// </summary>
    public class GetEvaluateRecordRequest : ITopRequest<EvaluateRecordResponse>
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
        /// 商品ID
        /// </summary>
        public int? ItemId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// 星级，0，1，2，3，4，5
        /// </summary>
        public int? StarRating { get; set; }

        /// <summary>
        /// 是否有买家的评价内容
        /// </summary>
        public bool? HasBuyerContent { get; set; }

        /// <summary>
        /// 卖家是否评论
        /// </summary>
        public bool? SellerHasComment { get; set; }


        /// <summary>
        /// 是否有买家图片
        /// </summary>
        public bool? HasImages { get; set; }

        public string GetApiName()
        {
            return "yun.trade.evaluates.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"itemid", ItemId},
                {"shopid", ShopId},
                {"userid",UserId},
                {"starrating",StarRating},
                {"hasbuyercontent",HasBuyerContent},
                {"sellerhascomment",SellerHasComment},
                {"hasimages",HasImages }
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}