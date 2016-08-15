using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.User.Request;
using Yun.Util;

namespace Yun.UnitTest
{
    [TestClass]
    public class UserUnitTest
    {

        //[TestMethod]
        //public void ResetPasswordRequest()
        //{
        //    var reqCode =
        //        YunClient.Instance.Execute(new SendVerificationCodeRequest
        //        {
        //            SendType = "SMS",
        //            Target = "18606683125",
        //            ActionName = "用户注册",
        //            UserFlag = "18606683125"
        //        }).Result;

        //    var resetReq = YunClient.Instance.Execute(new ResetPasswordRequest
        //    {
        //        AppSecret = YunClient.AppSecret,
        //        Code = reqCode,
        //        Password = "123456",
        //        Phone = "18606683125",
        //        UserFlag = "18606683125"
        //    });

        //    if (!resetReq.Result)
        //    {
        //        Assert.Fail("修改密码失败");
        //    }

        //    var loginReq = YunClient.Instance.Execute(new LoginRequest
        //    {
        //        AppSecret = YunClient.AppSecret,
        //        Password = "111111",
        //        Ip = "192.168.1.1",
        //        UserName = "18606683125"
        //    });

        //    Assert.IsTrue(loginReq.UserId > 0);
        //}

        [TestMethod]
        public void GetFunctionsRequest()
        {
            var req =
                YunClient.Instance.Execute(
                    new GetFunctionsRequest {OnlyShowDisplay = true, CompanyId = 100, FunctionType = 0},
                    YunClient.GetAdminToken());

            Assert.IsTrue(req.Functions.All(e => e.Type == 0));
        }

        [TestMethod]
        public void ResetFunctionsRequest()
        {
            var req =
                YunClient.Instance.Execute(new ResetFunctionsRequest {CompanyId = 100, TypeId = 1},
                    YunClient.GetAdminToken()).Result;
            Assert.IsTrue(req);
        }

        [TestMethod]
        public void FileUploadRequest()
        {
            var req = YunClient.Instance.Execute(new FileUploadRequest
            {
                Images = new List<FileItem>
                {
                    new FileItem(@"c:\1.png")
                }
            });

            Assert.IsTrue(req.Files!=null);
        }

        [TestMethod]
        public void GerPermissionUserRequest()
        {
            var req = YunClient.Instance.Execute(new GerPermissionUserRequest { Id = 172586 }, YunClient.GetAdminToken());
            Assert.IsTrue(req.User != null);
        }

        [TestMethod]
        public void LoginRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new LoginRequest
                {
                    UserName = "18606683125",
                    Password = "111111",
                    
                    AppSecret = YunClient.AppSecret
                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ResetPasswordRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new ResetPasswordRequest
                {
                    Password = "111111",
                    AppSecret = YunClient.AppSecret,
                    Phone = "18606683125",
                    Code = "737717",

                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void SendVerificationCodeRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new SendVerificationCodeRequest
                {
                   UserFlag = "18606683125",
                   ActionName = "用户注册",
                   SendType = "SMS",
                   Target = "18606683125",
                  
                });

            Assert.IsTrue(req != null);
        }
        
        [TestMethod]
        public void LoginMobilePhoneRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new LoginMobilePhoneRequest
                {
                    Code = "737717",
                    IsDestroy = false,
                    UserFlag = "18606683125"
                });

            Assert.IsTrue(req != null);
        }


        [TestMethod]
        public void AddEmployeeRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new AddEmployeeRequest
                {
                    UserName = "AA",
                    AppSecret = YunClient.AppSecret,
                    Password = "888999",
                 
                });

           Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddRoleRequest
