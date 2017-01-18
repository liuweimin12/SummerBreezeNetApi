using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 修改用户积分
    /// 不需要授权
    /// </summary>
    public class ModifyUserCreditRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string UserNick { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int TargetUserId { get; set; }

        /// <summary>
        /// 变化的积分量，大于0增加，小于0减少
        /// </summary>
        public int Credit { get; set; }


        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 过期天数
        /// </summary>
        public int ExpiredDay { get; set; }

        /// <summary>
        /// 变更详情，最长限制50个中文，100个英文
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 对应的关系ID
        /// </summary>
        public string DetailId { get; set; }


        /// <summary>
        /// 积分类型，自定义
        /// </summary>
        public string IntegralType { get; set; }

        /// <summary>
        /// 流水号,保证全局唯一
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }


        public string GetApiName()
        {
            return "chenggou.user.score.modify";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"usernick", UserNick},
                {"credit", Credit},
                {"expiredday", ExpiredDay},
                {"remark", Remark},
                {"detail", Detail},
                {"detailid", DetailId},
                {"integraltype",IntegralType },
                {"serialnumber",SerialNumber },
                {"targetuserid",TargetUserId },
                {"createtime",CreateTime }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("integraltype", IntegralType);
            RequestValidator.ValidateRequired("detail", Detail);
            RequestValidator.ValidateMaxLength("detail", Detail, 100);
            RequestValidator.ValidateRequired("credit", Credit);
            RequestValidator.ValidateRequired("serialnumber", SerialNumber);
        }
    }
}
