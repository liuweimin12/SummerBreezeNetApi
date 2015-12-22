using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Yun.Pay
{
    public class WithdrawalsDetail
    {
        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 提现ID号
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }

        /// <summary>
        /// 提现人的用户ID
        /// </summary>
        [XmlElement("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// 提现人的用户名
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 提现金额
        /// </summary>
        [XmlElement("money")]
        public double Money { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 提现状态
        /// </summary>
        [XmlElement("status")]
        public int Status { get; set; }

        /// <summary>
        /// 提现后剩余金额
        /// </summary>
        [XmlElement("remain_money")]
        public double RemainMoney { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        [XmlElement("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 分行信息
        /// </summary>
        [XmlElement("sub_branch")]
        public string SubBranch { get; set; }
    }
}
