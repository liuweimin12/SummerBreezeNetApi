using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 新增团购活动
    /// chenggou.promotionmisc.groupbuy.activity.add
    /// </summary>
    public class AddGroupBuyRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 活动名称
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }


        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// 用户自定义的活动类型
        /// </summary>
        public string UserType { get; set; }


        public string GetApiName()
        {
            return "chenggou.promotionmisc.groupbuy.activity.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name",Name},
                {"starttime",StartTime},
                {"endtime",EndTime},
                {"description",Description},
                {"usertype",UserType}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateRequired("starttime", StartTime);
            RequestValidator.ValidateRequired("endtime", EndTime);
        }
    }
}
