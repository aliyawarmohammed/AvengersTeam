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

namespace WindowsCrudApp
{
    public partial class Create_Form_Employess : Form
    {
        public Create_Form_Employess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ConnectionString = "Data Source=DESKTOP-3T7SP2U;Initial Catalog=EmployeeDb;Integrated Security=true";

            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("sp_Employee",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpName", textBox1.Text);
            cmd.Parameters.AddWithValue("@EmpSalary", textBox2.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i>0)
            {
                MessageBox.Show("Inserted Record");
            }



        }
    }
}
