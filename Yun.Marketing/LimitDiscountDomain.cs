using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Marketing
{
    public class LimitDiscountDomain
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public int ShopId { get; set; }


        /// <summary>
        /// 活动隶属于哪个公司
        /// </summary>
        [XmlElement("company_id")]
        public int CompanyId { get; set; }


        /// <summary>
        /// 创建人ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }


        /// <summary>
        /// 促销活动ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 促销活动名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }


        /// <summary>
        /// 活动的有效条件、人群和行为描述。
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 活动范围：0表示全部参与； 1表示部分商品参与。
        /// </summary>
        [XmlElement("participate_range")]
        public int ParticipateRange { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }


        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

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
        /// 商品数量
        /// </summary>
        [XmlElement("item_num")]
        public int ItemNum { get; set; }
    }
}
