using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yun.Marketing
{
    public class AddCombinationItemsJson
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public int item_id { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string item_title { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int sort { get; set; }

        /// <summary>
        /// 商品缩略图
        /// </summary>
        public string image { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        public string market_price { get; set; }
    }
}
