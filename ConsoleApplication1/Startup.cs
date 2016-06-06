using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleApplication1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //创建一个HTTP的实例配置
            HttpConfiguration config = new HttpConfiguration();
            //映射路由
            config.Routes.MapHttpRoute(
              name: "default",
              routeTemplate: "api/{controller}/{action}/{id}",
              defaults: new { id = RouteParameter.Optional }
            );
            //将配置注入OWIN管道中
            app.UseWebApi(config);
        }
    }
}
