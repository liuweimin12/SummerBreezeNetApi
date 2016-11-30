using System.Xml.Serialization;

namespace Yun.User
{
    public class TotalPoints
    {
        /// <summary>
        /// 收入
        /// </summary>
        [XmlElement("income")]
        public int Income { get; set; }


        /// <summary>
        /// 支出
        /// </summary>
        [XmlElement("expenses")]
        public int Expenses { get; set; }

        /// <summary>
        /// 剩余量
        /// </summary>
        [XmlElement("balance")]
        public int Balance { get; set; }
    }
}
