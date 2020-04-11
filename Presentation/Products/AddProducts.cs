using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Products
{
    public partial class AddProducts : Form
    {
        ProductLogic productLogic = new ProductLogic();
        StoreLogic storeLogic = new StoreLogic();

        public AddProducts()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            txtIdProduct.Focus();
            fillCbx(cbxStore, storeLogic.returnIdStore());
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        public void fillCbx(ComboBox cbx, List<String> listObjects)
        {
            List<String> list = listObjects;

            foreach (var item in listObjects)
            {
                cbx.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.id_product = Convert.ToInt32(txtIdProduct.Text);
            product.category = txtCategory.Text;
            product.quantity = Convert.ToInt32(txtCuantity.Text);
            product.mark = txtMark.Text;
            product.price = txtPrice.Text;
            product.due_date = txtDueDate.Text;
            product.size = txtSize.Text;
            int idStore = Convert.ToInt32(cbxStore.Text);

            if (productLogic.insertProduct(product, idStore))
            {
                MessageBox.Show("Se inserto correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
