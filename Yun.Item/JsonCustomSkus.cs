

namespace Yun.Item
{
    public class JsonCustomSkus
    {
        /// <summary>
        /// 缩略图
        /// </summary>
        public string images { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        public string[] spec_values { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        public double price { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        public double market_price { get; set; }


        /// <summary>
        /// 库存
        /// </summary>
        public int stock { get; set; }


        /// <summary>
        /// 商品编码
        /// </summary>
        public string item_code { get; set; }


        /// <summary>
        /// 扩展
        /// </summary>
        public string ext { get; set; }
    }
}
