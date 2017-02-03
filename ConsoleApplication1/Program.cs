using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IService service = new Service();
            IService serviceDB = new ServiceDB();
            IService serviceAzure = new ServiceAzure();

            Client client = new Client(serviceAzure);

            client.StartComunication("ola k ase!");
            
            

            Console.ReadLine();


            

        }
    }
}
