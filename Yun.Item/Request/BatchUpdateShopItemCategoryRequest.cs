using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Response;

namespace Yun.Item.Request
{
    /// <summary>
    /// 批量修改店铺内商品分类排序
    /// chenggou.shop.item.category.batchupdatesort
    /// </summary>
    public class BatchUpdateShopItemCategoryRequest:ITopRequest<BoolResultResponse>
    {/// <summary>
        /// id,排序
        /// </summary>
        public Dictionary<int, int> Sort { get; set; }

        private static string ConvertSort(Dictionary<int, int> sort)
        {
            if (sort == null || !sort.Any())
            {
                return "";
            }

            var s = "";
            foreach (var i in sort)
            {
                s += string.Format("{0}:{1}#", i.Key, i.Value);
            }

            return s.Trim('#');
        }



        public string GetApiName()
        {
            return "chenggou.shop.item.category.batchupdatesort";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"sortcontent", ConvertSort(Sort)}
            };
            return parameters;
        }

        public void Validate()
        {

        }
    }
}
