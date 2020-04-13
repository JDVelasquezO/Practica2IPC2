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
        
        public bool addEmployee(Employee employee)
        {
            bool response = false;

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("add_employee", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_cui = new SqlParameter();
                p_cui.ParameterName = "@cui";
                p_cui.SqlDbType = SqlDbType.BigInt;
                p_cui.Value = employee.cui;

                SqlParameter p_password = new SqlParameter();
                p_password.ParameterName = "@pass";
                p_password.SqlDbType = SqlDbType.VarChar;
                p_password.Size = 20;
                p_password.Value = employee.password;

                SqlParameter p_first = new SqlParameter();
                p_first.ParameterName = "@first";
                p_first.SqlDbType = SqlDbType.VarChar;
                p_first.Size = 20;
                p_first.Value = employee.first;

                SqlParameter p_last = new SqlParameter();
                p_last.ParameterName = "@last";
                p_last.SqlDbType = SqlDbType.VarChar;
                p_last.Size = 20;
                p_last.Value = employee.last;

                SqlParameter p_phone = new SqlParameter();
                p_phone.ParameterName = "@phone";
                p_phone.SqlDbType = SqlDbType.VarChar;
                p_phone.Size = 20;
                p_phone.Value = employee.phone;

                SqlParameter p_job = new SqlParameter();
                p_job.ParameterName = "@job";
                p_job.SqlDbType = SqlDbType.VarChar;
                p_job.Size = 20;
                p_job.Value = employee.job;

                SqlParameter p_InitDate = new SqlParameter();
                p_InitDate.ParameterName = "@initDate";
                p_InitDate.SqlDbType = SqlDbType.VarChar;
                p_InitDate.Size = 20;
                p_InitDate.Value = employee.init_date;

                SqlParameter p_FinishDate = new SqlParameter();
                p_FinishDate.ParameterName = "@finishDate";
                p_FinishDate.SqlDbType = SqlDbType.VarChar;
                p_FinishDate.Size = 20;
                p_FinishDate.Value = employee.finish_date;

                SqlParameter p_idStore = new SqlParameter();
                p_idStore.ParameterName = "@fkIdStore";
                p_idStore.SqlDbType = SqlDbType.BigInt;
                p_idStore.Value = employee.store.id_store;

                cmd.Parameters.Add(p_cui);
                cmd.Parameters.Add(p_password);
                cmd.Parameters.Add(p_first);
                cmd.Parameters.Add(p_last);
                cmd.Parameters.Add(p_phone);
                cmd.Parameters.Add(p_job);
                cmd.Parameters.Add(p_InitDate);
                cmd.Parameters.Add(p_FinishDate);
                cmd.Parameters.Add(p_idStore);

                cmd.ExecuteNonQuery();
                response = true;
                conn.close();
            }
            catch (Exception e)
            {
                throw;
            }

            return response;
        }

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
                    employee.status = Convert.ToBoolean(reader["Estado"]);

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
                    employee.status = Convert.ToBoolean(reader["Estado"].ToString());

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
                    employee.status = Convert.ToBoolean(reader["Estado"]);

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

        public bool updateEmploye(Employee employee)
        {
            conn.open();
            bool response = false;

            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("update_employee", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter id_parameter = new SqlParameter();
                id_parameter.ParameterName = "@cui";
                id_parameter.SqlDbType = SqlDbType.BigInt;
                id_parameter.Value = employee.cui;

                SqlParameter p_first = new SqlParameter();
                p_first.ParameterName = "@first";
                p_first.SqlDbType = SqlDbType.VarChar;
                p_first.Size = 20;
                p_first.Value = employee.first;

                SqlParameter p_last = new SqlParameter();
                p_last.ParameterName = "@last";
                p_last.SqlDbType = SqlDbType.VarChar;
                p_last.Size = 20;
                p_last.Value = employee.last;

                SqlParameter p_phone = new SqlParameter();
                p_phone.ParameterName = "@phone";
                p_phone.SqlDbType = SqlDbType.VarChar;
                p_phone.Size = 10;
                p_phone.Value = employee.phone;

                SqlParameter p_job = new SqlParameter();
                p_job.ParameterName = "@job";
                p_job.SqlDbType = SqlDbType.VarChar;
                p_job.Size = 20;
                p_job.Value = employee.job;

                SqlParameter p_initDate = new SqlParameter();
                p_initDate.ParameterName = "@init_date";
                p_initDate.SqlDbType = SqlDbType.VarChar;
                p_initDate.Size = 20;
                p_initDate.Value = employee.init_date;

                SqlParameter p_finishDate = new SqlParameter();
                p_finishDate.ParameterName = "@finish_date";
                p_finishDate.SqlDbType = SqlDbType.VarChar;
                p_finishDate.Size = 20;
                p_finishDate.Value = employee.finish_date;

                cmd.Parameters.Add(id_parameter);
                cmd.Parameters.Add(p_first);
                cmd.Parameters.Add(p_last);
                cmd.Parameters.Add(p_phone);
                cmd.Parameters.Add(p_job);
                cmd.Parameters.Add(p_initDate);
                cmd.Parameters.Add(p_finishDate);

                cmd.ExecuteNonQuery();

                response = true;
                conn.close();
            }
            catch (Exception e)
            {
                throw;
            }

            return response;
        }

        public bool updateStatus(long cui)
        {
            bool response = false;
            SqlCommand cmd;

            try
            {
                conn.open();
                Employee employee = new Employee();
                cmd = new SqlCommand("update_status_employee", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter id_parameter = new SqlParameter();
                id_parameter.ParameterName = "@cui";
                id_parameter.SqlDbType = SqlDbType.BigInt;
                id_parameter.Value = cui;

                cmd.Parameters.Add(id_parameter);

                cmd.ExecuteNonQuery();

                response = true;

                conn.close();
            }
            catch (Exception e)
            {
                throw;
            }

            return response;
        }

        public Employee searchEmployeeByName(string name)
        {
            Employee employee = new Employee();

            try
            {
                conn.open();

                SqlCommand cmd = new SqlCommand("searchBossByName", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_name = new SqlParameter();
                p_name.ParameterName = "@boss";
                p_name.SqlDbType = SqlDbType.VarChar;
                p_name.Size = 50;
                p_name.Value = name;

                cmd.Parameters.Add(p_name);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    employee.id = Convert.ToInt32(reader["Identificador"]);
                    employee.nameBoss = reader["Encargado"].ToString();
                    break;
                }

                conn.close();
            }
            catch (Exception)
            {

                throw;
            }

            return employee;
        }

        public bool addTypeEmployee(int idBoss, int idEmployee)
        {
            bool response = false;

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("addTypeEmployee", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_idBoss = new SqlParameter();
                p_idBoss.ParameterName = "@fkIdBoss";
                p_idBoss.SqlDbType = SqlDbType.Int;
                p_idBoss.Value = idBoss;
                
                SqlParameter p_idEmployee = new SqlParameter();
                p_idEmployee.ParameterName = "@fkIdEmployee";
                p_idEmployee.SqlDbType = SqlDbType.Int;
                p_idEmployee.Value = idEmployee;

                cmd.Parameters.Add(p_idBoss);
                cmd.Parameters.Add(p_idEmployee);

                cmd.ExecuteNonQuery();
                response = true;
                conn.close();
            }
            catch (Exception e)
            {
                throw;
            }

            return response;
        }

        public bool addTypeEmployeeWithoutBoss(int idBoss)
        {
            bool response = false;

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("addTypeEmployeeWithoutBoss", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_idBoss = new SqlParameter();
                p_idBoss.ParameterName = "@fkIdBoss";
                p_idBoss.SqlDbType = SqlDbType.Int;
                p_idBoss.Value = idBoss;
                
                cmd.Parameters.Add(p_idBoss);

                cmd.ExecuteNonQuery();
                response = true;
                conn.close();
            }
            catch (Exception e)
            {
                throw;
            }

            return response;
        }
    }
}
