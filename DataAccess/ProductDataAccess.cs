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
    public class ProductDataAccess
    {
        Conn conn = new Conn();

        public List<Product> getProductsByStore(int id)
        {
            conn.open();
            List<Product> products = new List<Product>();

            try
            {
                SqlCommand cmd = new SqlCommand("searchProductByStore", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter id_parameter = new SqlParameter();
                id_parameter.ParameterName = "@fkIdStore";
                id_parameter.SqlDbType = SqlDbType.Int;
                id_parameter.Value = id;

                cmd.Parameters.Add(id_parameter);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.id_product = Convert.ToInt32(reader["Identificador"]);
                    product.category = reader["Categoria"].ToString();
                    product.quantity = Convert.ToInt32(reader["Cantidad"].ToString());
                    product.mark = reader["Marca"].ToString();
                    product.price = reader["Precio"].ToString();
                    product.due_date = reader["Fecha Vencimiento"].ToString();
                    product.size = reader["Tamaño"].ToString();

                    products.Add(product);
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return products;
        }

        public List<Product> getProducts(String name, String procedure, String parameter)
        {
            conn.open();
            List<Product> products = new List<Product>();

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
                    Product product = new Product();
                    product.id_product = Convert.ToInt32(reader["Identificador"]);
                    product.category = reader["Categoria"].ToString();
                    product.quantity = Convert.ToInt32(reader["Cantidad"].ToString());
                    product.mark = reader["Marca"].ToString();
                    product.price = reader["Precio"].ToString();
                    product.due_date = reader["Fecha Vencimiento"].ToString();
                    product.size = reader["Tamaño"].ToString();

                    products.Add(product);
                }

                conn.close();
            }
            catch (Exception)
            {
                throw;
            }

            return products;
        }

        public List<Product> getProductByDepartament(String name)
        {
            return getProducts(name, "get_product_departament", "@nameDepartament");
        }

        public List<Product> getProductByMunicipality(String name)
        {
            return getProducts(name, "get_product_municipality", "@nameMunicipality");
        }
    }
}
