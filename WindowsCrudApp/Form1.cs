using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCrudApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDbDataSet.sp_GetEmployeeData' table. You can move, or remove it, as needed.
            this.sp_GetEmployeeDataTableAdapter.Fill(this.employeeDbDataSet.sp_GetEmployeeData);
            // TODO: This line of code loads data into the 'employeeDbDataSet.sp_GetEmployeeData' table. You can move, or remove it, as needed.
            this.sp_GetEmployeeDataTableAdapter.Fill(this.employeeDbDataSet.sp_GetEmployeeData);
            // TODO: This line of code loads data into the 'employeeDbDataSet.tblEmployee' table. You can move, or remove it, as needed.

        }

        private void tblEmployeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
                    }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           
            Form1 frm = new Form1();
            frm.Hide();


            Create_Form_Employess obj = new Create_Form_Employess();
            obj.Show();


            


        }
    }
}
