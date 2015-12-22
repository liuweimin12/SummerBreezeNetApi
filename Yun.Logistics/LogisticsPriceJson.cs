using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yun.Logistics
{
    public class LogisticsPriceJson
    {
        /// <summary>
        /// 运送方式id
        /// </summary>
        public int deliveryid { get; set; }

        /// <summary>
        /// 城市ID
        /// </summary>
        public List<int> cityid { get; set; }

        /// <summary>
        /// 首X数量
        /// </summary>
        public double basequantity { get; set; }

        /// <summary>
        /// 首X价格
        /// </summary>
        public double baseprice { get; set; }

        /// <summary>
        /// 次x数量
        /// </summary>
        public double addquantity { get; set; }

        /// <summary>
        /// 次X价格
        /// </summary>
        public double addprice { get; set; }
    }
}
