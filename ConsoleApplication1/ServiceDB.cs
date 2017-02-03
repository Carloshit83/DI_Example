using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ServiceDB : IService
    {
        public void DoSomething()
        {
            Console.WriteLine("Ya no hay tacos de marrano en la DB... =(");
        }
    }
}
