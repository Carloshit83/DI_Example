using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MyCoreClass : BaseClient
    {
        
        public MyCoreClass()
        {

        }

        public void MyMethod()
        {

            base.OpenConnection();
        }
    }
}
