using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApiSelfHost
{
    public class A
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class TestController:ApiController
    {
        [Route("my/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            A a = new A()
            {
                Name="张三",
                Age=12
            };
            
            return new HttpResponseMessage { Content = new StringContent(JsonConvert.SerializeObject(a), System.Text.Encoding.UTF8, "application/json") };
        }

        [HttpGet]
        public HttpResponseMessage GetA(string name)
        {
            return new HttpResponseMessage { Content = new StringContent("A-" + name) };
        }

        [HttpGet]
        public HttpResponseMessage GetB(string name)
        {
            return new HttpResponseMessage { Content = new StringContent("B-" + name) };
        }
    }
}
