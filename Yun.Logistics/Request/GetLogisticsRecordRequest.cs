using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Interface;
using Yun.Logistics.Response;
using Yun.Util;

namespace Yun.Logistics.Request
{
    /// <summary>
    /// 获取物流的走单记录
    /// chenggou.logistics.record.get
    /// </summary>
    public class GetLogisticsRecordRequest : ITopRequest<GetLogisticsRecordResponse>
    {
        public static readonly Dictionary<string, string> ExpressNames = new Dictionary<string, string>
        {
            {"全球专递","aae"},
            {"安捷快递","anjiekuaidi"},
            {"安信达快递","anxindakuaixi"},
            {"百福东方","baifudongfang"},
            {"彪记快递","biaojikuaidi"},
            {"BHT","bht"},
            {"希伊艾斯快递","cces"},
            {"中国东方","coe"},
            {"长宇物流","changyuwuliu"},
            {"大田物流","datianwuliu"},
            {"德邦物流","debangwuliu"},
            {"DPEX","dpex"},
            {"DHL","dhl"},
            {"D速快递","dsukuaidi"},
            {"fedex","fedex"},
            {"飞康达物流","feikangda"},
            {"凤凰快递","fenghuangkuaidi"},
            {"港中能达物流","ganzhongnengda"},
            {"广东邮政物流","guangdongyouzhengwuliu"},
            {"汇通快运","huitongkuaidi"},
            {"恒路物流","hengluwuliu"},
            {"华夏龙物流","huaxialongwuliu"},
            {"佳怡物流","jiayiwuliu"},
            {"京广速递","jinguangsudikuaijian"},
            {"急先达","jixianda"},
            {"佳吉物流","jiajiwuliu"},
            {"加运美","jiayunmeiwuliu"},
            {"快捷速递","kuaijiesudi"},
            {"联昊通物流","lianhaowuliu"},
            {"龙邦物流","minghangkuaidi"},
            {"民航快递","peisihuoyunkuaidi"},
            {"配思货运","quanchenkuaidi"},
            {"全晨快递","quanjitong"},
            {"全际通物流","quanritongkuaidi"},
            {"全日通快递","quanyikuaidi"},
            {"盛辉物流","shenghuiwuliu"},
            {"速尔物流","suer"},
            {"盛丰物流","shengfengwuliu"},
            {"天地华宇","tiandihuayu"},
            {"天天快递","tiantian"},
            {"TNT","tnt"},
            {"UPS","ups"},
            {"万家物流","wanjiawuliu"},
            {"文捷航空速递","wenjiesudi"},
            {"伍圆速递","wuyuansudi"},
            {"万象物流","wanxiangwuliu"},
            {"新邦物流","xinbangwuliu"},
            {"信丰物流","xinfengwuliu"},
            {"星晨急便","xingchengjibian"},
            {"鑫飞鸿物流","xinhongyukuaidi"},
            {"亚风速递","yafengsudi"},
            {"一邦速递","yibangwuliu"},
            {"优速物流","youshuwuliu"},
            {"远成物流","yuanchengwuliu"},
            {"圆通速递","yuantong"},
            {"源伟丰快递","yuanweifeng"},
            {"元智捷诚快递","yuanzhijiecheng"},
            {"越丰物流","yuefengwuliu"},
            {"韵达快递","yunda"},
            {"源安达","yuananda"},
            {"运通快递","yuntongkuaidi"},
            {"宅急送","zhaijisong"},
            {"中铁快运","zhongtiewuliu"},
            {"中通速递","zhongtong"},
            {"中邮物流","zhongyouwuliu"},
            {"申通快递","shentong"},
            {"顺丰速递","shunfeng"},
            {"ems","ems"}
        };

        /// <summary>
        /// 快递单号
        /// </summary>
        public string LogisticsNumber { get; set; }

        /// <summary>
        /// 物流公司名称，中文，如果没有中文则使用英文
        /// </summary>
        public string LogisticsName { get; set; }


        public string GetApiName()
        {
            return "chenggou.logistics.record.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
               {"logisticsnumber",LogisticsNumber},
               {"logisticsname",LogisticsName}
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("logisticsnumber", LogisticsNumber);
            RequestValidator.ValidateRequired("logisticsname", LogisticsName);
        }
    }
}
