using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GroupProject
{
    public partial class viewdataaa : UserControl
    {
        public viewdataaa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\assessment\c#\PRIMAVERA\database\signup.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM pizza";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();
            da.Fill(ds, "crudTable");
            dataGridView1.DataSource = ds.Tables["crudTable"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\assessment\c#\PRIMAVERA\database\signup.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM burger";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();
            da.Fill(ds, "crudTable");
            dataGridView2.DataSource = ds.Tables["crudTable"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\assessment\c#\PRIMAVERA\database\signup.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM beverages";

            SqlDataAdapter da = new SqlDataAdapter(qry, conString);
            DataSet ds = new DataSet();
            da.Fill(ds, "crudTable");
            dataGridView3.DataSource = ds.Tables["crudTable"];
        }
    }
}
