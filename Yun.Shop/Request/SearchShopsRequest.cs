using System;
using System.Collections.Generic;
using Yun.Shop.Response;
using Yun.Interface;

namespace Yun.Shop.Request
{
    /// <summary>
    /// 搜索商户
    /// </summary>
    public class SearchShopsRequest : ITopRequest<SearchShopsResponse>   
    {
        /// <summary>
        /// 需要返回的字段
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

        public int? CompanyId { get; set; }

        /// <summary>
        /// 店铺名字，模糊查询
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺所在分类ID
        /// </summary>
        public int? CategoryId { get; set; }

        /// <summary>
        /// 店铺所在区域ID
        /// </summary>
        public int? AreaId { get; set; }

        /// <summary>
        /// 认证状态
        /// null全部，0：未申请；1：已申请；2：已通过；-1:拒绝
        /// </summary>
        public int? CertificationStatus { get; set; }


        /// <summary>
        /// 是否启用
        /// null全部，True是启用，False是系统关闭
        /// </summary>
        public bool? IsEnabled { get; set; }


        /// <summary>
        /// 是否开店
        /// </summary>
        public bool? IsOpen { get; set; }

        /// <summary>
        /// 最小的创建时间
        /// </summary>
        public DateTime? MinCreateTime { get; set; }

        /// <summary>
        /// 最大的创建时间
        /// </summary>
        public DateTime? MaxCreateTime { get; set; }


        /// <summary>
        /// 店铺ID，多个用英文逗号分隔
        /// </summary>
        public string ShopIds { get; set; }

        /// <summary>
        /// 店铺类型
        /// </summary>
        public int? ShopType { get; set; }

        /// <summary>
        /// 排序 排序方式：id id_desc create_time create_time_desc
        /// </summary>
        public string Sort { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 商品主营类目
        /// </summary>
        public int? ItemCatId { get; set; }

        /// <summary>
        /// 用户和店铺的绑定人，0：未认领，-1已认领，大于0，是谁认领的
        /// </summary>
        public int? BoundUserId { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public int? CreaterId { get; set; } 

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

        public string GetApiName()
        {
            return "chenggou.shops.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum},
                {"pagesize", PageSize},
                {"shopname", ShopName},
                {"categoryid", CategoryId},
                {"areaid", AreaId},
                {"companyid", CompanyId},
                {"fields", Fields},
                {"mincreatetime", MinCreateTime},
                {"maxcreatetime", MaxCreateTime},
                {"isenabled", IsEnabled},
                {"isopen",IsOpen },
                {"certificationstatus", CertificationStatus},
                { "shopids",ShopIds},
                {"shoptype",ShopType },
                {"sort", Sort},
                {"parentid",ParentId },
                {"itemcatid",ItemCatId },
                {"bounduserid",BoundUserId },
                {"province",Province },
                {"city",City },
                {"area",Area },
                {"town",Town },
                {"createrid",CreaterId }
            };
            return parameters;
        }

        public void Validate()
        {
        }
    }
}
