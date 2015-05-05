using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_control
{
    class username
    {
        private string usrName;

        private string getUserName(string usrGet)
        {
            string user;
            user = usrGet;
            return user;
        }

        public string checkUsr
        {
            get { return usrName; }

            set {usrName=getUserName(value);}
        }

    }
}
