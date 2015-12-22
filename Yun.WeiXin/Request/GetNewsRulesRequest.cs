using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.WeiXin.Response;

namespace Yun.WeiXin.Request
{
    /// <summary>
    /// 获取图文回复的规则
    /// </summary>
    public class GetNewsRulesRequest:ITopRequest<GetNewsRulesResponse>
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
        /// 微信账号ID 
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// 规则名字,支持模糊搜索
        /// </summary>
        public string Title { set; get; }
        public string GetApiName()
        {
            return "chenggou.weixin.newsrules.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"accountid",AccountId},
                {"status",Status},
                {"title",Title}
            };
            return parameters;
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
