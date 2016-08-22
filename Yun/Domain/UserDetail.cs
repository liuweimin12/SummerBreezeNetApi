using System.Collections.Generic;
using System.Xml.Serialization;

namespace Yun.Domain
{
   public class UserDetail
    {
        /// <summary>
        /// 快捷登陆的ID
        /// </summary>
        [XmlArray("oauth_ids")]
        [XmlArrayItem("oauth_id")]
        public List<string> OauthId { get; set; }

        /// <summary>
        /// 用户iD
        /// </summary>
        [XmlElement("user_id")]
       public long UserId { get; set; }

       /// <summary>
       /// 用户名
       /// </summary>
       [XmlElement("nick")]
       public string Nick { get; set; }

       /// <summary>
       /// 性别，男OR女
       /// </summary>
       [XmlElement("sex")]
       public string Sex { get; set; }

       /// <summary>
       /// 买家行用
       /// </summary>
       [XmlElement("buyer_user_credit")]
       public UserCredit BuyerUserCredit { get; set; }

       /// <summary>
       /// 创建时间
       /// </summary>
       [XmlElement("create_time")]
       public string CreateTime { get; set; }

       /// <summary>
       /// 最后登录时间
       /// </summary>
       [XmlElement("last_visit")]
       public string LastVisit { get; set; }

       /// <summary>
       /// 可选值:authentication(实名认证),not authentication(没有认证)
       /// </summary>
       [XmlElement("promoted_type")]
       public string PromotedType { get; set; }

       /// <summary>
       /// Direct(直接注册)，Qq(QQ快捷登录)，Sina(微博快捷登录)，TaoBao(淘宝快捷登录)，Alipay(支付宝快捷登录)，Phone(手机注册)
       /// </summary>
       [XmlElement("register_type")]
       public string RegisterType { get; set; }

       /// <summary>
       /// 可选值:normal(正常),inactive(未激活),delete(删除),reeze(冻结),supervise(监管)
       /// </summary>
       [XmlElement("status")]
       public string Status { get; set; }
       
       /// <summary>
       /// 是否设置支付密码
       /// </summary>
       [XmlElement("is_set_pay_password")]
       public bool IsSetPayPassword { get; set; }

       /// <summary>
       /// 头像的完整URL
       /// </summary>
       [XmlElement("avatar")]
       public string Avatar { get; set; }

       /// <summary>
       /// 店铺id
       /// </summary>
       [XmlElement("shop_id")]
       public long ShopId { get; set; }

       /// <summary>
       /// 是否是店主
       /// </summary>
       [XmlElement("is_shopkeeper")]
       public bool IsShopkeeper { get; set; }

       /// <summary>
       /// 是否是公司的法人
       /// </summary>
       [XmlElement("is_legal")]
       public bool IsLegal { get; set; }

       /// <summary>
       /// 邮箱
       /// </summary>
       [XmlElement("email")]
       public string Email { get; set; }

       /// <summary>
       /// 手机号码
       /// </summary>
       [XmlElement("mobile")]
       public string Mobile { get; set; }

       /// <summary>
       /// 积分
       /// </summary>
       [XmlElement("score")]
       public long Score { get; set; }

       /// <summary>
       /// 账户余额
       /// </summary>
       [XmlElement("money")]
       public string Money { get; set; }

       /// <summary>
       /// 真实名字
       /// </summary>
       [XmlElement("real_name")]
       public string RealName { get; set; }

       /// <summary>
       /// 系统组别
       /// </summary>
       [XmlElement("system_group")]
       public long SystemGroup { get; set; }

       /// <summary>
       /// 公司ID
       /// </summary>
       [XmlElement("company_id")]
       public long CompanyId { get; set; }

        /// <summary>
        /// 是否是分销商
        /// </summary>
        [XmlArray("owned_suppliers")]
        [XmlArrayItem("owned_supplier")]
        public List<int> OwnedSupplier { get; set; }

        /// <summary>
        /// 充值卡余额
        /// </summary>
        [XmlElement("prepaid_card")]
        public double PrepaidCard { get; set; }


        [XmlArray("user_tags")]
        [XmlArrayItem("user_tag")]
        public List<YunKeyValuePair<int, string>> UserTags { get; set; }


        /// <summary>
        /// 交易额
        /// </summary>
        [XmlElement("turnover")]
        public double Turnover { get; set; }


        /// <summary>
        /// 交易量，用户下订单的次数总计
        /// </summary>
        [XmlElement("trading_volume")]
        public double TradingVolume { get; set; }


        /// <summary>
        /// 最后交易时间
        /// </summary>
        [XmlElement("last_trade")]
        public long LastTrade { get; set; }




        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }


        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }


        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }


        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }


        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }


        /// <summary>
        /// 生日
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }


        /// <summary>
        /// 身份证
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }


        /// <summary>
        /// 是否是职员
        /// </summary>
        [XmlElement("is_staff")]
        public bool IsStaff { get; set; }

        /// <summary>
        /// 是否是管理员
        /// </summary>
        [XmlElement("is_manager")]
        public bool IsManage { get; set; }


        /// <summary>
        /// 用户类型，客户端自定义
        /// </summary>
        [XmlElement("user_type")]
        public int UserType { get; set; }

    }
}
