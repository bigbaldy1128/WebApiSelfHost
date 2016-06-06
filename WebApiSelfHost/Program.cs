using ICSharpCode.SharpZipLib.Zip;
using Microsoft.Owin.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://+:8080";
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Running on {0}", url);
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
            }
        }
    }
}
