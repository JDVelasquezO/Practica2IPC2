using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Presentation.Employees
{
    public partial class HomeEmployee : Form
    {
        StoreLogic storeLogic = new StoreLogic();
        DetailLocationLogic detailLocationLogic = new DetailLocationLogic();
        EmployeeLogic employeeLogic = new EmployeeLogic();
        DepartamentLogic departamentLogic = new DepartamentLogic();
        MunicipalityLogic municipalityLogic = new MunicipalityLogic();
        public static string id;

        public HomeEmployee()
        {
            InitializeComponent();
        }

        private void HomeEmployee_Load(object sender, EventArgs e)
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

        private void cbxMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxDepartament_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxStore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvEmployees.Rows.Clear();

            int id = Convert.ToInt32(cbxStore.SelectedItem.ToString());
            List<Employee> employees = employeeLogic.getEmployeesByStore(id);

            foreach (var item in employees)
            {
                if (item.status)
                {
                    dgvEmployees.Rows.Add(item.cui, item.first, item.last, item.phone, item.job, item.init_date, item.finish_date);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvEmployees.Rows.Clear();

            String name = cbxMunicipality.SelectedItem.ToString();
            List<Employee> employees = employeeLogic.getEmployeesByMunicipality(name);

            foreach (var item in employees)
            {
                if (item.status)
                {
                    dgvEmployees.Rows.Add(item.cui, item.first, item.last, item.phone, item.job, item.init_date, item.finish_date);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvEmployees.Rows.Clear();

            String name = cbxDepartament.SelectedItem.ToString();
            List<Employee> employees = employeeLogic.getEmployeesByDepartament(name);

            foreach (var item in employees)
            {
                if (item.status)
                {
                    dgvEmployees.Rows.Add(item.cui, item.first, item.last, item.phone, item.job, item.init_date, item.finish_date);
                }
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = dgvEmployees.Rows[e.RowIndex].Cells["colID"].FormattedValue.ToString();
                EmployeeView employee = new EmployeeView();
                employee.Show();
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

            XmlNodeList xEmployees = doc.GetElementsByTagName("empleados");
            XmlNodeList employees = ((XmlElement)xEmployees[0]).GetElementsByTagName("empleado");

            foreach (var item in employees)
            {
                Employee employee = new Employee();

                XmlNodeList cui = ((XmlElement)item).GetElementsByTagName("CUI");
                foreach (XmlElement nodo in cui)
                {
                    employee.cui = Convert.ToInt64(nodo.InnerText);
                }

                XmlNodeList password = ((XmlElement)item).GetElementsByTagName("password");
                foreach (XmlElement nodo in password)
                {
                    employee.password = nodo.InnerText;
                }

                XmlNodeList name = ((XmlElement)item).GetElementsByTagName("nombre");
                foreach (XmlElement nodo in name)
                {
                    employee.first = nodo.InnerText;
                }

                XmlNodeList last = ((XmlElement)item).GetElementsByTagName("apellido");
                foreach (XmlElement nodo in last)
                {
                    employee.last = nodo.InnerText;
                }

                XmlNodeList phone = ((XmlElement)item).GetElementsByTagName("telefono");
                foreach (XmlElement nodo in phone)
                {
                    employee.phone = nodo.InnerText;
                }

                XmlNodeList job = ((XmlElement)item).GetElementsByTagName("puesto");
                foreach (XmlElement nodo in job)
                {
                    employee.job = nodo.InnerText;
                }

                XmlNodeList initDate = ((XmlElement)item).GetElementsByTagName("fechainicio");
                foreach (XmlElement nodo in initDate)
                {
                    employee.init_date = nodo.InnerText;
                }

                XmlNodeList finishDate = ((XmlElement)item).GetElementsByTagName("fechafin");
                foreach (XmlElement nodo in finishDate)
                {
                    employee.finish_date = nodo.InnerText;
                }

                XmlNodeList idStore = ((XmlElement)item).GetElementsByTagName("tienda");
                foreach (XmlElement nodo in idStore)
                {
                    employee.store.id_store = Convert.ToInt32(nodo.InnerText);
                }

                // Agregar Empleados
                employeeLogic.addEmployee(employee);
                
                XmlNodeList boss = ((XmlElement)item).GetElementsByTagName("jefe");
                foreach (XmlElement nodo in boss)
                {
                    employee.nameBoss = nodo.InnerText;
                }
                // Obtener el empleado que coincide con el nombre del jefe que viene en xml
                employeeLogic.searchEmployeeByName(employee.nameBoss, employee);
                this.Close();
            }
        }
    }
}
