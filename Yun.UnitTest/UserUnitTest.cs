using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.Shop.Request;
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
                YunClient.Instance.Execute(new ResetFunctionsRequest {CompanyId = 0, TypeId = 0},
                    YunClient.GetAdminToken()).Result;
            Assert.IsTrue(req);
        }

        /// <summary>
        /// 上传图片
        /// </summary>
        [TestMethod]
        public void FileUploadRequest()
        {
            var req = YunClient.Instance.Execute(new FileUploadRequest
            {
                Images = new List<FileItem>
                {
                    new FileItem(@"F:\1.jpg"),

                }
            });

            Assert.IsTrue(req.Files != null);
        }

        [TestMethod]
        public void GerPermissionUserRequest()
        {
            var req = YunClient.Instance.Execute(new GerPermissionUserRequest {Id = 172586}, YunClient.GetAdminToken());
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
                    Password = "128128",

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
                    Password = "128128",
                    AppSecret = YunClient.AppSecret,
                    Phone = "18606683125",
                    Code = "205407",

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
                    Code = "040541",
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
                    Code = "040541",

                });

            Assert.IsTrue(req.UserId > 0);
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

        /// <summary>
        /// 修改用户金额
        /// </summary>
        [TestMethod]
        public void ModifyUserMoneyRequest()
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
                YunClient.Instance.Execute(new ModifyUserMoneyRequest()

                {
                    UserNick = "18606683125",
                    Money = 10000,
                }, loginReq);

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

        /// <summary>
        /// 获取用户信息
        /// </summary>

        [TestMethod]
        public void GetUserRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetUserRequest()
                {

                    UserId = 176848

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
                    ShopId = 11618,
                    CompanyId = 115,
                    UserName = "tt",
                    UserType = 1,
                    Ip = "192.168.1.1",
                    Mobile = "15662414749",
                    Password = "111111",
                    Address = "宁波市高新区杨帆路999号",
                    Email = "1805768571@qq.com",
                    AppSecret = YunClient.AppSecret,
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

            var authReq = YunClient.Instance.Execute(new UserAuthRequest(), req.Token);

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

            var req = YunClient.Instance.Execute(new UploadAvatarUserRequest {Image = new FileItem(@"C:\finally.png")},
                loginReq);
            Assert.IsTrue(req.Result);
        }

        /// <summary>
        /// 实名认证
        /// </summary>
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
                    IdCard = "37082719920101",
                    PositiveIdentityCard = "http://f.icgyun.com/s/52510/g/155902-68869-383x685.jpg",
                    BackOfIdCard = "http://f.icgyun.com/s/52510/g/32821-68870-670x376.jpg",
                    IdCardHandheld = "http://f.icgyun.com/s/52510/g/127457-68871-331x468.jpg"
                }, loginReq);
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

        [TestMethod]
        public void FindUsersRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new FindUsersRequest()

                {
                    PageSize = 10,
                    PageNum = 1,


                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void UserAuthRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new UserAuthRequest()

                {
                    Password = "111111",
                    AppSecret = YunClient.AppSecret,


                });
            Assert.IsTrue(req != null);
        }

        /// <summary>
        /// 创建公司和店铺
        /// </summary>
        [TestMethod]
        public void CreateCompanyAndShop()
        {
            //注册用户
            var regReq = YunClient.Instance.Execute(new RegisterRequest
            {
                UserName = "temp_user_" + new Random().Next(1, 99999),
                Ip = "192.168.1.1",
                Mobile = "159588023" + new Random().Next(1, 99),
                Password = "888999",
                Address = "宁波市高新区杨帆路999号",
                Email = "1805768" + new Random().Next(1, 99) + "@qq.com",
                AppSecret = YunClient.AppSecret,
            });

            if (regReq.UserId > 0)
            {
                //注册公司
                var comReq = YunClient.Instance.Execute(new AddCompanyRequest
                {
                    Name = "测试公司" + new Random().Next(1, 9999),
                    BindUserId = (int) regReq.UserId
                }, regReq.Token);

                if (comReq.Result > 0)
                {
                    //注册主店铺-虚拟店铺
                    var shopReq = YunClient.Instance.Execute(new AddShopRequest
                    {
                        Name = "测试店铺" + new Random().Next(1, 9999),
                        CompanyId = (int) comReq.Result
                    }, regReq.Token);

                    //新增子店铺
                    if (shopReq.Result > 0)
                    {
                        var childShopReq = YunClient.Instance.Execute(new AddShopRequest
                        {
                            Name = "测试子店铺" + new Random().Next(1, 9999),
                            ShopType = 1,
                            ParentId = (int) shopReq.Result
                        }, regReq.Token);

                        Assert.IsTrue(childShopReq.Result > 0);
                        return;
                    }
                }
            }

            Assert.Fail();
        }

        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        [TestMethod]
        public void ExistUserRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new ExistUserRequest()

                {
                    Content = "18606683125",
                    Type = 1


                });
            Assert.IsTrue(req != null);

        }
        /// <summary>
        /// 移除好友关系
        /// </summary>
        [TestMethod]
        public void RemoveFriendRelationshipsRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new RemoveFriendRelationshipsRequest()
                {
                TargetUserId =12352,


                });
            Assert.IsTrue(req != null);

        }
        /// <summary>
        /// 建立朋友的关系，对方必须已经注册
        /// </summary>
        [TestMethod]
        public void BuildFriendRelationshipsRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new BuildFriendRelationshipsRequest()
                {
                   TargetUserIds = "",
                   TargetUserName = "手机号",
                   TargetUserType = 2,
                   UserId = 12345,


                });
            Assert.IsTrue(req != null);

        }
        /// <summary>
        /// 建立朋友的关系，对方必须已经注册
        /// </summary>
        [TestMethod]
        public void GetUserFriendsRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new GetUserFriendsRequest()
                {
                   PageNum = 10,
                   PageSize = 10,


                });
            Assert.IsTrue(req != null);

        }
        


    }
}