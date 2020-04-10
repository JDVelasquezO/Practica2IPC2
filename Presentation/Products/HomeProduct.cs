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
    public partial class HomeProduct : Form
    {
        StoreLogic storeLogic = new StoreLogic();
        DetailLocationLogic detailLocationLogic = new DetailLocationLogic();

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
            fillCbx(cbxMunicipality, detailLocationLogic.returnNameMunicipality());
            fillCbx(cbxDepartament, detailLocationLogic.returnNameDepartament());

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
    }
}
