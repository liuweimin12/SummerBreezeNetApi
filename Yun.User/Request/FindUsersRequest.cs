using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.User.Response;
using Yun.Util;

namespace Yun.User.Request
{
    /// <summary>
    /// 搜索网站下用户数据，需要授权
    /// </summary>
    public class FindUsersRequest : ITopRequest<GetUsersResponse>
    {

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int ShopId { get; set; }


        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

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
        /// 用户名，支持迷糊查询
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 邮箱，支持模糊查询
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 手机号，支持模糊查询
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 待查询的最小金钱数量
        /// </summary>
        public double? MinMoney { get; set; }

        /// <summary>
        /// 待查询的最大金钱数量
        /// </summary>
        public double? MaxMoney { get; set; }

        /// <summary>
        /// 待查询的最小积分数量
        /// </summary>
        public long? MinScore { get; set; }


        /// <summary>
        /// 待查询的最大积分数量
        /// </summary>
        public long? MaxScore { get; set; }

        /// <summary>
        /// 待查询的最小注册时间
        /// </summary>
        public DateTime? MinRegTime { get; set; }

        /// <summary>
        /// 待查询的最大注册时间
        /// </summary>
        public DateTime? MaxRegTime { get; set; }

        /// <summary>
        /// 注册方法
        /// </summary>
        public string RegType { get; set; }

        /// <summary>
        /// 用户ID，多个用户ID用英文逗号分隔
        /// </summary>
        public string UserIds { get; set; }

        /// <summary>
        /// 用户的真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 需要排除的用户名,多个用英文逗号分隔
        /// </summary>
        public string ExcludeUsers { get; set; }


        /// <summary>
        /// 最小充值卡余额
        /// </summary>
        public double MinPrepaidCard { get; set; }

        /// <summary>
        /// 最大充值余额
        /// </summary>
        public double MaxPrepaidCard { get; set; }


        /// <summary>
        /// 身份证
        /// </summary>
        public string IdCard { get; set; }


        public string GetApiName()
        {
            return "chenggou.users.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"nick", Nick},
                {"email", Email},
                {"mobile", Mobile},
                {"minmoney", MinMoney},
                {"maxmoney", MaxMoney},
                {"minscore", MinScore},
                {"maxscore", MaxScore},
                {"minregtime", MinRegTime},
                {"maxregtime", MaxRegTime},
                {"regtype", RegType},
                {"shopid", ShopId},
                {"companyid", CompanyId},
                {"userids", UserIds},
                {"realname", RealName},
                {"excludeusers", ExcludeUsers},
                {"minprepaidcard", MinPrepaidCard},
                {"maxprepaidcard", MaxPrepaidCard},
                {"idcard", IdCard}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("pagesize", PageSize, 100);
        }
    }
}