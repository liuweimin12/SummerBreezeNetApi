using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yun.Marketing
{
    public class AddGroupBuyJson
    {
        public int item_id { get; set; }

        /// <summary>
        /// 是否有减钱行为
        /// </summary>
        public bool is_decrease_money { get; set; }

        /// <summary>
        /// 减钱金额
        /// </summary>
        public double decrease_amount { get; set; }


        /// <summary>
        /// 折扣率
        /// </summary>
        public double discount_rate { get; set; }

        /// <summary>
        /// 是否有打折行为
        /// </summary>
        public bool is_discount { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string item_title { get; set; }


        /// <summary>
        /// 商品描述
        /// </summary>
        public string item_description { get; set; }


        /// <summary>
        /// 商品详情
        /// </summary>
        public string item_detail { get; set; }


        /// <summary>
        /// 商品预览图，多张用英文逗号分隔
        /// </summary>
        public string item_images { get; set; }

        /// <summary>
        /// 在团购期间最多允许的购买数量
        /// </summary>
        public int max_stock { get; set; }

        /// <summary>
        /// 商品扩展内容
        /// </summary>
        public string ext { get; set; }
    }
}
