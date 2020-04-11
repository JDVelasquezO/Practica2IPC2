using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Product
    {
        public int id_product { get; set; }
        public string category { get; set; }
        public int quantity { get; set; }
        public string mark { get; set; }
        public string price { get; set; }
        public string due_date { get; set; }
        public string size { get; set; }
    }
}
