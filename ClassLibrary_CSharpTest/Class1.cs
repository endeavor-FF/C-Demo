using System;
using Newtonsoft.Json;
using System.Collections.Generic;
//C#类库项目没有启动项，需要在类库项目中引入一个可启动项。并将其设为启动项
namespace ClassLibrary_CSharpTest
{
    public class Class1:Student//继承  基类
    {
        List<Student> slst;//创建一个对象
        public Class1() 
        {
            slst = new List<Student>();//对象实例化
            this.sGender = "male";
            this.sName = "Mike";
            this.sHobby = "网球";
            Student std = new Student();
            std.sGender = this.sGender;
            std.sHobby = this.sHobby;
            std.sName = this.sName;
            slst.Add(std);
        }   
        public string CallPid()//public封装使得该方法在别的类中可以调用
        {
            string sRetValue;
            string sJSON = Newtonsoft.Json.JsonConvert.SerializeObject(this.slst);
            /*[{
            \"sName\":\"Mike\",
            \"sGender\":\"male\",
            \"sHobby\":\"网球\",
            \"debug1\":0,
            \"debug2\":0,
            \"debug3\":0
            }]*/
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
