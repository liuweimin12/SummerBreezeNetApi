using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    public class UpdateItemRequest : ITopRequest<BoolResultResponse>
    {
        /// <summary>
        /// 积分数量
        /// </summary>
        public int IntegralQuantity { get; set; }

        /// <summary>
        /// 审核状态，1为需要审核，0不需要审核
        /// </summary>
        public int AuditState { get; set; }

        /// <summary>
        /// 移动端的额商品详情
        /// </summary>
        public string MobileDetail { get; set; }

        /// <summary>
        /// 每账号限购，控制时间间隔
        /// </summary>
        public int PerLimitBuyHour { get; set; }

        /// <summary>
        /// 商品积分限制
        /// </summary>
        public double Integrallimit { get; set; }

        /// <summary>
        /// JSON格式的SKU
        /// </summary>
        public List<JsonCustomSkus> JsonCustomSkus { get; set; }

        /// <summary>
        /// 库存计数方式，0：付款减库存，1：拍下减库存
        /// </summary>
        public int InventoryCount { get; set; }

        /// <summary>
        /// 是否限制该用户只能购买一次
        /// </summary>
        public bool BuyOnce { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// 体积
        /// </summary>
        public double Volume { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// 团购标题
        /// </summary>
        public string TuanTitle { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string ItemTitle { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        public string SubTitle { get; set; }

        /// <summary>
        /// 消息标题(电子券发券标题)
        /// </summary>
        public string MsgTitle { get; set; }


        /// <summary>
        /// 类型
        /// </summary>
        public int SaleType { get; set; }


        /// <summary>
        /// 商品编码
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 现价
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        public double MarketPrice { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// 每人限购
        /// </summary>
        public int BuyLimit { get; set; }

        /// <summary>
        /// 商品预览图
        /// </summary>
        public string Pictures { get; set; }


        /// <summary>
        /// 1：立即 2:库存 3:定时
        /// </summary>
        public int OnShelfType { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        public long OnShelfTime { get; set; }



        /// <summary>
        /// 运费模板Id
        /// </summary>
        public int FreightTemplateId { get; set; }
        /// <summary>
        /// 电子券模板Id
        /// </summary>
        public int CouponTemplateId { get; set; }

        /// <summary>
        /// 商品分类(导购)
        /// 32,3,34
        /// 只能数字
        /// </summary>
        public string ShopCatIds { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        /// <summary>
        /// 商品分类
        /// </summary>
        public int ItemCatId { get; set; }

        /// <summary>
        /// 商品属性值
        /// 12,123,5242,43
        /// 只能数字
        /// </summary>
        public string ItemPropValues { get; set; }

        /// <summary>
        /// 自定义属性名
        /// json
        /// ["版型","风格"]
        /// 只能文字
        /// </summary>
        public string CustomPropNames { get; set; }

        /// <summary>
        /// 自定义属性值,与自定义属性名一一对应
        /// json
        /// ["欧美","时尚"]
        /// 只能文字
        /// </summary>
        public string CustomPropValues { get; set; }


        /// <summary>
        /// 销售属性值
        /// 如有自定义则忽略
        /// [[[12,123],100.3,100,"code","addition",150.0],[[12,122],120.3,100,"code","addition",160.0]]
        /// </summary>
        public string ItemSkus { get; set; }

        /// <summary>
        /// 自定义销售属性名
        /// json
        ///  ["颜色","长度"]
        /// 只能文字
        /// </summary>
        public string CustomSpecNames { get; set; }

        /// <summary>
        /// 自定义销售属性组合
        ///  [["红色","1"],["红色","2"]]
        /// </summary>

        //public string CustomSpecValues { get; set; }

        /// <summary>
        /// [100.3,120.3]
        /// </summary>
        //public string SkuPrices { get; set; }

        /// <summary>
        /// [120.0,150.0]
        /// </summary>
        //public string SkuMarketPrices { get; set; }

        /// <summary>
        /// ["code1","code2"]
        /// </summary>
        //public string SkuCodes { get; set; }

        /// <summary>
        /// ["add1","add2"]
        /// </summary>
        //public string SkuAddtionInfos { get; set; }
        /// <summary>
        /// 自定义销售属性值
        /// json
        /// [["红色","1",100.3,100,"code","addition",120.0],["红色","2",120.3,100,"code","addition",130.0]]
        /// 只能文字
        /// </summary>
        public string CustomSkus { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        public string Description { get; set; }


        /// <summary>
        /// 适用商户
        /// </summary>
        public string ItemPartnerIds { get; set; }

        /// <summary>
        /// 状态，可以自定义状态标记
        /// </summary>
        public int IsRecommend { get; set; }

        /// <summary>
        /// 附加信息
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// 电子券的过期时间
        /// </summary>
        public long ExpireTime { get; set; }

        /// <summary>
        /// Seo标题
        /// </summary>
        public string SeoTitle { get; set; }
        /// <summary>
        /// Seo关键字
        /// </summary>
        public string SeoKeyword { get; set; }
        /// <summary>
        /// Seo描述
        /// </summary>
        public string SeoDescription { get; set; }

        /// <summary>
        /// 电子券有效期开始时间
        /// </summary>
        public long ExpireStart { get; set; }

        /// <summary>
        /// 电子券有效期规则
        /// 0,1,2
        /// </summary>
        public int ExpireRule { get; set; }

        /// <summary>
        /// 电子券几天过期
        /// </summary>
        public int ExpireDays { get; set; }


        /// <summary>
        /// 排序，默认为0
        /// </summary>
        public int SortOrder { get; set; }

        /// <summary>
        /// 自动关闭延时
        /// </summary>
        public long CloseTimeDelay { get; set; }


        /// <summary>
        /// LOGO
        /// </summary>
        public string Picture { get; set; }

        public string GetApiName()
        {
            return "chenggou.item.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"itemid", ItemId},
                {"tuantitle", TuanTitle},
                {"itemtitle", ItemTitle},
                {"subtitle", SubTitle},
                {"msgtitle", MsgTitle},
                {"saletype", SaleType},
                {"itemcode", ItemCode},
                {"price", Price},
                {"marketprice", MarketPrice},
                {"stock", Stock},
                {"buylimit", BuyLimit},
                {"pictures", Pictures},
                {"onshelftype", OnShelfType},
                {"onshelftime", OnShelfTime},
                {"freighttemplateid", FreightTemplateId},
                {"coupontemplateid", CouponTemplateId},
                {"shopcatids", ShopCatIds},
                {"itemcatid", ItemCatId},
                {"itempropvalues", ItemPropValues},
                {"custompropnames", CustomPropNames},
                {"custompropvalues", CustomPropValues},
                {"itemskus", ItemSkus},
                {"customspecnames", CustomSpecNames},
                {"customskus", CustomSkus},
                {"description", WebUtils.ToBase64StringForUrl(Description)},
                {"itempartnerids", ItemPartnerIds},
                {"isrecommend", IsRecommend},
                {"additionalinfo", AdditionalInfo},
                {"expiretime", ExpireTime},
                {"seotitle", SeoTitle},
                {"seokeyword", SeoKeyword},
                {"seodescription", SeoDescription},
                {"expirestart", ExpireStart},
                {"expirerule", ExpireRule},
                {"expiredays", ExpireDays},
                {"weight", Weight},
                {"volume", Volume},
                {"buyonce", BuyOnce},
                {"extitemcatids", ExtItemCatIds},
                {"inventorycount", InventoryCount},
                {"integrallimit", Integrallimit},
                {"distributiontemplateid", DistributionTemplateId},
                {"sortorder", SortOrder},
                {"closetimedelay", CloseTimeDelay},
                {"perlimitbuyhour", PerLimitBuyHour},
                {"shopid", ShopId},
                {"mobiledetail", MobileDetail},
                {"jsoncustomskus", JsonCustomSkus},
                {"auditstate", AuditState},
                {"picture", Picture},
                {"integralquantity", IntegralQuantity},
            };

            return parameters;
        }

        /// <summary>
        /// 分销模板ID
        /// </summary>
        public int DistributionTemplateId { get; set; }

        /// <summary>
        /// 全局类目扩展分类，多个用英文逗号分隔
        /// </summary>
        public string ExtItemCatIds { get; set; }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("itemtitle", ItemTitle, 200);
            RequestValidator.ValidateMaxLength("msgtitle", MsgTitle, 20);
        }
    }
}
