/*
Copyright (c) 2012 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

#region Usings

using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

#endregion

namespace Yun.Util
{
    /// <summary>
    /// JSON serializer
    /// </summary>
    public class JsonSerializer
    {

        #region Functions

        /// <summary>
        /// Serializes the object
        /// </summary>
        /// <param name="Object">Object to serialize</param>
        /// <returns>The serialized object</returns>
        public static string Serialize(object Object)
        {
            //return JsonConvert.SerializeObject(Object);

            if (Object == null) return "";

            if (Object.GetType().FullName.Contains("<>f__AnonymousType"))
            {
                //匿名类型
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                return serializer.Serialize(Object);
            }

            using (var stream = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(Object.GetType());
                serializer.WriteObject(stream, Object);
                stream.Flush();
                return Encoding.UTF8.GetString(stream.GetBuffer(), 0, (int)stream.Position);
            }
        }

        /// <summary>
        /// Deserializes the data
        /// </summary>
        /// <param name="data">Data to deserialize</param>
        /// <returns>The resulting object</returns>
        public static T Deserialize<T>(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
                return default(T);

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(data)))
            {
                var serializer = new DataContractJsonSerializer(typeof (T));
                return (T) serializer.ReadObject(stream);
            }
        }

        #endregion
    }
}