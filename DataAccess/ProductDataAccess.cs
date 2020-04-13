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

        public bool insertProduct(Product product, int idStore)
        {
            bool response = false;
            conn.open();

            try
            {
                SqlCommand cmd = new SqlCommand("add_product", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_idProduct = new SqlParameter();
                p_idProduct.ParameterName = "@idProduct";
                p_idProduct.SqlDbType = SqlDbType.Int;
                p_idProduct.Value = product.id_product;

                SqlParameter p_category = new SqlParameter();
                p_category.ParameterName = "@category";
                p_category.SqlDbType = SqlDbType.VarChar;
                p_category.Size = 20;
                p_category.Value = product.category;

                SqlParameter p_cuantity = new SqlParameter();
                p_cuantity.ParameterName = "@quantity";
                p_cuantity.SqlDbType = SqlDbType.Int;
                p_cuantity.Value = product.quantity;

                SqlParameter p_mark = new SqlParameter();
                p_mark.ParameterName = "@mark";
                p_mark.SqlDbType = SqlDbType.VarChar;
                p_mark.Size = 20;
                p_mark.Value = product.mark;

                SqlParameter p_price = new SqlParameter();
                p_price.ParameterName = "@price";
                p_price.SqlDbType = SqlDbType.VarChar;
                p_price.Size = 20;
                p_price.Value = product.price;

                SqlParameter p_due_date = new SqlParameter();
                p_due_date.ParameterName = "@due_date";
                p_due_date.SqlDbType = SqlDbType.VarChar;
                p_due_date.Size = 20;
                p_due_date.Value = product.due_date;

                SqlParameter p_size = new SqlParameter();
                p_size.ParameterName = "@size";
                p_size.SqlDbType = SqlDbType.VarChar;
                p_size.Size = 20;
                p_size.Value = product.size;

                cmd.Parameters.Add(p_idProduct);
                cmd.Parameters.Add(p_category);
                cmd.Parameters.Add(p_cuantity);
                cmd.Parameters.Add(p_due_date);
                cmd.Parameters.Add(p_mark);
                cmd.Parameters.Add(p_price);
                cmd.Parameters.Add(p_size);

                cmd.ExecuteNonQuery();
                response = true;
                conn.close();

                insertStoreProduct(idStore, product.id_product);
            }
            catch (Exception e)
            {
                throw;
            }

            return response;
        }

        public void insertStoreProduct(int idStore, int idProduct)
        {
            conn.open();

            try
            {
                SqlCommand cmd = new SqlCommand("add_store_product", conn.returnConn());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p_idStore = new SqlParameter();
                p_idStore.ParameterName = "@idStore";
                p_idStore.SqlDbType = SqlDbType.Int;
                p_idStore.Value = idStore;

                SqlParameter p_idProduct = new SqlParameter();
                p_idProduct.ParameterName = "@idProduct";
                p_idProduct.SqlDbType = SqlDbType.Int;
                p_idProduct.Value = idProduct;

                cmd.Parameters.Add(p_idStore);
                cmd.Parameters.Add(p_idProduct);

                cmd.ExecuteNonQuery();

                conn.close();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
