using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Yun.Interface;
using Yun.Response;

namespace Yun.Site.Response
{
    [XmlRoot("get_subscription_list_response")]
    public class GetSubscriptionListResponse:YunResponse
    {
        [XmlArray("subscriptions")]
        [XmlArrayItem("subscription")]
        public List<SubscriptionModel> Subscriptions { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
