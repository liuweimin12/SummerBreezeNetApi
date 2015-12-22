using System.Collections.Generic;
using Yun.Domain;

namespace Yun.Marketing
{
    public class AddRewardGiftJson
    {
        /// <summary>
        /// 是否有满元条件
        /// </summary>
        public bool is_amount_over { get; set; }

        /// <summary>
        /// 满多少元
        /// </summary>
        public double total_price { get; set; }

        /// <summary>
        /// 满元是否上不封顶
        /// </summary>
        public bool is_amount_multiple { get; set; }

        /// <summary>
        /// 是否有满件条件
        /// </summary>
        public bool is_item_count_over { get; set; }

        /// <summary>
        /// 满多少件
        /// </summary>
        public int item_count { get; set; }

        /// <summary>
        /// 满件是否上不封顶
        /// </summary>
        public bool is_item_multiple { get; set; }

        /// <summary>
        /// 是否有送礼品行为
        /// </summary>
        public bool is_send_gift { get; set; }

        /// <summary>
        /// 需要赠送的礼品
        /// </summary>
        public List<GiftJson> GiftJsons { get; set; }

        /// <summary>
        /// 是否有免邮行为
        /// </summary>
        public bool is_free_post { get; set; }

        /// <summary>
        /// 免邮的排除地区
        /// </summary>
        public string exclude_area { get; set; }

        /// <summary>
        /// 是否有减钱行为
        /// </summary>
        public bool is_decrease_money { get; set; }

        /// <summary>
        /// 减钱金额
        /// </summary>
        public double decrease_amount { get; set; }


        /// <summary>
        /// 是否有打折行为
        /// </summary>
        public double discount_rate { get; set; }

        /// <summary>
        /// 是否有打折行为
        /// </summary>
        public bool is_discount { get; set; }
    }
}
