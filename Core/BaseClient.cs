using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class BaseClient
    {
        public string Name { get; set; }

        private int Id { get; set; }

        public BaseClient()
        {
            
        }

        protected virtual void SendMessage(string msg)
        {
            OpenConnection();
            Console.WriteLine(string.Format("Mensaje enviado: {0}", msg));
            CloseConnection();
        }

        public void SendMessage(string msg, string format)
        {
            Console.WriteLine(string.Format(format, msg));
        }


        internal void OpenConnection()
        {
            Console.WriteLine("Connection opened.");
        }

        protected void CloseConnection()
        {
            Console.WriteLine("Connection closed.");
        }
    }
}
