using System.Collections.Generic;
using System.Web;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class UpdateShopRequest : ITopRequest<BoolResultResponse>, IUploadInEditState
    {
        /// <summary>
        /// 店主密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 店铺ID值
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string Title { get; set; }

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
        /// 公告
        /// </summary>
        public string Bulletin { get; set; }

        /// <summary>
        /// 首页Url
        /// </summary>
        public string HomeUrl { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 地址附近描述
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// APP密匙
        /// </summary>
        public string AppSecret { get; set; }


        /// <summary>
        /// 城市ID
        /// </summary>
        public int? CityId { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        public int? AreaId { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        public int? CategoryId { get; set; }

        /// <summary>
        /// 配送时间
        /// </summary>
        public int? DeliveryTime { get; set; }


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
        public int? MainCategoryId { get; set; }


        /// <summary>
        /// 是否开放
        /// </summary>
        public bool? IsOpen { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// 是否显示在前台
        /// </summary>
        public bool? IsDisplay { get; set; }

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
        public int? ShopType { get; set; }

        /// <summary>
        /// 是否允许开票
        /// </summary>
        public int? AllowInvoice { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        public string SubTitle { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"phone",Phone},
                {"address",Address},
                {"hours",Hours},
                {"coordinate",Coordinate},
                {"summary",HttpUtility.HtmlEncode(Summary)},
                {"bulletin",HttpUtility.HtmlEncode(Bulletin)},
                {"homeurl",HomeUrl},
                {"imageurl",Image},
                {"description",HttpUtility.HtmlEncode(Description)},
                {"location",Location},
                {"title",Title},
                {"shopid", ShopId},
                {"password", string.IsNullOrEmpty(Password)?null: TopUtils.EncryptAes(Password, AppSecret)},
                {"cityid",CityId},
                {"areaid",AreaId},
                {"categoryid",CategoryId},
                {"deliverytime",DeliveryTime },
                {"isopen",IsOpen},
                {"isenabled",IsEnabled },
                {"isdisplay",IsDisplay },
                {"businesslicense",BusinessLicense},
                {"certifiedphotos",CertifiedPhotos },
                {"maincategoryid",MainCategoryId },
                {"banner",Banner },
                {"contacts",Contacts },
                {"shoptype",ShopType },
                { "allowinvoice",AllowInvoice},
                {"subtitle",SubTitle }
            };
            return parameters;
        }

        public void Validate()
        {
             
            RequestValidator.ValidateMaxLength("phone", this.Phone, 50);
            RequestValidator.ValidateMaxLength("address", this.Address, 100);
            RequestValidator.ValidateMaxLength("hours", this.Hours, 200);
            RequestValidator.ValidateMaxLength("coordinate", this.Coordinate, 200);
            RequestValidator.ValidateMaxLength("summary", this.Summary, 1000);
            RequestValidator.ValidateMaxLength("bulletin", this.Bulletin, 1000);
            RequestValidator.ValidateMaxLength("homeurl", this.HomeUrl, 200);
            RequestValidator.ValidateMaxLength("imageurl", this.Image, 200);
            RequestValidator.ValidateMaxLength("description", this.Description, 2000);
            RequestValidator.ValidateMaxLength("location", this.Location, 200);
        }

        public string Image { get; set; }
        public FileItem NewImage { get; set; }
    }
}
