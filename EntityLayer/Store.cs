using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Store
    {
        public int id_store { get; set; }
        public string phone { get; set; }
        public string type { get; set; }
        public Detail_Ubication detail_ubication = new Detail_Ubication();
        //public List<Employee> employees { get; set; }
    }
}
