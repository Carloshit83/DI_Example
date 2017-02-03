using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ServiceAzure : IService
    {
        public void DoSomething()
        {
            Console.WriteLine("Ahora hay tacos de marrano en la nube...");
        }
    }
}
