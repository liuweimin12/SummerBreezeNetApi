using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Response;

namespace Yun.Marketing.Response
{
    [XmlRoot("get_reward_gift_response")]
    public class GetRewardGiftResponse:YunResponse
    {
        [XmlElement("reward_gift_promotion")]
        public RewardGiftsDetail RewardGiftPromotion { get; set; }

    }
}
