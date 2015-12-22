
using System.Xml.Serialization;

namespace Yun.Pay
{
    public class UnifiedorderResult
    {
        /// <summary>
        /// 返回状态码
        /// SUCCESS/FAIL
        /// 此字段是通信标识，非交易标识，交易是否成功需要查看result_code来判断
        /// </summary>
        [XmlElement("return_code")]
        public string ReturnCode { get; set; }


        /// <summary>
        /// 返回信息
        /// 返回信息，如非空，为错误原因
        /// 签名失败
        /// 参数格式校验错误
        /// </summary>
        [XmlElement("return_msg")]
        public string ReturnMsg { get; set; }


        /// <summary>
        /// 调用接口提交的公众账号ID
        /// </summary>
        [XmlElement("appid")]
        public string Appid { get; set; }

        /// <summary>
        /// 调用接口提交的公众账号ID
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }


        /// <summary>
        /// 调用接口提交的终端设备号，
        /// </summary>
        [XmlElement("device_info")]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 微信返回的随机字符串
        /// </summary>
        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }


        /// <summary>
        /// 微信返回的签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }


        /// <summary>
        /// SUCCESS/FAIL
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }


        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("err_code")]
        public string ErrCode { get; set; }


        /// <summary>
        /// 错误代码描述
        /// </summary>
        [XmlElement("err_code_des")]
        public string ErrCodeDes { get; set; }


        /// <summary>
        /// 交易类型
        /// 调用接口提交的交易类型，取值如下：JSAPI，NATIVE，APP
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 预支付交易会话标识
        /// 微信生成的预支付回话标识，用于后续接口调用中使用，该值有效期为2小时
        /// </summary>
        [XmlElement("prepay_id")]
        public string PrepayId { get; set; }

        /// <summary>
        /// 二维码链接
        /// trade_type为NATIVE是有返回，可将该参数值生成二维码展示出来进行扫码支付
        /// </summary>
        [XmlElement("code_url")]
        public string CodeUrl { get; set; }
    }
}
