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

        public List<Employee> getEmployees(String name, String procedure, String parameter)
        {
            conn.open();
            List<Employee> employees = new List<Employee>();

            try
            {
                SqlCommand cmd = new SqlCommand(procedure, conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter name_parameter = new SqlParameter();
                name_parameter.ParameterName = parameter;
                name_parameter.SqlDbType = SqlDbType.VarChar;
                name_parameter.Size = 50;
                name_parameter.Value = name;

                cmd.Parameters.Add(name_parameter);

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
                        employee.finish_date = "Aún en vigencia";
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

        public List<Employee> getEmployeesByDepartament(String name)
        {
            return getEmployees(name, "get_employee_departament", "@nameDepartament");
        }

        public List<Employee> getEmployeesByMunicipality(String name)
        {
            return getEmployees(name, "get_employee_municipality", "@nameMunicipality");
        }

        public Employee searchEmployeeById(long cui)
        {
            conn.open();
            Employee employee = new Employee();

            try
            {
                SqlCommand cmd = new SqlCommand("search_employee_by_id", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter id_parameter = new SqlParameter();
                id_parameter.ParameterName = "@cuiEmployee";
                id_parameter.SqlDbType = SqlDbType.BigInt;
                id_parameter.Value = cui;

                cmd.Parameters.Add(id_parameter);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
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
