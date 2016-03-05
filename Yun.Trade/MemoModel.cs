using System.Xml.Serialization;

namespace Yun.Trade
{
    public class MemoModel
    {
        /// <summary>
        /// 主订单标记
        /// </summary>
        [XmlElement("flag")]
        public int Flag { get; set; }

        /// <summary>
        /// 卖家备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 自定义订单类型，卖家直接控制，和订单标记联合使用
        /// </summary>
        [XmlElement("slave_flag")]
        public int SlaveFlag { get; set; }
    }
}
