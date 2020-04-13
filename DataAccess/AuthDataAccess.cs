using EntityLayer;
using Presentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AuthDataAccess
    {
        Conn conn = new Conn();

        public Employee getEmployee(string cui)
        {
            conn.open();
            Employee employee = new Employee();

            string query = "SELECT * FROM employee WHERE cui = " + Convert.ToInt64(cui) + "";
            SqlCommand cmd = new SqlCommand(query, conn.returnConn());
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    employee.cui = Convert.ToInt64(reader[1].ToString());
                    employee.password = reader[2].ToString();
                    employee.first = reader[3].ToString();
                    employee.last = reader[4].ToString();
                    employee.phone = reader[5].ToString();
                    employee.job = reader[6].ToString();
                    employee.init_date = reader[7].ToString();
                    employee.finish_date = reader[8].ToString();
                }

                conn.close();
            }
            catch (Exception)
            {

                throw;
            }

            return employee;
        }
    }
}
