using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GroupProject
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hellouser he = new hellouser();
            he.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username, password;
            username = textBox1.Text;
            password = textBox2.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\assessment\c#\PRIMAVERA\database\signup.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "UPDATE signupup SET password='" + password + "' WHERE UserName='" + username + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("updated");
            }
            catch (SqlException se)
            {
                MessageBox.Show("" + se);
            }
        }
    }
}
