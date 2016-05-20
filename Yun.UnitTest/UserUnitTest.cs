using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.User.Request;
using Yun.Util;
using Yun.Item.Request;

namespace Yun.UnitTest
{
    [TestClass]
    public class UserUnitTest
    {
        [TestMethod]
        public void ResetFunctionsRequest()
        {
            var req = YunClient.Instance.Execute(new ResetFunctionsRequest { CompanyId = 3 }, YunClient.GetAdminToken()).Result;
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

            Assert.IsTrue(req.Files != null);
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
                    UserName = "宁波雨辰环保旗舰店",
                    Password = "888999",
                    Ip = "192.168.1.1",
                    AppSecret = YunClient.AppSecret
                });

            Assert.IsTrue(req.UserId > 0);
        }
        [TestMethod]
        public void LoginMobilePhoneRequest()
        {
            YunClient.Format = "json";

            var req =
                YunClient.Instance.Execute(new LoginMobilePhoneRequest
                {
                    Code = "879417",
                    CompanyId = 3,
                    IsDestroy = true,
                    UserFlag = null
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
        public void PhoneDynamicLoginRequest()
        {
            YunClient.Format = "xml";
            var req =
                YunClient.Instance.Execute(new PhoneDynamicLoginRequest
                {
                    Ip = "192.168.1.1",
                    Phone = "18606683125",
                    Code = "879417",
                    ShopId = 1,
                    CompanyId = 3,
                });

            Assert.IsTrue(req != null);
        }

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

        [TestMethod]
        public void ModifyUserInfoRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new ModifyUserInfoRequest()

                {
                    Nick = "宁波雨辰环保旗舰店",
                    IsMale = 0,
                    Avatar = null,
                    Email = null,
                    Mobile = null,
                    RealName = null,
                    Birthday = DateTime.Now,
                    Province = null,
                    City = null,
                    Area = null,
                    Address = null,
                    Remark = null,
                    Phone = null,
                    IdCard = null,
                });

            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void SendVerificationCodeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SendVerificationCodeRequest()

                {
                    UserFlag = null,
                    CompanyId = 3,
                    SendType = "email",
                    Target = "1805768571@qq.com",
                    ActionName = "密码找回"

                });

            Assert.IsTrue(req != null);
        }
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
                    UserNick = null,
                    UserId = 1,
                    AllowNegative = true,
                    Ip = "192.168.1.1",
                    Money = 0.1,
                    Remark = null,


                });

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void PhoneRegisterRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new PhoneRegisterRequest()

                {
                    Ip = "192.168.1.1",
                    Address = "gaoxinqu",
                    Area = "china",
                    City = "ningbo",
                    Code = null,
                    CompanyId = 3,
                    IdCard = "199202061644",
                    Password = "123",
                    Phone = "18606683125",
                    Province = null,
                    Secret = YunClient.AppSecret,
                    ShopId = 1,
                    UserFlag = "flag"
                }, YunClient.GetAdminToken());

            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void GetUserRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetUserRequest()
                {

                    UserId = 52510,

                });

            Assert.IsTrue(req != null);
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
                    ShopId = 1,
                    CompanyId = 3,
                    UserName = "lily",
                    Ip = "192.168.1.1",
                    AppSecret = YunClient.AppSecret,
                    SystemLevel = 1,
                    Password = "123",
                    RegisterType = 0,
                    Email = null,
                    Mobile = "18606683125",
                    SiteName = null,
                    IdCard = null,
                    Province = null,
                    City = null,
                    Area = null,
                    Address = null,
                    RealName = null,



                });
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
                    Code = "1"

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BindPhoneRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new BindPhoneRequest()
                {
                    Phone = "1860668215",
                    Code = "0"

                });
            Assert.IsTrue(req != null);
        }

        [TestMethod]
        public void AuthSessionRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AuthSessionRequest()

                {

                });
            Assert.IsTrue(req != null);
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
            var req =
                YunClient.Instance.Execute(new UnbindPhoneRequest()

                {
                    Code = "1",

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void UploadAvatarUserRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new UploadAvatarUserRequest()

                {
                    Image = new FileItem(@"c:\1.png")
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void InquiryVerificationCodeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new InquiryVerificationCodeRequest()

                {
                    Code = "56578",
                    Isdestroy = true,
                    CompanyId = 1,
                    UserFlag = null,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddAlumbsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddAlumbsRequest()

                {
                    Type = 1,
                    ObjectId = 1,

                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddFunctionRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddFunctionRequest()

                {
                    Name = "lily",
                    Sort = 1,
                    ParentId = 1,
                    Url = null,
                    Description = null,
                    Display = true,
                    AllowBlock = null,
                    Type = 1,
                    Image = null,
                    CompanyId = 3,


                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddRelationOrganizationRoleRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddRelationOrganizationRoleRequest()
                {
                    OrganizationId = 1,
                    RoleIds = "1",
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddRelationRoleFunctionRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddRelationRoleFunctionRequest()
                {
                    FunctionIds = "1",
                    RoleId = 1,
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AddUserTagRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AddUserTagRequest()
                {
                  TagName="xx"
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AllowFunctionRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AllowFunctionRequest()
                {
                    Url=null,
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AnalogShopLoginRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AnalogShopLoginRequest()
                {
                    ShopId=1,
                    ShopName="xx"
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void AssociatedUserTagsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new AssociatedUserTagsRequest()
                {
                    UserNick="xx",
                    TagId=1
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BatchAssociatedUserTagsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new BatchAssociatedUserTagsRequest()
                {
                    UserNick = "xx",
                    TagId = 1
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BatchUpdateFunctionSortRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new BatchUpdateFunctionSortRequest()
                {
                   Sort=null
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void BatchUpdateOrganizationRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new BatchUpdateOrganizationRequest()
                {
                    Sort = null
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteAlumbsRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new DeleteAlumbsRequest()
                {
                   Ids=null,
                   ObjectId=1,
                   Type=1,
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteEmployeeRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new DeleteEmployeeRequest()
                {
                    Id=1
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteFunctionRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new DeleteFunctionRequest()
                {
                    Id = 1
                });
            Assert.IsTrue(req != null);
        }
        [TestMethod]
        public void DeleteOrganizationRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new DeleteOrganizationRequest()
                {
                    Id = 1
                });
            Assert.IsTrue(req != null);
        }
        


    }
}