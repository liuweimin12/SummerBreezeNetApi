using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class GetItemPropValuesRequest : ITopRequest<PropValuesResponse>
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
        /// 商品属性名称ID
        /// </summary>
        public int PropNameId { get; set; }

        public int ParentId { get; set; }

        /// <summary>
        /// 特殊标记类型，可自定义，方便以后索搜用，不能超过255，最小为0
        /// </summary>
        public int? SpecialType { get; set; }

        /// <summary>
        /// 是否隐藏
        /// </summary>
        public bool? IsHide { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.propvalues.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"propnameid", PropNameId},
                {"parentid", ParentId},
                {"specialtype",SpecialType },
                {"ishide", IsHide}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("propnameid", PropNameId);
        }
    }
}
