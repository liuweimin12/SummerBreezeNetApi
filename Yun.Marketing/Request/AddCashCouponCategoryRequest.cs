﻿using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    /// <summary>
    /// 新增代金券类别
    /// chenggou.cashcoupon.category.add
    /// </summary>
    public class AddCashCouponCategoryRequest:ITopRequest<IntResultResponse>
    {

        /// <summary>
        /// 面值
        /// </summary>
        public double Credit { get; set; }


        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? BeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }


        /// <summary>
        /// 范围，0：无限制，1：商品
        /// </summary>
        public int Range { get; set; }


        /// <summary>
        /// 可使用的商品ID
        /// </summary>
        public string ItemsId { get; set; }


        /// <summary>
        /// 代金券适用范围，最低价格要求
        /// </summary>
        public double MinPrice { get; set; }

        /// <summary>
        /// 代金券名字
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 代金券类型
        /// </summary>
        public string CouponType { get; set; }


        /// <summary>
        /// 是否强制使用自定义代金券
        /// </summary>
        public bool UseCustom { get; set; }


        /// <summary>
        /// 每用户最多领取数量
        /// </summary>
        public int PerUserMaxQuantity { get; set; }


        /// <summary>
        /// 发放数量
        /// </summary>
        public int Num { get; set; }


        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 显示位置
        /// </summary>
        public int DisplayPosition { get; set; }

        public string GetApiName()
        {
            return "chenggou.cashcoupon.category.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name",Name},
                {"credit",Credit},
                {"begintime",BeginTime},
                {"endtime",EndTime},
                {"range",Range},
                {"itemsid",ItemsId},
                {"minprice",MinPrice},
                {"coupontype",CouponType},
                {"usecustom",UseCustom},
                {"perusermaxquantity",PerUserMaxQuantity},
                {"num",Num},
                {"status",Status},
                {"description",Description},
                {"displayposition",DisplayPosition }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
            RequestValidator.ValidateRequired("credit", Credit);
            RequestValidator.ValidateMinValue("credit", Credit, 0.01);
        }
    }
}
