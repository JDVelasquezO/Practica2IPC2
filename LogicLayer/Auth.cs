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

        public string login(string cui, string pass)
        {
            Employee employee = auth.getEmployee(cui);
            string msg = "";
            
            if (cui == employee.cui.ToString() && pass == employee.password)
            {
                msg = "Muy bien";
            }
            else
            {
                msg = "No hay registros";
            }

            return msg;
        }
    }
}
