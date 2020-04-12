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
        DetailLocationLogic detailLocationLogic = new DetailLocationLogic();

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
                Detail_Ubication detail_Ubication = new Detail_Ubication();
                XmlNodeList nameDepartament = ((XmlElement)item).GetElementsByTagName("departamento");
                XmlNodeList nameMunicipality = ((XmlElement)item).GetElementsByTagName("municipio");
                XmlNodeList nameAddess = ((XmlElement)item).GetElementsByTagName("ubicacion");

                foreach (XmlElement nodo in nameDepartament)
                {
                    detail_Ubication.departament = nodo.InnerText;
                }

                foreach (XmlElement nodo in nameMunicipality)
                {
                    detail_Ubication.municipality = nodo.InnerText;
                }

                foreach (XmlElement nodo in nameAddess)
                {
                    detail_Ubication.address = nodo.InnerText;
                }

                detailLocationLogic.AddDetailUbication(detail_Ubication);

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
            }
        }
    }
}
