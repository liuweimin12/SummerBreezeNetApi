using System;
using System.Collections.Generic;
using Yun.Interface;
using Yun.Response;
using Yun.Util;

namespace Yun.Marketing.Request
{
    public class AddGameRequest : ITopRequest<IntResultResponse>
    {
        /// <summary>
        /// 游戏标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 标题图片
        /// </summary>
        public string Banner { get; set; }

        /// <summary>
        /// 游戏描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 游戏开始时间
        /// </summary>
        public DateTime? StartTime { get; set; }


        /// <summary>
        /// 游戏结束时间
        /// </summary>
        public DateTime? EndTime { get; set; }


        /// <summary>
        /// 游戏详情
        /// </summary>
        public string Detail { get; set; }


        /// <summary>
        /// 扩展字段信息
        /// </summary>
        public string Ext { get; set; }


        /// <summary>
        /// 用户可玩的最大游戏次数
        /// </summary>
        public int MaxTimes { get; set; }

        /// <summary>
        /// 游戏类型
        /// </summary>
        public string GameType { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int State { get; set; }


        public string GetApiName()
        {
            return "chenggou.game.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"title", Title},
                {"endtime", EndTime},
                {"description", Description},
                {"starttime", StartTime},
                {"detail", Detail},
                {"ext", Ext},
                {"maxtimes", MaxTimes},
                {"gametype", GameType},
                {"banner",Banner },
                {"state",State }
            };
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("starttime", StartTime);
            RequestValidator.ValidateRequired("endtime", EndTime);
            RequestValidator.ValidateRequired("title", Title);
            RequestValidator.ValidateRequired("gametype", GameType);
        }
    }
}
