using DemoBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    public class InternalService
    {
        //access the DemoBL dependency in the internal service by injecting it this way
        private readonly IDemoService demoservice;

        public InternalService(IDemoService demoservice)
        {
            this.demoservice = demoservice;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello form the Iternal Service");
            demoservice.SayHello();
        }
    }
}
