namespace Yun.Marketing
{
    public class EditPrizeJson
    {
        /// <summary>
        /// 奖品ID
        /// </summary>
        public int prize_id { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public int item_id { get; set; }

        /// <summary>
        /// 奖品名字
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 奖品等级名字
        /// </summary>
        public string levelname { get; set; }


        /// <summary>
        /// 奖品等级，可当作排序用
        /// </summary>
        public int level { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public int item_type { get; set; }


        /// <summary>
        /// 奖品价格
        /// </summary>
        public double price { get; set; }
    }
}
