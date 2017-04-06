using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 查找商品类目
    /// yun.item.cat.find
    /// </summary>
    public class FindItemCatsRequest : ITopRequest<FindItemCatsResponse>
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum
        {
            get { return _pageNum; }
            set { _pageNum = value < 1 ? 1 : value; }
        }

        private int _pageNum = 1;



        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value < 1 ? 1 : value; }
        }

        private int _pageSize = 1;

        /// <summary>
        /// 分类名字
        /// </summary>
        public string Name { get; set; }

        public string GetApiName()
        {
            return "yun.item.cat.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
        }
    }
}
