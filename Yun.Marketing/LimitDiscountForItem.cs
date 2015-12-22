using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Marketing
{
   public class LimitDiscountForItem
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public int ItemId { get; set; }

        /// <summary>
        /// 是否有减钱行为
        /// </summary>
        [XmlElement("is_decrease_money")]
        public bool IsDecreaseMoney { get; set; }

        /// <summary>
        /// 减钱金额
        /// </summary>
        [XmlElement("decrease_amount")]
        public double DecreaseAmount { get; set; }


        /// <summary>
        /// 折扣率
        /// </summary>
        [XmlElement("discount_rate")]
        public double DiscountRate { get; set; }

        /// <summary>
        /// 是否有打折行为
        /// </summary>
        [XmlElement("is_discount")]
        public bool IsDiscount { get; set; }



        /// <summary>
        /// 商品的扩展信息
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }
    }
}
