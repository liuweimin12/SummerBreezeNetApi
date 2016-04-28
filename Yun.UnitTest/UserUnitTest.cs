using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yun.User.Request;
using Yun.Util;

namespace Yun.UnitTest
{
    [TestClass]
    public class UserUnitTest
    {
        [TestMethod]
        public void ResetFunctionsRequest()
        {
            var req = YunClient.Instance.Execute(new ResetFunctionsRequest {CompanyId = 3}, YunClient.GetAdminToken()).Result;
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
            //YunClient.Format = "json";

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
        public void PhoneDynamicLoginRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new PhoneDynamicLoginRequest
                {
                });

            Assert.IsTrue(req.UserId > 0);
        }
        [TestMethod]
        public void SendLoginCodePhoneRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new SendLoginCodePhoneRequest
                {
                    MobilePhone = "12345678996",
                    CompanyId = 123

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
                    Nick = "12345678996",
                    IsMale = 0,
                    Avatar = "",
                    Email = "",
                    Mobile = "",
                    RealName = "",
                    Birthday = DateTime.Now,
                    Province = "",
                    City = "",
                    Area = "",
                    Address = "",
                    Remark = "",
                    Phone = "",
                    IdCard = "",
                    
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
                    UserFlag = "12345678996",
                    CompanyId = 123456,
                    SendType = "ABC",
                    Target = "12345678996",
                    ActionName = "HELLO"

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
        public void PhoneRegisterRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new PhoneRegisterRequest()

                {
                    
                });

            Assert.IsTrue(req != null);
        }
        
       [TestMethod]
        public void GetUserRequest()
        {
            YunClient.Format = "json";
            var req =
                YunClient.Instance.Execute(new GetUserRequest()

                {

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

                });

            Assert.IsTrue(req != null);
        }
        
    }
}