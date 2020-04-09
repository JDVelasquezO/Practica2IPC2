using EntityLayer;
using LogicLayer;
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

namespace Presentation.Employees
{
    public partial class HomeEmployee : Form
    {
        StoreLogic storeLogic = new StoreLogic();
        DetailLocationLogic detailLocationLogic = new DetailLocationLogic();
        EmployeeLogic employeeLogic = new EmployeeLogic();

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

        public void cleanTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            dt.Rows.Add(dt.NewRow());
            dgv.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvEmployees.Rows.Clear();

            int id = Convert.ToInt32(cbxStore.SelectedItem.ToString());
            List<Employee> employees = employeeLogic.getEmployeesByStore(id);

            foreach (var item in employees)
            {
                dgvEmployees.Rows.Add(item.cui, item.first, item.last, item.phone, item.job, item.init_date, item.finish_date);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvEmployees.Rows.Clear();

            String name = cbxMunicipality.SelectedItem.ToString();
            List<Employee> employees = employeeLogic.getEmployeesByMunicipality(name);

            foreach (var item in employees)
            {
                dgvEmployees.Rows.Add(item.cui, item.first, item.last, item.phone, item.job, item.init_date, item.finish_date);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvEmployees.Rows.Clear();

            String name = cbxDepartament.SelectedItem.ToString();
            List<Employee> employees = employeeLogic.getEmployeesByDepartament(name);

            foreach (var item in employees)
            {
                dgvEmployees.Rows.Add(item.cui, item.first, item.last, item.phone, item.job, item.init_date, item.finish_date);
            }
        }
    }
}
