using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Domain;

namespace Yun.Item
{
    public class GoodsDetail
    {
        /// <summary>
        /// 价格区间
        /// </summary>
        [XmlElement("price_range")]
        public string PriceRange { get; set; }

        /// <summary>
        /// 商品动态评分
        /// </summary>
        [XmlElement("item_score")]
        public DynamicRatings ItemScore { get; set; }

        /// <summary>
        /// 是否分销
        /// </summary>
        [XmlElement("is_distribution")]
        public bool IsDistribution { get; set; }


        /// <summary>
        /// 积分数量
        /// </summary>
        [XmlElement("integral_quantity")]
        public int IntegralQuantity { get; set; }

        /// <summary>
        /// 移动端的商品详情
        /// </summary>
        [XmlElement("mobile_detail")]
        public string MobileDetail { get; set; }

        /// <summary>
        /// 每账号限购，控制时间间隔
        /// </summary>
        [XmlElement("per_limit_buy_hour")]
        public int PerLimitBuyHour { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 分销模板ID
        /// </summary>
        [XmlElement("distribution_template_id")]
        public int DistributionTemplateId { get; set; }

        /// <summary>
        /// 库存计数方式，0：付款减库存，1：拍下减库存
        /// </summary>
        [XmlElement("inventory_count")]
        public int InventoryCount { get; set; }

        /// <summary>
        /// 该商品所属公司
        /// </summary>
        [XmlElement("company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// 商品是否已删除
        /// </summary>
        [XmlElement("is_delete")]
        public bool IsDelete { get; set; }


        /// <summary>
        /// 原始商品扩展分类ID字符串
        /// </summary>
        [XmlElement("original_item_ext_cats")]
        public string OriginalItemExtCats { get; set; }


        /// <summary>
        /// 是否限制该账号只允许购买商品一次
        /// </summary>
        [XmlElement("buy_once")]
        public bool BuyOnce { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        [XmlElement("on_shelf_time")]
        public string  OnShelfTime { get; set; }

        /// <summary>
        /// 下架时间
        /// </summary>
        [XmlElement("off_shelf_time")]
        public string  OffShelfTime { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 1：几号到几号
        ///0：购买成功日至几号
        ///2：购买成功几天内有效
        /// </summary>
        [XmlElement("expire_rule")]
        public long  ExpireRule { get; set; }

        /// <summary>
        /// 电子券几天过期
        /// </summary>
        [XmlElement("expire_days")]
        public long ExpireDays { get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [XmlElement("expire_start")]
        public string  ExpireStart { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }
        /// <summary>
        /// 商品库存
        /// </summary>
        [XmlElement("stock")]
        public long Stock { get; set; }

        /// <summary>
        /// 购买上限
        /// </summary>
        [XmlElement("buy_limit")]
        public long BuyLimit { get; set; }


        /// <summary>
        /// 商品排序
        /// </summary>
        [XmlElement("sort_order")]
        public int SortOrder { get; set; }


        /// <summary>
        /// 单图
        /// </summary>
        [XmlElement("picture")]
        public string Picture { get; set; }


        /// <summary>
        /// 商品图片集
        /// </summary>
        [XmlElement("pictures")]
        public string Pictures { get; set; }

        /// <summary>
        /// 团购标题
        /// </summary>
        [XmlElement("tuan_title")]
        public string TuanTitle { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 消息标题(电子券发券标题)
        /// </summary>
        [XmlElement("msg_title")]
        public string MsgTitle { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("price")]
        public double Price { get; set; }

        /// <summary>
        /// /市场价格
        /// </summary>
        [XmlElement("market_price")]
        public double MarketPrice { get; set; }

        /// <summary>
        /// 商品适用商户
        /// </summary>
        [XmlArray("partners")]
        [XmlArrayItem("partner")]
        public List<int> Partners { get; set; }

        /// <summary>
        /// 是否推荐
        /// </summary>
        [XmlElement("is_recommend")]
        public int IsRecommend { get; set; }

        /// <summary>
        /// 商品修改时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 商品状态（1出售中，2库中)
        /// </summary>
        [XmlElement("item_state")]
        public long  ItemState { get; set; }

        /// <summary>
        /// 是否定时上架
        /// </summary>
        [XmlElement("is_timed")]
        public bool IsTimed { get; set; }

        /// <summary>
        /// 商品所属店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        [XmlElement("item_detail")]
        public string ItemDetail { get; set; }

        /// <summary>
        /// 运费模板ID
        /// </summary>
        [XmlElement("freight_template_id")]
        public long FreightTemplateId { get; set; }

        /// <summary>
        /// 电子券模板ID
        /// </summary>
        [XmlElement("coupon_template_id")]
        public long CouponTemplateId { get; set; }

        /// <summary>
        /// 商品属性
        /// </summary>
        [XmlArray("item_props")]
        [XmlArrayItem("item_prop")]
        public List<ItemPropInDetail> ItemProps { get; set; }

        /// <summary>
        /// 销售属性
        /// </summary>
        [XmlArray("iitem_specs")]
        [XmlArrayItem("item_spec")]
        public List<ItemSpecInDetail> ItemSpecs { get; set; }

        /// <summary>
        /// 商品SKU
        /// </summary>
        [XmlArray("item_skus")]
        [XmlArrayItem("item_sku")]
        public List<ItemSkuInDetail> ItemSkus { get; set; }

        /// <summary>
        /// 普通商品1 团购2
        /// </summary>
        [XmlElement("sale_type")]
        public long SaleType { get; set; }

        /// <summary>
        /// 销量
        /// </summary>
        [XmlElement("sales")]
        public long Sales { get; set; }

        /// <summary>
        /// 商品类目
        /// </summary>
        [XmlArray("item_cats")]
        [XmlArrayItem("item_cat")]
        public List<ItemCat> ItemCats { get; set; }

        /// <summary>
        /// 店铺内商品分类
        /// </summary>
        [XmlArray("item_shop_cats")]
        [XmlArrayItem("item_shop_cat")]
        public List<ItemShopCat> ItemShopCats { get; set; }

        /// <summary>
        /// 过期时间（电子券）
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 附加信息
        /// </summary>
        [XmlElement("additional_info")]
        public string AdditionalInfo { get; set; }


        /// <summary>
        /// 商品全局扩展类目
        /// </summary>
        [XmlArray("item_ext_cats")]
        [XmlArrayItem("item_ext_cat")]
        public List<ItemCat> ItemExtCats { get; set; }


        /// <summary>
        /// Seo标题
        /// </summary>
        [XmlElement("seo_title")]
        public string SeoTitle { get; set; }
        /// <summary>
        /// Seo关键字
        /// </summary>
        [XmlElement("seo_keyword")]
        public string SeoKeyword { get; set; }
        /// <summary>
        /// Seo描述
        /// </summary>
        [XmlElement("seo_description")]
        public string SeoDescription { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        [XmlElement("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// 体积
        /// </summary>
        [XmlElement("volume")]
        public double Volume { get; set; }

        /// <summary>
        /// 商品级别的促销信息
        /// </summary>
        [XmlArray("promotions_in_item")]
        [XmlArrayItem("promotion_in_item")]
        public List<GoodsDetailPromotions> PromotionInItem { get; set; }


        /// <summary>
        /// 积分限制
        /// </summary>
        [XmlElement("integral_limit")]
        public double Integrallimit { get; set; }


        /// <summary>
        /// 商品的扩展信息字段
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 自动关闭延时
        /// </summary>
        [XmlElement("close_time_delay")]
        public long CloseTimeDelay { get; set; }
    }
}
