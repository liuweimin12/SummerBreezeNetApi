
using System;

namespace Yun.Pay
{
    public class BatchAddCardJson
    {
        /// <summary>
        /// 卡号
        /// </summary>
        public string card_number { get; set; }

        /// <summary>
        /// 卡密码
        /// </summary>
        public string card_password { get; set; }

        /// <summary>
        /// 需要绑定的店铺ID
        /// </summary>
        public int bind_shopId { get; set; }

        /// <summary>
        /// 需要绑定的公司ID
        /// </summary>
        public int bind_companyId { get; set; }


        /// <summary>
        /// 积分过期时间
        /// </summary>
        public string expired_time { get; set; }
    }
}
