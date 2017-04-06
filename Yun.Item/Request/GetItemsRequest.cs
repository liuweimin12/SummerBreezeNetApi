using System.Collections.Generic;
using Yun.Interface;
using Yun.Item.Response;
using Yun.Util;

namespace Yun.Item.Request
{
    /// <summary>
    /// 获取商品列表
    /// </summary>
    public class GetItemsRequest : ITopRequest<GetItemsResponse>
    {
        /// <summary>
        /// 销售属性值Id精确查找
        /// </summary>
        public string SpecIds { get; set; }

        /// <summary>
        /// 商品属性值Id精确查找
        /// </summary>
        public string PropIds { get; set; }

        /// <summary>
        /// 各属性操作符propids:or#specids:and
        /// </summary>
        public string Operation { get; set; }


        /// <summary>
        /// 商品标题模糊查找
        /// </summary>
        public string ItemTitle { get; set; }


        /// <summary>
        /// 是否是分销
        /// </summary>
        public bool? IsDistribution { get; set; }

        /// <summary>
        /// 商品状态约束(出售中1库存中2)
        /// </summary>
        public int? ItemState { get; set; }

        /// <summary>
        /// 商品Id精确查找
        /// </summary>
        public string Ids { get; set; }

        /// <summary>
        /// 商品类型约束
        /// </summary>
        public int? SaleType { get; set; }


        /// <summary>
        /// 最大价格约束
        /// </summary>
        public double? MaxPrice { get; set; }


        /// <summary>
        /// 最小价格约束
        /// </summary>
        public double? MinPrice { get; set; }

        /// <summary>
        /// 适用地区约束
        /// </summary>
        public string AreaIds { get; set; }

        /// <summary>
        /// 商品分类约束
        /// </summary>
        public string ItemCatIds { get; set; }

        /// <summary>
        /// 店铺内分类约束
        /// </summary>
        public string ShopCatIds { get; set; }

        /// <summary>
        /// 需要显示的字段，商品详情内的真实
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum { get; set; }

        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 属性，SPU值
        /// </summary>
        public string PropValue { get; set; }

        /// <summary>
        /// 销售属性SKU值
        /// </summary>
        public string SpecValue { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        public string ItemCode { get; set; }
        
        /// <summary>
        /// 店铺ID
        /// </summary>
        public int? ShopId { get; set; }

        /// <summary>
        /// 排序字段，支持sales,salesdesc,price,pricedesc,praises,praisesdesc,onshelftime,onshelftimedesc,id,iddesc,keywords,default,sort,sortdesc,stock,stockdesc
        /// </summary>
        public string Sorts { get; set; }

        /// <summary>
        /// 推荐类型，可以使用英文逗号进行分割进行并列搜索，例如可以输入如下格式0,1,2,3，意思是搜索这4种推荐类型的商品
        /// </summary>
        public string Recommend { get; set; }

        /// <summary>
        /// 如果大于0，则标识搜索已删除的商品，小于1则表示搜索未删除商品
        /// </summary>
        public int? IsDelete { get; set; }


        /// <summary>
        /// 公司ID
        /// </summary>
        public int? CompanyId { get; set; }

        /// <summary>
        /// 是否需要促销的信息
        /// </summary>
        public bool? NeedPromotion { get; set; }

        /// <summary>
        /// 匹配的物流模板ID
        /// </summary>
        public int? LogisticsTemplateId { get; set; }

        /// <summary>
        /// 电子券模板ID
        /// </summary>
        public int? ElectronicCouponsTemplateId { get; set; }


        /// <summary>
        /// 限时折扣ID,多个用空个分割，如果需要搜索所有的参加限时折扣的商品，输入-1
        /// </summary>
        public string DiscountActivityId { get; set; }

        public string GetApiName()
        {
            return "chenggou.items.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"specids", SpecIds},
                {"propids", PropIds},
                {"itemcode", ItemCode},
                {"itemstate", ItemState},
                {"saletype", SaleType},
                {"maxprice", MaxPrice},
                {"itemtitle", ItemTitle},
                {"sorts", Sorts},
                {"minprice", MinPrice},
                {"areaids", AreaIds},
                {"itemcatids", ItemCatIds},
                {"shopcatids", ShopCatIds},
                {"ids", Ids},
                {"fields", Fields},
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"shopid", ShopId},
                {"operation", Operation},
                {"propvalue", PropValue},
                {"specvalue", SpecValue},
                {"recommend", Recommend},
                {"isdelete", IsDelete},
                {"companyid", CompanyId},
                {"needpromotion", NeedPromotion},
                {"logisticstemplateid", LogisticsTemplateId},
                {"electroniccouponstemplateid", ElectronicCouponsTemplateId},
                {"isdistribution", IsDistribution},
                {"discountactivityid", DiscountActivityId}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("pagenum", PageNum);
            RequestValidator.ValidateRequired("pagesize", PageSize);
        }
    }
}
