using Presentation.Employees;
using Presentation.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeEmployee homeEmployee = new HomeEmployee();
            homeEmployee.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeProduct homeProduct = new HomeProduct();
            homeProduct.Show();
        }
    }
}
