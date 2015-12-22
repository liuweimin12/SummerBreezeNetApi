using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yun.Domain;
using Yun.Response;

namespace Yun.Shop.Response
{
    public class LongResponse : YunResponse
    {
        public LongKeyValuePair result { get; set; }
    }
}
