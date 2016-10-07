using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Site.Request
{
    /// <summary>
    /// 添加城市
    /// chenggou.city.add
    /// </summary>
    public class AddCityRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }


        /// <summary>
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }


        /// <summary>
        /// 状态码
        /// </summary>
        public int State { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        public string Ext { get; set; }

        /// <summary>
        /// 外部ID
        /// </summary>
        public int OuterId { get; set; }

        public string GetApiName()
        {
            return "chenggou.city.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name",Name},
                {"sort",Sort},
                {"parentid",ParentId},
                {"state",State},
                {"ext",Ext},
                {"outerid",OuterId }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
        }
    }
}
