using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 新增待认领店铺
    /// yun.shop.unclaimed.add
    /// </summary>
    public class AddUnclaimedShopRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// LOGO
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 营业时间
        /// </summary>
        public string Hours { get; set; }

        /// <summary>
        /// 坐标
        /// </summary>
        public string Coordinate { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 区域介绍
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        public string City { get; set; }


        /// <summary>
        /// 区
        /// </summary>
        public string Area { get; set; }


        /// <summary>
        /// 县
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        public int AreaId { get; set; }

        /// <summary>
        /// 店铺分类ID
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// 公告
        /// </summary>
        public string Bulletin { get; set; }

        /// <summary>
        /// 首页
        /// </summary>
        public string HomeUrl { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 操作者的IP地址
        /// </summary>
        public string Ip { get; set; }


        /// <summary>
        /// 营业执照号码
        /// </summary>
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 营业执照号码
        /// </summary>
        public string CertifiedPhotos { get; set; }

        /// <summary>
        /// 主营类目
        /// </summary>
        public int MainCategoryId { get; set; }

        /// <summary>
        /// 广告横幅
        /// </summary>
        public string Banner { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contacts { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        public int ShopType { get; set; }


        /// <summary>
        /// 是否允许开票
        /// </summary>
        public int AllowInvoice { get; set; }

        /// <summary>
        /// 实体店名字
        /// </summary>
        public string SubTitle { get; set; }

        public string GetApiName()
        {
            return "yun.shop.unclaimed.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"phone", Phone},
                {"address", Address},
                {"hours", Hours},
                {"coordinate", Coordinate},
                {"summary", HttpUtility.HtmlEncode(Summary)},
                {"bulletin", HttpUtility.HtmlEncode(Bulletin)},
                {"location", Location},
                {"areaid", AreaId},
                {"categoryid", CategoryId},
                {"description", HttpUtility.HtmlEncode(Description)},
                {"ip", Ip},
                {"homeurl", HomeUrl},
                {"businesslicense", BusinessLicense},
                {"certifiedphotos", CertifiedPhotos},
                {"maincategoryid", MainCategoryId},
                {"banner", Banner},
                {"contacts", Contacts},
                {"shoptype", ShopType},
                {"allowinvoice", AllowInvoice},
                {"subtitle", SubTitle},
                {"picture", Picture},
                {"province", Province},
                {"city", City},
                {"area", Area},
                {"town", Town}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);
        }
    }
}
