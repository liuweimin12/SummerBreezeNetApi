using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Logistics
{
    public class DeliveryTemplate
    {
        /// <summary>
        /// 模板id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 免邮数量，-1免邮，0不免邮费，正整数为免邮数量
        /// </summary>
        [XmlElement("fare_free")]
        public long FareFree { get; set; }

        /// <summary>
        /// 模板名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string  CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string  ModifyTime { get; set; }

        /// <summary>
        /// 模板信息
        /// </summary>
        [XmlArray("freights")]
        [XmlArrayItem("freight")]
        public List<PostfareDetail> Freight { get; set; }

        [XmlArray("fare_free_conditions")]
        [XmlArrayItem("fare_free_condition")]
        public List<FareFreeCondition> FareFreeConditions { get; set; }

        /// <summary>
        /// 计价方式
        /// </summary>
        [XmlElement("price_type")]
        public int PriceType { get; set; }
    }
}
