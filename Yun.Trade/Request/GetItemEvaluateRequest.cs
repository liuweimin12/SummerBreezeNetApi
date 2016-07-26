using System.Collections.Generic;
using Yun.Interface;
using Yun.Trade.Response;
using Yun.Util;

namespace Yun.Trade.Request
{
    /// <summary>
    /// 获取商品的评价信息
    /// yun.item.evaluates.get
    /// </summary>
    public class GetItemEvaluateRequest : ITopRequest<GetItemEvaluateResponse>
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
        /// 商品id
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// 是否过滤空评论
        /// </summary>
        public bool FilterEmptyComment { get; set; }


        public string GetApiName()
        {
            return "yun.item.evaluates.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"itemid",ItemId},
                {"filteremptycomment",FilterEmptyComment}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("itemid", ItemId);
        }
    }
}
