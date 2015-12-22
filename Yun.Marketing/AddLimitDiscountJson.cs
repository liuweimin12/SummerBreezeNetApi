
namespace Yun.Marketing
{
    public class AddLimitDiscountJson
    {
        /// <summary>
        /// 商品id
        /// </summary>
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
        /// 在团购期间最多允许的购买数量
        /// </summary>
        public int max_stock { get; set; }

        /// <summary>
        /// 商品扩展内容
        /// </summary>
        public string ext { get; set; }

    }
}