()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new AddRoleRequest

                {
                    RoleType = 123,
                    CompanyId = 001,
                    Description = "miaoshu",
                    Name = "xx",
                    ShopId = 002,
                    Sort = 0.1
                }, YunClient.GetAdminToken());

            Assert.IsTrue(req.Result > 0);
        }
        [TestMethod]
        public void InquiryVerificationCodeRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new InquiryVerificationCodeRequest
                {
                    Code = "911345",
                    UserFlag = "15300081556"

                });

            Assert.IsTrue(req != null);
        }
        
        /// <summary>
        /// /手机验证码登陆
        /// </summary>
        [TestMethod]
        public void PhoneDynamicLoginRequest()
        {
            YunClient.Format = "json";

            var sendReq =
                YunClient.Instance.Execute(new SendLoginCodePhoneRequest
                {
                    MobilePhone = "18606683125"
                });

            var req =
                YunClient.Instance.Execute(new PhoneDynamicLoginRequest
                {
                    Ip = "192.168.1.2",
                    Phone = "18606683125",
                    Code = "737717",
                   
                });

            Assert.IsTrue(req.UserId>0);
        }
        /// <summary>
        /// 发送验证码
        /// </summary>
        [TestMethod]
        public void SendLoginCodePhoneRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SendLoginCodePhoneRequest
                {
                    MobilePhone = "18606683125",
                    CompanyId = null
                });

            Assert.IsTrue(req != null);
        }
        /// <summary>
        /// 修改用户个人资料
        /// </summary>
        [TestMethod]
        public void ModifyUserInfoRequest()
        {
            YunClient.Format = "xml";

            var loginReq = YunClient.Instance.Execute(new LoginRequest
                {
                UserName = "15662414748",
                IgnorePassword = true,
                Ip = "192.168.1.1",
                AppSecret = YunClient.AppSecret
            }).Token;

            var user = YunClient.Instance.Execute(new GetUserRequest(), loginReq);

            var req =
                YunClient.Instance.Execute(new ModifyUserInfoRequest
                {
                    //IdCard = "11111",
                    Nick = "AMY",
                    //IsMale = 1
                }, loginReq);

            Assert.IsTrue(req != null);
        }

        //[TestMethod]
        //public void SendVerificationCodeRequest()
        //{
        //    YunClient.Format = "xml";

        //    //var loginReq = YunClient.Instance.Execute(new LoginRequest
        //    //{
        //    //    UserName = "15958805628",
        //    //    IgnorePassword = true,
        //    //    Ip = "192.168.1.1",
        //    //    AppSecret = YunClient.AppSecret
        //    //}).Token;

        //    var req =
        //        YunClient.Instance.Execute(new SendVerificationCodeRequest
        //        {
        //            SendType = "EMAIL",
        //            Target = "tianzhongluan@163.com",
        //            ActionName = "发送验证码",
        //            UserFlag = "15958805628"

        //        });

        //    Assert.IsTrue(req != null);
        //}

        [TestMethod]
        public void ModifyPasswordRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyPasswordRequest()

                {
                    Password = "12345678996",
                    NewPassword = "123456789",
                    AppSecret = YunClient.AppSecret
                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ModifyPasswordUserRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyPasswordUserRequest()

                {
                    Id = 172586,
                    Password = "12345678996",
                    
                });

            Assert.IsTrue(req != null);
        }
        
        [TestMethod]
        public void ModifyUserCreditRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyUserCreditRequest()

                {
                    UserNick = null,
                    Credit = 1,
                    ExpiredDay = 1,
                    Remark = null,
                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void ModifyUserMoneyRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyUserMoneyRequest()

                {
                    UserNick = "13521127648",
                    UserId = 52049,
                    AllowNegative =false,
                    Ip = "192.168.1.127",
                    Money = 100,
                    Remark = null,
             
                });

            Assert.IsTrue(req != null);
        }
        
        [TestMethod]
        public void PhoneRegisterRequest()
        {
            var mobile = "15958805615";

            YunClient.Format = "json";

            var phoneReq =
                YunClient.Instance.Execute(new SendVerificationCodeRequest
                {
                    SendType = "SMS",
                    Target = mobile,
                    ActionName = "用户注册",
                    UserFlag = mobile
                });

            var req =
                YunClient.Instance.Execute(new PhoneRegisterRequest
                {
                    Ip = "192.168.1.1",
                    Code = "361896",
                    Password = "123",
                    Phone = "13521127643",
                    Secret = YunClient.AppSecret,
                    UserFlag = "13521127643"
                });

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetUserRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetUserRequest()
                {
                    Nick = "AMY",
                });

            Assert.IsTrue(string.IsNullOrEmpty(req.User.Mobile));
        }
        [TestMethod]
        public void LoginOauth2Request()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new LoginOauth2Request()
                 {
                    NickName = null,
                    OAuthId = "1",
                    Avatar = null,
                    Email = "1805768571@qq.com",
                    Ip = "192.168.1.1",
                    OAuth2Type = "1",
                    Phone = "18606683125",
                    RealName = null,
                    ShopId = 1,
                    UserMeta = null,
                });
          Assert.IsTrue(req != null);

        }
        [TestMethod]
        public void RegisterRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new RegisterRequest()
                {
                    ShopId=1,
                    CompanyId=1,
                    UserName="tt",
                    Ip="192.168.1.1",
                    Mobile = "18606683125",
                    Password = "111111",
                    Address = "宁波",
                    Email = "1805768571@qq.com",
                    AppSecret=YunClient.AppSecret,
                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BindOauth2AccountRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new BindOauth2AccountRequest()

                {
                    OAuthId = "1",
                    OAuth2Type = "1",
                    UserId = 1,
                    UserMeta = null,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BindEmailRequest()
        {
            YunClient.Format = "json";
          
            var req =
                YunClient.Instance.Execute(new BindEmailRequest()

                {
                    Email = "1805768571@qq.com",
                    Code = "879417"
                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void BindPhoneRequest()
        {
            YunClient.Format = "json";
            var loginReq = YunClient.Instance.Execute(new LoginRequest
            {
                UserName = "18606683125",
                IgnorePassword = true,
                Ip = "192.168.1.1",
                AppSecret = YunClient.AppSecret
            }).Token;
            var req =
                YunClient.Instance.Execute(new BindPhoneRequest()
               {
                    Phone = "18606683125",
                    Code = "422647"
                }, loginReq);
            Assert.IsTrue(req.Result);
        }

        [TestMethod]
        public void AuthSessionRequest()
        {
            var req =
                YunClient.Instance.Execute(new LoginRequest
                {
                    UserName = "宁波人保分公司",
                    Password = "888999",
                    Ip = "192.168.1.1",
                    AppSecret = YunClient.AppSecret
                });

            var authReq = YunClient.Instance.Execute(new AuthSessionRequest(), req.Token);

            Assert.IsTrue(authReq.UserId > 0);
        }

        [TestMethod]
        public void UnbindEmailRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new UnbindEmailRequest()

                {
                    Code = "1"

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void UnbindPhoneRequest()
        {
            YunClient.Format = "json";

            var loginReq = YunClient.Instance.Execute(new LoginRequest
            {
                UserName = "15958805628",
                IgnorePassword = true,
                Ip = "192.168.1.1",
                AppSecret = YunClient.AppSecret
            }).Token;

            
            var req =
                YunClient.Instance.Execute(new UnbindPhoneRequest()
                {
                    Code = "056632",
                }, loginReq);
            Assert.IsTrue(req.Result);
        }

        [TestMethod]
        public void UploadAvatarUserRequest()
        {
            YunClient.Format = "json";

            var loginReq = YunClient.Instance.Execute(new LoginRequest
            {
                UserName = "15958805628",
                IgnorePassword = true,
                Ip = "192.168.1.1",
                AppSecret = YunClient.AppSecret
            }).Token;

            var req = YunClient.Instance.Execute(new UploadAvatarUserRequest {Image = new FileItem(@"C:\finally.png") }, loginReq);
            Assert.IsTrue(req.Result);
        }
        [TestMethod]
        public void ApplyRealNameAuthenticationRequest()
        {
            YunClient.Format = "json";
            var loginReq =
                YunClient.Instance.Execute(new LoginRequest
                {
                    UserName = "18606683125",
                    Password = "111111",

                    AppSecret = YunClient.AppSecret
                }).Token;
           
            var req =
                YunClient.Instance.Execute(new ApplyRealNameAuthenticationRequest()

                {
                   AuthenticationName = "kity",
                   IdCard = "123456",
                   PositiveIdentityCard = "1",
                   BackOfIdCard = "2",
                   IdCardHandheld = "3"
                },loginReq);
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void RefuseRealNameAuthenticationRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new RefuseRealNameAuthenticationRequest()

                {
                    UserId = 1,
                    Reason = "不符和规章"
                    
                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void PassRealNameAuthenticationRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new PassRealNameAuthenticationRequest()

                {
                    UserId = 1,
                    

                }, YunClient.GetAdminToken());
            Assert.IsTrue(req != null);
        }
        

    }
}