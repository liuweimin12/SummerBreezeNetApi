using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Jayrock.Json.Conversion;
using Yun.Parser;
using Yun.Response;

namespace Yun.Util
{
    /// <summary>
    /// TOP系统工具类。
    /// </summary>
    public abstract class TopUtils
    {
        public const string TOP_AUTH_URL = "http://container.open.taobao.com/container?authcode=";
        private static int GetRandomSeed()
        {
            var bytes = new byte[4];
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }

        /// <summary>
        /// 自定义随机字符串(其中可包含数字,符号,大小写字母)的生成方法.
        /// </summary>
        /// <param name="intLength">需要位数</param>
        /// <param name="booNumber">是否生成数字</param>
        /// <param name="booSign">是否生成符号</param>
        /// <param name="booSmallword">是否生成小写字母</param>
        /// <param name="booBigword">是否生成大写字母</param>
        /// <returns></returns>
        public static string GetRandomizer(int intLength, bool booNumber, bool booSign, bool booSmallword, bool booBigword)
        {
            var ranA = new Random(GetRandomSeed());
            var intResultRound = 0;
            var strB = "";
            while (intResultRound < intLength)
            {
                var intA = ranA.Next(1, 5);
                if (intA == 1 && booNumber)
                {
                    intA = ranA.Next(0, 10);
                    strB = intA + strB;
                    intResultRound = intResultRound + 1;
                    continue;
                }
                if (intA == 2 && booSign)
                {
                    intA = ranA.Next(1, 5);
                    if (intA == 1)
                    {
                        intA = ranA.Next(33, 48);
                        strB = ((char)intA).ToString(CultureInfo.InvariantCulture) + strB;
                        intResultRound = intResultRound + 1;
                        continue;
                    }
                    if (intA == 2)
                    {
                        intA = ranA.Next(58, 65);
                        strB = ((char)intA).ToString(CultureInfo.InvariantCulture) + strB;
                        intResultRound = intResultRound + 1;
                        continue;
                    }
                    if (intA == 3)
                    {
                        intA = ranA.Next(91, 97);
                        strB = ((char)intA) + strB;
                        intResultRound = intResultRound + 1;
                        continue;
                    }
                    if (intA == 4)
                    {
                        intA = ranA.Next(123, 127);
                        strB = ((char)intA) + strB;
                        intResultRound = intResultRound + 1;
                        continue;
                    }
                }
                if (intA == 3 && booSmallword)
                {
                    intA = ranA.Next(97, 123);
                    strB = ((char)intA) + strB;
                    intResultRound = intResultRound + 1;
                    continue;
                }
                if (intA == 4 && booBigword)
                {
                    intA = ranA.Next(65, 89);
                    strB = ((char)intA) + strB;
                    intResultRound = intResultRound + 1;
                }
            }
            return strB;
        }

        /// <summary>
        /// 给TOP请求签名。
        /// </summary>
        /// <param name="parameters">所有字符型的TOP请求参数</param>
        /// <param name="secret">签名密钥</param>
        /// <param name="encoding">加密编码</param>
        /// <returns>签名</returns>
        public static string SignTopRequest(IDictionary<string, string> parameters, string secret, string encoding)
        {
            return SignTopRequest(parameters, secret, false, encoding);
        }

        /// <summary>
        /// 给TOP请求签名。
        /// </summary>
        /// <param name="parameters">所有字符型的TOP请求参数</param>
        /// <param name="secret">签名密钥</param>
        /// <param name="qhs">是否前后都加密钥进行签名</param>
        /// <param name="encoding">加密编码</param>
        /// <returns>签名</returns>
        public static string SignTopRequest(IDictionary<string, string> parameters, string secret, bool qhs, string encoding)
        {
            // 第一步：把字典按Key的字母顺序排序
            IDictionary<string, string> sortedParams = new SortedDictionary<string, string>(parameters);
            var dem = sortedParams.GetEnumerator();

            // 第二步：把所有参数名和参数值串在一起
            var query = new StringBuilder(secret);
            while (dem.MoveNext())
            {
                var key = dem.Current.Key;
                var value = dem.Current.Value;
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    query.Append(key).Append(value);
                }
            }
            if (qhs)
            {
                query.Append(secret);
            }

            // 第三步：使用MD5加密
            var md5 = MD5.Create();
            var bytes = md5.ComputeHash(Encoding.GetEncoding(encoding).GetBytes(query.ToString()));

            // 第四步：把二进制转化为大写的十六进制
            var result = new StringBuilder();
            foreach (var t in bytes)
            {
                result.Append(t.ToString("X2"));
            }
            return result.ToString();
        }

        public static string MD5Hash(string input)
        {
            // 第三步：使用MD5加密
            var md5 = MD5.Create();
            var bytes = md5.ComputeHash(Encoding.GetEncoding("UTF-8").GetBytes(input));

            // 第四步：把二进制转化为大写的十六进制
            var result = new StringBuilder();
            foreach (var t in bytes)
            {
                result.Append(t.ToString("X2"));
            }
            return result.ToString();
        }

