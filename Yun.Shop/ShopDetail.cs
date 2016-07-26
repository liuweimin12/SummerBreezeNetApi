using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Shop
{
    public class ShopDetail
    {
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
        /// 文章ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 店铺所属类目
        /// </summary>
        [XmlArray("shop_categories")]
        [XmlArrayItem("shop_category")]
        public List<LongKeyValuePair> CategoryId { get; set; }

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
        /// 店铺照片
        /// </summary>
        [XmlElement("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 营业时间
        /// </summary>
        [XmlElement("hours")]
        public string Hours { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 动态评分
        /// </summary>
        [XmlElement("score")]
        public DynamicRatings Score { get; set; }

        /// <summary>
        /// 首页Url
        /// </summary>
        [XmlElement("home_url")]
        public string HomePage { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 坐标（谷歌）
        /// </summary>
        [XmlElement("coordinate")]
        public string Coordinate { get; set; }

        /// <summary>
        /// 好评率
        /// </summary>
        [XmlElement("feedback")]
        public UserCredit Feedback { get; set; }

        /// <summary>
        /// 是否开启
        /// </summary>
        [XmlElement("is_open")]
        public bool IsOpen { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [XmlElement("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 用户I
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

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
        public List<LongKeyValuePair> Areas { get; set; }


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
    }
}
