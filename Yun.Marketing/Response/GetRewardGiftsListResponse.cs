using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
     [XmlRoot("get_reward_gifts_list_response")]
    public class GetRewardGiftsListResponse:YunResponse
    {
        [XmlArray("reward_gift_promotion")]
        [XmlArrayItem("reward_gift_promotions")]
        public List<RewardGiftList> RewardGiftPromotions { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
