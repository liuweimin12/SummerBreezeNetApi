﻿using System.Collections.Generic;
using System.Web;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class AddShopRequest : ITopUploadRequest<IntResultResponse>
    {
        /// <summary>
        /// 店主用户名，如果为空，则自动创建用户
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 店主电子邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 店主手机号
        /// </summary>
        public string ShopkeeperPhone { get; set; }


        /// <summary>
        /// 店主类别/层级
        /// 该层级和权限的类型相关联
        /// </summary>
        public int SystemLevel { get; set; }

        /// <summary>
        /// 操作者的IP地址
        /// </summary>
        public string Ip { get; set; }

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
        /// 地址附近描述
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 城市ID
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        public int AreaId { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        public int CategoryId { get; set; }


        public string Description { get; set; }

        /// <summary>
        /// 首页
        /// </summary>
        public string HomeUrl { get; set; }

        /// <summary>
        /// 是否开放
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 是否显示在前台
        /// </summary>
        public bool IsDisplay { get; set; }

        public string GetApiName()
        {
            return "chenggou.shop.add";
        }

        public string Bulletin { get; set; }

        /// <summary>
        /// APP密匙
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// 配送时间
        /// </summary>
        public int DeliveryTime { get; set; }
        

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
        /// 父ID
        /// </summary>
        public int ParentId { get; set; }



        /// <summary>
        /// 店铺类型
        /// </summary>
        public int ShopType { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"name", Name},
                {"phone",Phone},
                {"address",Address},
                {"hours",Hours},
                {"coordinate",Coordinate},
                {"summary",HttpUtility.HtmlEncode(Summary)},
                {"bulletin",HttpUtility.HtmlEncode(Bulletin)},
                {"location",Location},
                {"cityid",CityId},
                {"areaid",AreaId},
                {"categoryid",CategoryId},
                {"description",HttpUtility.HtmlEncode(Description)},
                {"username",UserName},
                {"password", string.IsNullOrEmpty(Password)?null: TopUtils.EncryptAes(Password, AppSecret)},
                {"email",Email},
                {"shopkeeperphone",ShopkeeperPhone},
                {"systemlevel",SystemLevel},
                {"ip",Ip},
                {"companyid",CompanyId},
                {"deliverytime",DeliveryTime },
                {"homeurl",HomeUrl },
                {"isopen",IsOpen},
                {"isenabled",IsEnabled },
                {"isdisplay",IsDisplay },
                {"businesslicense",BusinessLicense},
                {"certifiedphotos",CertifiedPhotos },
                {"maincategoryid",MainCategoryId },
                {"banner",Banner },
                {"contacts",Contacts },
                {"shoptype",ShopType },
                {"parentid",ParentId }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("name", Name);

        }

        /// <summary>
        /// 缩略图
        /// </summary>
        public FileItem Image { get; set; }

        public IDictionary<string, FileItem> GetFileParameters()
        {
            return new Dictionary<string, FileItem> { { "Image", Image } };
        }
    }
}
