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

        private void Employee_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

            employee = employeeLogic.searchEmployeeById(Convert.ToInt64(HomeEmployee.id));

            label2.Text = $"Datos de {employee.first} {employee.last}";
            txtCUI.Text = employee.cui.ToString();
            txtName.Text = employee.first;
            txtLast.Text = employee.last;
            txtPhone.Text = employee.phone;
            txtJob.Text = employee.job;
            txtInitDate.Text = employee.init_date;
            txtFinishDate.Text = employee.finish_date;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
