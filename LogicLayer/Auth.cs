using DataAccess;
using EntityLayer;
using Presentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Auth
    {
        AuthDataAccess auth = new AuthDataAccess();

        public bool login(string cui, string pass)
        {
            Employee employee = auth.getEmployee(cui);
            bool marker = false;
            
            if (cui == employee.cui.ToString() && pass == employee.password)
            {
                marker = true;
            }

            return marker;
        }
    }
}
