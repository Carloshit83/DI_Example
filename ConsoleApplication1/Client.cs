using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace ConsoleApplication1
{
    public class Client : BaseClient
    {
        private IService _myService;
        private int Id { get; set; }


        public Client(IService service)
        {
            _myService = service;
        }

        public void Do()
        {
            _myService.DoSomething();
        }

        public void StartComunication(string message)
        {
            base.SendMessage(message);
            this.SendMessage(message);
            base.SendMessage("Yo soy un mensajito", "Utilizando la sobrecarga: {0}");
            
           
        }

        protected override void SendMessage(string msg)
        {
            
            Console.WriteLine(string.Format("Yo soy el hijo: {0}", msg));
            base.CloseConnection();

        }

        



    }
}
