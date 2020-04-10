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

namespace Presentation.Employees
{
    public partial class EmployeeView : Form
    {
        EmployeeLogic employeeLogic = new EmployeeLogic();
        Employee employee;

        public EmployeeView()
        {
            InitializeComponent();
        }

        public void chargeData()
        {
            employee = employeeLogic.searchEmployeeById(Convert.ToInt64(HomeEmployee.id));

            if (employee.status)
            {
                label2.Text = $"Datos de {employee.first} {employee.last}";
                txtCUI.Text = employee.cui.ToString();
                txtName.Text = employee.first;
                txtLast.Text = employee.last;
                txtPhone.Text = employee.phone;
                txtJob.Text = employee.job;
                txtInitDate.Text = employee.init_date;
                txtFinishDate.Text = employee.finish_date;
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            chargeData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee();

            newEmployee.cui = Convert.ToInt64(txtCUI.Text);
            newEmployee.first = txtName.Text;
            newEmployee.last = txtLast.Text;
            newEmployee.phone = txtPhone.Text;
            newEmployee.job = txtJob.Text;
            newEmployee.init_date = txtInitDate.Text;
            newEmployee.finish_date = txtFinishDate.Text;

            if (employeeLogic.updateEmploye(newEmployee))
            {
                MessageBox.Show("Actualizado Correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Algo salio mal");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long cui = Convert.ToInt64(txtCUI.Text);

            if (employeeLogic.updateStatus(cui))
            {
                MessageBox.Show("Se ha dado de baja");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }
    }
}
