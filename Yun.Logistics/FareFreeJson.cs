using System.Collections.Generic;

namespace Yun.Logistics
{
    public class FareFreeJson
    {
        /// <summary>
        /// 递送方式的ID
        /// </summary>
        public int deliveryid { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public List<int> cityid { get; set; }

        /// <summary>
        /// 包邮条件
        /// </summary>
        public int freetype { get; set; }

        /// <summary>
        /// XX元以上免费
        /// </summary>
        public double price { get; set; }

        /// <summary>
        /// 在XX内免费
        /// </summary>
        public double preferential { get; set; }
    }
}
