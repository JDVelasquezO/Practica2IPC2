using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;

namespace Presentation
{
    public partial class Form1 : Form
    {
        Auth auth = new Auth();

        public Form1()
        {
            InitializeComponent();
        }

        public string login()
        {
            return auth.login(txtCUI.Text, txtPass.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auth.login(txtCUI.Text, txtPass.Text));
        }
    }
}
