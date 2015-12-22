using System.Collections.Generic;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Coupon.Response
{
    public class GetConsumedDailyStatisticalDataResponse : YunResponse
    {
        /// <summary>
        /// 按日分组的数据统计信息
        /// </summary>
        [XmlArray("daily_statistical_datas")]
        [XmlArrayItem("daily_statistical_data")]
        public List<DailyStatisticalData> DailyStatisticalDatas { get; set; }
    }
}
