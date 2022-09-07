using System;
using Newtonsoft.Json;
using System.Collections.Generic;
//C#类库项目没有启动项，需要在类库项目中引入一个可启动项。并将其设为启动项
namespace ClassLibrary_CSharpTest
{
    
    public class Class1:Student//继承  基类
    {
        List<Student> slst;
        public Class1() 
        {
            slst = new List<Student>();
            this.sGender = "male";
            this.sName = "Mike";
            this.sHobby = "网球";
            Student std = new Student();
            std.sGender = this.sGender;
            std.sHobby = this.sHobby;
            std.sName = this.sName;
            slst.Add(std);
           // string sJSON = Newtonsoft.Json.JsonConvert.SerializeObject(slst);
            Console.WriteLine(slst);
        }   
        public string CallPid()//public封装使得该方法在别的类中可以调用
        {
            string sRetValue;
            string sJSON = Newtonsoft.Json.JsonConvert.SerializeObject(this.slst);
            var data = new MessageTag()
            {
                sRet01 = "1",
                sRet02 = "2",
                sRet03 = "3",
                sRet04 = "4",
                sRet05 = "5",
                sRet06 = "6",
                sRet07 = "7",
                sRet08 = "8",
                sRet09 = "9",
                sRet10 = "10",
                FYXData = sJSON,
            };
            sRetValue = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            return sRetValue;
        }
    } 
}
