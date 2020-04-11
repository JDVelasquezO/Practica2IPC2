using DataAccess;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class ProductLogic
    {
        ProductDataAccess productData = new ProductDataAccess();

        public List<Product> getProductsByStore(int id)
        {
            return productData.getProductsByStore(id);
        }

        public List<Product> getProductByDepartament(String name)
        {
            return productData.getProductByDepartament(name);
        }

        public List<Product> getProductByMunicipality(String name)
        {
            return productData.getProductByMunicipality(name);
        }
    }
}