        /// <summary>
        /// 验证回调地址的签名是否合法。
        /// </summary>
        /// <param name="callbackUrl">回调地址</param>
        /// <param name="appSecret">应用密钥</param>
        /// <returns>验证成功返回True，否则返回False</returns>
        public static bool VerifyTopResponse(string callbackUrl, string appSecret)
        {
            Uri uri = new Uri(callbackUrl);

            string query = uri.Query;
            if (string.IsNullOrEmpty(query)) // 没有回调参数
            {
                return false;
            }

            query = query.Trim(new char[] { '?', ' ' });
            if (query.Length == 0) // 没有回调参数
            {
                return false;
            }

            IDictionary<string, string> queryDict = SplitUrlQuery(query);
            string topParams;
            queryDict.TryGetValue("top_parameters", out topParams);
            string topSession;
            queryDict.TryGetValue("top_session", out topSession);
            string topSign;
            queryDict.TryGetValue("top_sign", out topSign);
            string appKey;
            queryDict.TryGetValue("top_appkey", out appKey);

            topSign = (topSign == null ? null : Uri.UnescapeDataString(topSign));
            return VerifyTopResponse(topParams, topSession, topSign, appKey, appSecret);
        }

        /// <summary>
        /// 验证回调地址的签名是否合法。要求所有参数均为已URL反编码的。
        /// </summary>
        /// <param name="topParams">TOP私有参数（未经BASE64解密后的）</param>
        /// <param name="topSession">TOP私有会话码</param>
        /// <param name="topSign">TOP回调签名（经过URL反编码的）</param>
        /// <param name="appKey">应用公钥</param>
        /// <param name="appSecret">应用密钥</param>
        /// <returns>验证成功返回True，否则返回False</returns>
        public static bool VerifyTopResponse(string topParams, string topSession, string topSign, string appKey, string appSecret)
        {
            StringBuilder result = new StringBuilder();
            result.Append(appKey).Append(topParams).Append(topSession).Append(appSecret);
            byte[] bytes = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(result.ToString()));
            return Convert.ToBase64String(bytes) == topSign;
        }

        /// <summary>
        /// 获取TOP容器回调上下文，主要用于客户端应用。
        /// </summary>
        /// <param name="authCode">授权码</param>
        /// <returns>TOP容器上下文</returns>
        public static TopContext GetTopContext(string authCode)
        {
            var url = TOP_AUTH_URL + authCode;
            var wu = new WebUtils();
            var rsp = wu.DoGet(url, null);
            if (string.IsNullOrEmpty(rsp))
            {
                return null;
            }

            var context = new TopContext();
            var paramEnum = SplitUrlQuery(rsp).GetEnumerator();
            while (paramEnum.MoveNext())
            {
                if ("top_parameters".Equals(paramEnum.Current.Key))
                {
                    context.AddParameters(DecodeTopParams(paramEnum.Current.Value));
                }
                else
                {
                    context.AddParameter(paramEnum.Current.Key, paramEnum.Current.Value);
                }
            }

            return context;
        }

        /// <summary>
        /// 解释TOP回调参数为键值对（采用GBK字符集编码）。
        /// </summary>
        /// <param name="topParams">经过BASE64和URL编码的字符串</param>
        /// <returns>键值对</returns>
        public static IDictionary<string, string> DecodeTopParams(string topParams)
        {
            return DecodeTopParams(topParams, Encoding.GetEncoding("GBK"));
        }

        /// <summary>
        /// 解释TOP回调参数为键值对。
        /// </summary>
        /// <param name="topParams">经过BASE64和URL编码的字符串</param>
        /// <param name="encoding">字符集编码</param>
        /// <returns>键值对</returns>
        public static IDictionary<string, string> DecodeTopParams(string topParams, Encoding encoding)
        {
            if (string.IsNullOrEmpty(topParams))
            {
                return null;
            }
            var buffer = Convert.FromBase64String(Uri.UnescapeDataString(topParams));
            var originTopParams = encoding.GetString(buffer);
            return SplitUrlQuery(originTopParams);
        }

        private static IDictionary<string, string> SplitUrlQuery(string query)
        {
            IDictionary<string, string> result = new Dictionary<string, string>();

            var pairs = query.Split(new[] { '&' });
            if (pairs.Length <= 0) return result;

            foreach (
                var oneParam in
                    pairs.Select(pair => pair.Split(new[] {'='}, 2)).Where(oneParam => oneParam.Length == 2))
            {
                result.Add(oneParam[0], oneParam[1]);
            }

            return result;
        }

        /// <summary>
        /// 清除字典中值为空的项。
        /// </summary>
        /// <param name="dict">待清除的字典</param>
        /// <returns>清除后的字典</returns>
        public static IDictionary<string, T> CleanupDictionary<T>(IDictionary<string, T> dict)
        {
            IDictionary<string, T> newDict = new Dictionary<string, T>(dict.Count);
            var dem = dict.GetEnumerator();

            while (dem.MoveNext())
            {
                var name = dem.Current.Key;
                var value = dem.Current.Value;
                if (value != null)
                {
                    newDict.Add(name, value);
                }
            }

            return newDict;
        }

        /// <summary>
        /// 获取文件的真实后缀名。目前只支持JPG, GIF, PNG, BMP四种图片文件。
        /// </summary>
        /// <param name="fileData">文件字节流</param>
        /// <returns>JPG, GIF, PNG or null</returns>
        public static string GetFileSuffix(byte[] fileData)
        {
            if (fileData == null || fileData.Length < 10)
            {
                return null;
            }

            if (fileData[0] == 'G' && fileData[1] == 'I' && fileData[2] == 'F')
            {
                return "GIF";
            }
            else if (fileData[1] == 'P' && fileData[2] == 'N' && fileData[3] == 'G')
            {
                return "PNG";
            }
            else if (fileData[6] == 'J' && fileData[7] == 'F' && fileData[8] == 'I' && fileData[9] == 'F')
            {
                return "JPG";
            }
            else if (fileData[0] == 'B' && fileData[1] == 'M')
            {
                return "BMP";
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取文件的真实媒体类型。目前只支持JPG, GIF, PNG, BMP四种图片文件。
        /// </summary>
        /// <param name="fileData">文件字节流</param>
        /// <returns>媒体类型</returns>
        public static string GetMimeType(byte[] fileData)
        {
            string suffix = GetFileSuffix(fileData);
            string mimeType;

            switch (suffix)
            {
                case "JPG": mimeType = "image/jpeg"; break;
                case "GIF": mimeType = "image/gif"; break;
                case "PNG": mimeType = "image/png"; break;
                case "BMP": mimeType = "image/bmp"; break;
                default: mimeType = "application/octet-stream"; break;
            }

            return mimeType;
        }

        /// <summary>
        /// 根据文件后缀名获取文件的媒体类型。
        /// </summary>
        /// <param name="fileName">带后缀的文件名或文件全名</param>
        /// <returns>媒体类型</returns>
        public static string GetMimeType(string fileName)
        {
            string mimeType;
            fileName = fileName.ToLower();

            if (fileName.EndsWith(".bmp", StringComparison.CurrentCulture))
            {
                mimeType = "image/bmp";
            }
            else if (fileName.EndsWith(".gif", StringComparison.CurrentCulture))
            {
                mimeType = "image/gif";
            }
            else if (fileName.EndsWith(".jpg", StringComparison.CurrentCulture) || fileName.EndsWith(".jpeg", StringComparison.CurrentCulture))
            {
                mimeType = "image/jpeg";
            }
            else if (fileName.EndsWith(".png", StringComparison.CurrentCulture))
            {
                mimeType = "image/png";
            }
            else
            {
                mimeType = "application/octet-stream";
            }

            return mimeType;
        }

        /// <summary>
        /// 根据API名称获取响应根节点名称。
        /// </summary>
        /// <param name="api">API名称</param>
        /// <returns></returns>
        public static string GetRootElement(string api)
        {
            int pos = api.IndexOf(".");
            if (pos != -1 && api.Length > pos)
            {
                api = api.Substring(pos + 1).Replace('.', '_');
            }
            return api + "_response";
        }

        /// <summary>
        /// 把JSON解释为字典结构。
        /// </summary>
        /// <param name="json">JSON字符串</param>
        /// <returns>字典</returns>
        public static IDictionary ParseJson(string json)
        {
            return JsonConvert.Import(json) as IDictionary;
        }

        /// <summary>
        /// 把JSON解释为API响应对象。
        /// </summary>
        /// <typeparam name="T">API响应类型</typeparam>
        /// <param name="json">JSON字符串</param>
        /// <returns>API响应对象</returns>
        public static T ParseResponse<T>(string json) where T : YunResponse
        {
            var parser = new TopJsonParser();
            return parser.Parse<T>(json);
        }

        /// <summary>
        /// 获取从1970年1月1日到现在的毫秒总数。
        /// </summary>
        /// <returns>毫秒数</returns>
        public static long GetCurrentTimeMillis()
        {
            return (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
        }

        private const string AES_SECRET = "bf1*22f^e9873e49";

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="str">要加密字符串</param>
        /// <param name="key"></param>
        /// <returns>返回加密后字符串</returns>
        public static string EncryptAes(string str, string key)
        {
            if (new[] {str, key}.Any(string.IsNullOrWhiteSpace))
                return "";

            if (key.Length > 16)
            {
                key = key.Substring(0, 16);
            }

            var toEncryptArray = Encoding.UTF8.GetBytes(str);

            var rDel = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                IV = Encoding.UTF8.GetBytes(AES_SECRET),
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };

            var cTransform = rDel.CreateEncryptor();
            var resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length).Replace('+', '*')
                .Replace('/', '-')
                .Replace('=', '.');
        }
    }
}
