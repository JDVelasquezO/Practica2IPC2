using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Employee
    {
        public int id { get; set; }
        public long cui { get; set; }
        public string password { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string phone { get; set; }
        public string job { get; set; }
        public string init_date { get; set; }
        public string finish_date { get; set; }
        public bool status { get; set; }
        public string nameBoss { get; set; }
        public Store store = new Store();
    }
}
