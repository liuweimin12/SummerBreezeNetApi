
namespace Yun.User
{
    public class OAth2SettingJson
    {
        public string oauth2_type { get; set; }

        /// <summary>
        /// 客户端ID
        /// </summary>
        public string client_id { get; set; }

        /// <summary>
        /// 密钥
        /// </summary>
        public string client_secret { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        public string callback_url { get; set; }
    }
}
