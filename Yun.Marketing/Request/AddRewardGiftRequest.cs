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
    /// 新增满就送活动
    /// chenggou.promotionmisc.mjs.activity.add
    /// </summary>
    public class AddRewardGiftRequest : ITopRequest<IntResultResponse>
   {
       /// <summary>
       /// 活动名称
       /// </summary>
       public string Name { get; set; }

       /// <summary>
       /// 活动范围：0表示全部参与； 1表示部分商品；2表示按全局类目；3表示按照SPU筛选；4表示店铺内分类
       /// </summary>
       public string ParticipateRange { get; set; }

       /// <summary>
       /// 活动范围的ID,只有在活动范围生效时，该选项才会起作用
       /// </summary>
       public string ParticipateRangeId { get; set; }

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
       /// 活动内容
       /// </summary>
       public List<AddRewardGiftJson> ActivityContent { get; set; }

       /// <summary>
       /// 用户自定义的活动类型
       /// </summary>
       public string UserType { get; set; }

       public string GetApiName()
       {
           return "chenggou.promotionmisc.mjs.activity.add";
       }

       public IDictionary<string, string> GetParameters()
       {
           var parameters = new YunDictionary
            {
                {"name",Name},
                {"participaterange",ParticipateRange},
                {"participaterangeid",ParticipateRangeId},
                {"starttime",StartTime},
                {"endtime",EndTime},
                {"description",Description},
                {"activitycontent",ActivityContent},
                {"usertype",UserType}
            };
           return parameters;
       }

       public void Validate()
       {
           RequestValidator.ValidateRequired("name", Name);
           RequestValidator.ValidateRequired("participaterange", ParticipateRange);
           RequestValidator.ValidateRequired("starttime", StartTime);
           RequestValidator.ValidateRequired("endtime", EndTime);
       }
   }
}
