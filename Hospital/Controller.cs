using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hospital
{
    class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }
       
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}

