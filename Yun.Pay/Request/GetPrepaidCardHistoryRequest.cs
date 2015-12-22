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
    public class GetPrepaidCardHistoryRequest : ITopRequest<GetPrepaidCardHistoryResponse>
    {

        /// <summary>
        /// 充值卡类型ID
        /// </summary>
        public int PrepaidCardTypeId { get; set; }

        /// <summary>
        /// 充值卡卡号
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
        /// 操作人的用户昵称
        /// </summary>
        public string OperatorNick { get; set; }


        /// <summary>
        /// 需要查询某店铺下的所有充值卡
        /// </summary>
        public int ShopId { get; set; }


        /// <summary>
        /// 需要查询某公司下的所有充值卡
        /// </summary>
        public int CompanyId { get; set; }


        /// <summary>
        /// 历史记录时间-开始
        /// </summary>
        public DateTime? MinCreateTime { get; set; }


        /// <summary>
        /// 历史记录时间-结束
        /// </summary>
        public DateTime? MaxCreateTime { get; set; }

        /// <summary>
        /// 操作类型,支持Create，Bind，Used，UnBind
        /// </summary>
        public string OperateType { get; set; }

        /// <summary>
        /// 最小金额
        /// </summary>
        public double MinMoney { get; set; }


        /// <summary>
        /// 最大金额
        /// </summary>
        public double MaxMoney { get; set; }

        /// <summary>
        /// 需要返回总金额
        /// </summary>
        public bool NeedReturnTotalMoney { get; set; }


        public string GetApiName()
        {
            return "chenggou.prepaidcard.history.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum",PageNum},
                {"pagesize",PageSize},
                {"shopid",ShopId},
                {"companyid",CompanyId},
                {"prepaidcardtypeid",PrepaidCardTypeId},
                {"mincreatetime",MinCreateTime},
                {"maxcreatetime",MaxCreateTime},
                {"operatornick",OperatorNick},
                {"operatetype",OperateType},
                {"cardnumber",CardNumber},
                {"minmoney",MinMoney},
                {"maxmoney",MaxMoney},
                {"needreturntotalmoney",NeedReturnTotalMoney }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("pagesize", PageSize, 1000);
        }
    }
}
