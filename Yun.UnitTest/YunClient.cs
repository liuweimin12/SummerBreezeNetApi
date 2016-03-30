using System;
using System.Configuration;
using System.Linq;
using Yun.Interface;
using Yun.User.Request;

namespace Yun.UnitTest
{
    public static class YunClient
    {

        private static IYunClient _yunClient;
        private static object initLock = new object();
        private static readonly string _serverUrl = ConfigurationManager.AppSettings["ServerUrl"];
        private static readonly string _serverKey = ConfigurationManager.AppSettings["ServerKey"];
        private static readonly string _serverSecret = ConfigurationManager.AppSettings["ServerSecret"];

        private static readonly string _adminUser = ConfigurationManager.AppSettings["AdminUser"];
        private static readonly string _adminSecret = ConfigurationManager.AppSettings["AdminSecret"];

        public static string Format = "xml";

        public static string GetAdminToken()
        {
            return Instance.Execute(new LoginRequest
            {
                AppSecret = _serverSecret,
                Ip = "192.168.1.1",
                UserName = _adminUser,
                Password = _adminSecret
            }).Token;
        }


        public static string AppSecret
        {
            get { return _serverSecret; }
        }

        private static void Init()
        {
            if (_yunClient == null)
            {
                lock (initLock)
                {
                    if (_yunClient != null ) return;

                    if (new[] { _serverUrl, _serverKey, _serverUrl }.Any(string.IsNullOrWhiteSpace))
                    {
                        throw new Exception("服务端必要数据未初始化");
                    }

                    _yunClient = new DefaultYunClient(_serverUrl, _serverKey, _serverSecret, Format);
                }
            }
        }


        public static IYunClient Instance
        {
            get
            {
                Init();

                return _yunClient;
            }
        }

    }
}
