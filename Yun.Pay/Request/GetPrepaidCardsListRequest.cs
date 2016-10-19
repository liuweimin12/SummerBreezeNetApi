using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Pay.Response;
using Yun.Util;

namespace Yun.Pay.Request
{
    /// <summary>
    /// 获取充值卡列表数据
    /// chenggou.prepaidcard.list.get
    /// </summary>
    public class GetPrepaidCardsListRequest : ITopRequest<GetPrepaidCardsListResponse>
    {
        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        public int? PrepaidCardTypeId { get; set; }


        /// <summary>
        /// 充值卡号码
        /// </summary>
        public string CardNumber { get; set; }

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
        /// 已绑定的用户昵称
        /// </summary>
        public string BoundNick { get; set; }


        /// <summary>
        /// 需要查询某店铺下的所有充值卡
        /// </summary>
        public int? ShopId { get; set; }


        /// <summary>
        /// 需要查询某公司下的所有充值卡
        /// </summary>
        public int? CompanyId { get; set; }


        /// <summary>
        /// 开始绑定事件
        /// </summary>
        public DateTime? StartBindTime { get; set; }


        /// <summary>
        /// 范围搜索，结束时间，绑定时间
        /// </summary>
        public DateTime? EndBindTime { get; set; }


        /// <summary>
        /// 充值卡最小创建时间
        /// </summary>
        public DateTime? MinCreateTime { get; set; }


        /// <summary>
        /// 充值卡最大创建时间
        /// </summary>
        public DateTime? MaxCreateTime { get; set; }

        /// <summary>
        /// 是否已经和用户绑定
        /// </summary>
        public bool? IsBinded { get; set; }

        /// <summary>
        /// 充值卡ID
        /// </summary>
        public string PrepaidCardsId { get; set; }


        public string GetApiName()
        {
            return "chenggou.prepaidcard.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"prepaidcardtypeid",PrepaidCardTypeId},
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"boundnick",BoundNick},
                {"shopid",ShopId},
                {"companyid",CompanyId},
                {"startbindtime",StartBindTime},
                {"endbindtime",EndBindTime},
                {"isbinded",IsBinded},
                {"cardnumber",CardNumber},
                {"prepaidcardsid",PrepaidCardsId},
                {"mincreatetime",MinCreateTime},
                {"maxcreatetime",MaxCreateTime},
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
