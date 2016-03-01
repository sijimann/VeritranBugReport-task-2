using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soapclient
{
    class Program
    {
        static void Main(string[] args)
        {
            hello.HelloWorldServiceClient client = new hello.HelloWorldServiceClient();
            hello.request req= new hello.request();
            req.age="12";
            req.firstName="simba";
            req.lastName="makura";
            hello.response res=client.ProcessRequest(req);
            Console.WriteLine(res.dateOfBirth);
            Console.ReadLine();
        }
    }
}
