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
    public class EmployeeDataAccess
    {
        Conn conn = new Conn();
        
        public List<Employee> getEmployeesByStore(int id)
        {
            conn.open();
            List<Employee> employees = new List<Employee>();

            try
            {
                SqlCommand cmd = new SqlCommand("get_employee", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter id_parameter = new SqlParameter();
                id_parameter.ParameterName = "@fkIdStore";
                id_parameter.SqlDbType = SqlDbType.Int;
                id_parameter.Value = id;

                cmd.Parameters.Add(id_parameter);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.cui = Convert.ToInt64(reader["CUI"]);
                    employee.first = reader["Nombre"].ToString();
                    employee.last = reader["Apellido"].ToString();
                    employee.phone = reader["Telefono"].ToString();
                    employee.job = reader["Puesto"].ToString();
                    employee.init_date = reader["Fecha Inicio"].ToString();
                    employee.finish_date = reader["Fecha Final"].ToString();

                    if (reader["Fecha Final"].ToString() == "")
                    {
                        employee.finish_date = "En vigencia";
                    }

                    employees.Add(employee);
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return employees;
        }
    }
}
