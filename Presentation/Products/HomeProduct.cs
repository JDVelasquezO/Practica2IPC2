using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Presentation.Products
{
    public partial class HomeProduct : Form
    {
        StoreLogic storeLogic = new StoreLogic();
        DetailLocationLogic detailLocationLogic = new DetailLocationLogic();
        ProductLogic productLogic = new ProductLogic();
        DepartamentLogic departamentLogic = new DepartamentLogic();
        MunicipalityLogic municipalityLogic = new MunicipalityLogic();

        public HomeProduct()
        {
            InitializeComponent();
        }

        private void HomeProduct_Load(object sender, EventArgs e)
        {
            cbxStore.Text = "Escoge una tienda";
            cbxMunicipality.Text = "Escoge una municipio";
            cbxDepartament.Text = "Escoge un departamento";

            fillCbx(cbxStore, storeLogic.returnIdStore());
            fillCbx(cbxMunicipality, municipalityLogic.getListMunicipality());
            fillCbx(cbxDepartament, departamentLogic.getListDepartaments());

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
            dgvProducts.Rows.Clear();

            int id = Convert.ToInt32(cbxStore.SelectedItem.ToString());
            List<Product> employees = productLogic.getProductsByStore(id);
                
            foreach (var item in employees)
            {
                dgvProducts.Rows.Add(item.id_product, item.category, item.quantity, item.mark, item.price, item.due_date, item.size);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.Clear();

            String name = cbxMunicipality.SelectedItem.ToString();
            List<Product> products = productLogic.getProductByMunicipality(name);

            foreach (var item in products)
            {
                dgvProducts.Rows.Add(item.id_product, item.category, item.quantity, item.mark, item.price, item.due_date, item.size);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvProducts.Rows.Clear();

            String name = cbxDepartament.SelectedItem.ToString();
            List<Product> products = productLogic.getProductByDepartament(name);

            foreach (var item in products)
            {
                dgvProducts.Rows.Add(item.id_product, item.category, item.quantity, item.mark, item.price, item.due_date, item.size);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            textBox1.Text = filePath;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            String value = textBox1.Text;
            doc.Load(value);

            XmlNodeList xProducts = doc.GetElementsByTagName("productos");
            XmlNodeList products = ((XmlElement)xProducts[0]).GetElementsByTagName("producto");

            foreach (var item in products)
            {
                Product product = new Product();
                Store_Product store_Product = new Store_Product();

                XmlNodeList ids = ((XmlElement)item).GetElementsByTagName("id");
                foreach (XmlElement nodo in ids)
                {
                    product.id_product = Convert.ToInt32(nodo.InnerText);
                }

                XmlNodeList categories = ((XmlElement)item).GetElementsByTagName("categoria");
                foreach (XmlElement nodo in categories)
                {
                    product.category = nodo.InnerText;
                }

                XmlNodeList quantity = ((XmlElement)item).GetElementsByTagName("existencias");
                foreach (XmlElement nodo in quantity)
                {
                    product.quantity = Convert.ToInt32(nodo.InnerText);
                }

                XmlNodeList mark = ((XmlElement)item).GetElementsByTagName("marca");
                foreach (XmlElement nodo in mark)
                {
                    product.mark = nodo.InnerText;
                }

                XmlNodeList price = ((XmlElement)item).GetElementsByTagName("precio");
                foreach (XmlElement nodo in price)
                {
                    product.price = nodo.InnerText;
                }

                XmlNodeList size = ((XmlElement)item).GetElementsByTagName("tamanio");
                foreach (XmlElement nodo in size)
                {
                    product.size = nodo.InnerText;
                }

                XmlNodeList dueDate = ((XmlElement)item).GetElementsByTagName("vencimiento");
                foreach (XmlElement nodo in dueDate)
                {
                    product.due_date = nodo.InnerText;
                }

                XmlNodeList idStore = ((XmlElement)item).GetElementsByTagName("tienda");
                foreach (XmlElement nodo in idStore)
                {
                    store_Product.id_store = Convert.ToInt32(nodo.InnerText);
                }

                productLogic.insertProduct(product, store_Product.id_store);
            }
        }
    }
}
