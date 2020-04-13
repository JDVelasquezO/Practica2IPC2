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
using System.Xml;

namespace Presentation.Stores
{
    public partial class HomeStore : Form
    {
        DepartamentLogic departamentLogic = new DepartamentLogic();
        MunicipalityLogic municipalityLogic = new MunicipalityLogic();
        DetailLocationLogic detailLocationLogic = new DetailLocationLogic();
        StoreLogic storeLogic = new StoreLogic();

        public HomeStore()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            String value = "C:\\Users\\JDVelasquezO\\USAC\\Tercer Año\\IPC2\\Practicas\\Practica 2\\archivos\\tiendas.xml";
            doc.Load(value);

            XmlNodeList xStores = doc.GetElementsByTagName("tiendas");
            XmlNodeList stores = ((XmlElement)xStores[0]).GetElementsByTagName("tienda");

            foreach (var item in stores)
            {
                Departament departament = new Departament();
                XmlNodeList nameDepartament = ((XmlElement)item).GetElementsByTagName("departamento");
                foreach (XmlElement nodo in nameDepartament)
                {
                    departament.name_departament = nodo.InnerText;
                }
                departamentLogic.AddDepartament(departament);

                int idDepartament = departamentLogic.getIdDepartament(departament.name_departament);
                Municipality municipality = new Municipality();
                XmlNodeList nameMunicipality = ((XmlElement)item).GetElementsByTagName("municipio");
                foreach (XmlElement nodo in nameMunicipality)
                {
                    municipality.name_municipality = nodo.InnerText;
                }
                municipality.departament.id_departament = idDepartament;
                municipalityLogic.AddMunicipality(municipality);

                int idMunicipality = municipalityLogic.getIdMunicipality(municipality.name_municipality);
                Detail_Ubication detail_Ubication = new Detail_Ubication();
                XmlNodeList nameAddress = ((XmlElement)item).GetElementsByTagName("ubicacion");
                foreach (XmlElement nodo in nameAddress)
                {
                    detail_Ubication.address = nodo.InnerText;
                }
                detail_Ubication.municipality.id_municipality = idMunicipality;
                detailLocationLogic.AddDetailUbication(detail_Ubication);

                int idAddress = detailLocationLogic.getIdMunicipality(detail_Ubication.address);
                Store store = new Store();
                XmlNodeList idsStores = ((XmlElement)item).GetElementsByTagName("id");
                XmlNodeList phoneStores = ((XmlElement)item).GetElementsByTagName("telefono");
                foreach (XmlElement nodo in idsStores)
                {
                    store.id_store = Convert.ToInt32(nodo.InnerText);
                }
                foreach (XmlElement nodo in phoneStores)
                {
                    store.phone = nodo.InnerText;
                }
                store.detail_ubication.id_detail_ubication = idAddress;

                if (storeLogic.AddStores(store))
                {
                    this.Close();
                }
            }
        }

        private void HomeStore_Load(object sender, EventArgs e)
        {
            cbxMunicipality.Text = "Escoge una municipio";
            cbxDepartament.Text = "Escoge un departamento";

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

        private void button2_Click(object sender, EventArgs e)
        {
            dgvStore.Rows.Clear();

            String name = cbxMunicipality.SelectedItem.ToString();
            List<Store> stores = storeLogic.getStoreByMunicipality(name);

            foreach (var item in stores)
            {
                dgvStore.Rows.Add(item.id_store, item.phone, item.detail_ubication.address, 
                    item.detail_ubication.municipality.name_municipality, 
                    item.detail_ubication.municipality.departament.name_departament, 
                    item.employee.first);
            }
        }
    }
}
