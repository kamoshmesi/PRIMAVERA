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
    public partial class signupmain : Form
    {
        public signupmain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createaccount cr = new createaccount();
            cr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\assessment\c#\PRIMAVERA\database\signup.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "Select * From signupup Where username='" + textBox1.Text.Trim() + "' and password='" + textBox2.Text.Trim() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(qry,con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count==1)
            {
                hellouser he = new hellouser();
                this.Hide();
                he.Show();

            }
            else
            {
                MessageBox.Show("Check your user name and password");
            }

        }
    }
}
