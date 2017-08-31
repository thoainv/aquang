using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestServices
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest req = WebRequest.Create("http://localhost:22621/Service1.svc/getinfo/thoai");
            req.Method = "GET";
            string data = "";
            using(WebResponse rp = req.GetResponse())
            {
                Stream reStr = rp.GetResponseStream();
                using(StreamReader reader = new StreamReader(reStr))
                {
                    data = reader.ReadToEnd();
                }
            }

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        }
    }
}
