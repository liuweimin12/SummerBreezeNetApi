using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Shop
{
    public class ShopDetail
    {
        /// <summary>
        /// 副标题名字
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 是否允许开票，0是不允许
        /// </summary>
        [XmlElement("allow_invoice")]
        public int AllowInvoice { get; set; }

        /// <summary>
        /// 主营类目链表
        /// </summary>
        [XmlArray("main_item_cats")]
        [XmlArrayItem("main_item_cat")]
        public List<ItemCat> MainItemCats { get; set; }

        /// <summary>
        /// 子店铺
        /// </summary>
        [XmlArray("child_shops")]
        [XmlArrayItem("child_shop")]
        public List<ChildShop> ChildShops { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        [XmlElement("is_display")]
        public bool IsDisplay { get; set; }


        /// <summary>
        /// 是否启用
        /// </summary>
        [XmlElement("is_enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 店主信息
        /// </summary>
        [XmlElement("shopkeeper_detail")]
        public UserDetail ShopkeeperDetail { get; set; }

        /// <summary>
        /// 横幅，多个图片用英文逗号分隔
        /// </summary>
        [XmlElement("banner")]
        public string Banner { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contacts")]
        public string Contacts { get; set; }

        /// <summary>
        /// 实体店店铺认证状态
        /// </summary>
        [XmlElement("certification_status")]
        public int CertificationStatus { get; set; }

        /// <summary>
        /// 营业执照号码
        /// </summary>
        [XmlElement("business_license")]
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 认证操作的最后时间
        /// </summary>
        [XmlElement("certified_time")]
        public string CertifiedTime { get; set; }

        /// <summary>
        /// 店铺主营类目
        /// </summary>
        [XmlElement("cat_id")]
        public int CatId { get; set; }

        /// <summary>
        /// 认证的相关照片，一般包括门店照片，店内照片，店内悬挂营业执照照片 
        /// </summary>
        [XmlElement("certified_photos")]
        public string CertifiedPhotos { get; set; }

        /// <summary>
        /// 配送时间，按秒计算
        /// </summary>
        [XmlElement("delivery_time")]
        public int DeliveryTime { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        [XmlElement("company_id")]
        public long CompanyId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 店铺所属全局类目
        /// </summary>
        [XmlArray("shop_categories")]
        [XmlArrayItem("shop_category")]
        public List<YunKeyValuePair<int, string>> CategoryId { get; set; }

        /// <summary>
        /// 店名
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 店铺描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 店铺公告
        /// </summary>
        [XmlElement("bulletin")]
        public string Bulletin { get; set; }

        /// <summary>
        /// 店铺简介
        /// </summary>
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        ///店铺图标，LOGO
        /// </summary>
        [XmlElement("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 营业时间
        /// </summary>
        [XmlElement("hours")]
        public string Hours { get; set; }

        /// <summary>
        /// 开店时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }


        /// <summary>
        /// 最后修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }


        /// <summary>
        /// 店铺动态评分
        /// </summary>
        [XmlElement("score")]
        public DynamicRatings Score { get; set; }

        /// <summary>
        /// 首页地址
        /// </summary>
        [XmlElement("home_url")]
        public string HomePage { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 店铺坐标
        /// </summary>
        [XmlElement("coordinate")]
        public string Longlat { get; set; }

        /// <summary>
        /// 好评率
        /// </summary>
        [XmlElement("feed_back")]
        public UserCredit Feedback { get; set; }

        /// <summary>
        /// 是否开启
        /// </summary>
        [XmlElement("is_open")]
        public bool IsOpen { get; set; }

        /// <summary>
        /// 二级域名
        /// </summary>
        [XmlElement("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 店主ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 客服
        /// </summary>
        [XmlArray("customer_services")]
        [XmlArrayItem("customer_service")]
        public List<CustomerService> CustomerServices { get; set; }


        /// <summary>
        /// 靠近
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 店铺所在区域
        /// </summary>
        [XmlArray("areas")]
        [XmlArrayItem("area")]
        public List<YunKeyValuePair<int, string>> Areas { get; set; }


        /// <summary>
        /// 店主ID
        /// </summary>
        [XmlElement("shopkeeper_id")]
        public int ShopKeeperId { get; set; }


        /// <summary>
        /// 店主用户名
        /// </summary>
        [XmlElement("shopkeeper")]
        public string ShopKeeper { get; set; }


        /// <summary>
        /// 好评数量
        /// </summary>
        [XmlElement("praise_quantity")]
        public int PraiseQuantity { get; set; }

        /// <summary>
        /// 中评数量
        /// </summary>
        [XmlElement("medium_quantity")]
        public int MediumQuantity { get; set; }

        /// <summary>
        /// 差评数量
        /// </summary>
        [XmlElement("bad_quantity")]
        public int BadQuantity { get; set; }


        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("goods_count")]
        public int GoodsCount { get; set; }

        /// <summary>
        /// 动态文章数量
        /// </summary>
        [XmlElement("article_count")]
        public int ArticleCount { get; set; }

        /// <summary>
        /// 店铺类型  0 虚拟 1 实体
        /// </summary>
        [XmlElement("shop_type")]
        public int ShopType { get; set; }
    }
}
