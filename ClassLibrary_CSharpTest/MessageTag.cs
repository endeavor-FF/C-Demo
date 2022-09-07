using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ClassLibrary_CSharpTest
{
    public class MessageTag
    {
        //消息标识
        [JsonProperty("MFlag")]//Newtonsoft.Json库中方法
        public string sRet01 { get; set; }
        public string sRet02 { get; set; }
        public string sRet03 { get; set; }
        public string sRet04 { get; set; }

        public string sRet05 { get; set; }
        public string sRet06 { get; set; }
        public string sRet07 { get; set; }
        public string sRet08 { get; set; }
        public string sRet09 { get; set; }
        public string sRet10 { get; set; }
        //消息标识描述

        public string FYXData { get; set; }

    }
}
