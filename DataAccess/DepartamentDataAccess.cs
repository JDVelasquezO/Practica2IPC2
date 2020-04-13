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
    public class DepartamentDataAccess
    {
        Conn conn = new Conn();

        public List<String> getListDepartaments()
        {
            List<String> list = new List<String>();

            try
            {
                conn.open();
                String nameObject = "";

                SqlCommand cmd;
                SqlDataReader reader;

                cmd = new SqlCommand($"SELECT name_departament FROM departament", conn.returnConn());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nameObject = reader["name_departament"].ToString();
                    list.Add(nameObject);
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return list;
        }

        public int getIdDepartament(string name)
        {
            int id = 0;

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("getIdDepartament", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter nameDepartament = new SqlParameter();
                nameDepartament.ParameterName = "@nameDepartament";
                nameDepartament.SqlDbType = SqlDbType.VarChar;
                nameDepartament.Size = 50;
                nameDepartament.Value = name;

                cmd.Parameters.Add(nameDepartament);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Identificador"]);
                    break;
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return id;
        }

        public string getNameDepartament(string name)
        {
            string nameDep = "";

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("getNameDepartament", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter nameDepartament = new SqlParameter();
                nameDepartament.ParameterName = "@nameDepartament";
                nameDepartament.SqlDbType = SqlDbType.VarChar;
                nameDepartament.Size = 50;
                nameDepartament.Value = name;

                cmd.Parameters.Add(nameDepartament);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nameDep = reader["Nombre"].ToString();
                    break;
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return nameDep;
        }

        public bool AddDepartament(Departament departament)
        {
            bool response = false;

            try
            {
                conn.open();
                SqlCommand cmd = new SqlCommand("add_departament", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_nameDepartament = new SqlParameter();
                p_nameDepartament.ParameterName = "@nameDepartament";
                p_nameDepartament.SqlDbType = SqlDbType.VarChar;
                p_nameDepartament.Size = 20;
                p_nameDepartament.Value = departament.name_departament;

                cmd.Parameters.Add(p_nameDepartament);

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
