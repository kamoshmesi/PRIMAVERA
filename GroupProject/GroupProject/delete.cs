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
    public partial class delete : Form
    {
        public delete()
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
            string password;
            password = textBox1.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\assessment\c#\PRIMAVERA\database\signup.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "DELETE FROM signupup WHERE password='" + password + "'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted");
            }
            catch (SqlException se)
            {
                MessageBox.Show("" + se);
            }

            signupmain sig = new signupmain();
            this.Hide();
            sig.Show();
        }
    }
}
