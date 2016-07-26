using System.Collections.Generic;
using Yun.Shop.Response;
using Yun.Interface;
using Yun.Util;

namespace Yun.Shop.Request
{
    public class GetShopAreasRequest : ITopRequest<CategoriesResponse>   
    {
        /// <summary>
        /// 父ID，如果不传，则全部
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 其他ID
        /// </summary>
        public int OtherId { get; set; }


        public string GetApiName()
        {
            return "chenggou.shop.areas.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"parentid", ParentId},
                {"otherid",OtherId }
            };
            return parameters;
        }

        public void Validate()
        {
            
        }
    }
}
