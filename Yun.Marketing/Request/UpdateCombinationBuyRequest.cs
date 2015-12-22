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
    /// 更新组合促销活动
    /// chenggou.promotionmisc.combinationbuy.activity.update
    /// </summary>
    public class UpdateCombinationBuyRequest:ITopRequest<IntResultResponse>
    {

        /// <summary>
        /// 活动ID
        /// </summary>
        public int ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }



        /// <summary>
        /// 需要添加的商品信息，Json字符串
        /// </summary>
        public string Items { get; set; }


        /// <summary>
        /// 出售价格
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string Images { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        public string MarketPrice { get; set; }

        /// <summary>
        /// 物流模板ID
        /// </summary>
        public int FareTemplateId { get; set; }

        /// <summary>
        /// 电子券模板
        /// </summary>
        public int CouponTemplateId { get; set; }

        public string GetApiName()
        {
            return "chenggou.promotionmisc.combinationbuy.activity.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"activityid",ActivityId},
                {"name",Name},
                {"starttime",StartTime},
                {"endtime",EndTime},
                {"description",Description},
                {"items",Items},
                {"price",Price},
                {"images",Images},
                {"marketprice",MarketPrice},
                {"faretemplateid",FareTemplateId},
                {"coupontemplateid",CouponTemplateId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("activityid", ActivityId);
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateRequired("starttime", StartTime);
            RequestValidator.ValidateRequired("endtime", EndTime);
        }
    }
}
