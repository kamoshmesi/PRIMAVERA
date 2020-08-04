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
    public partial class createaccount : Form
    {
        public createaccount()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            signupmain si = new signupmain();
            si.Show();
            this.Hide();
        }

        string firstname, lastname, username,email, password,phonenumber;
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            firstname = textBox1.Text;
            lastname = textBox2.Text;
            username = textBox3.Text;
            phonenumber =textBox4.Text;
            email = textBox5.Text;
            password = textBox6.Text;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text== "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Enter all feilds");
            }
            else
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\assessment\c#\PRIMAVERA\database\signup.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "Insert into signupup values('" + firstname + "','" + lastname + "','" + username + "','" + phonenumber + "','" + email + "','" + password + "')";
                SqlCommand cmd = new SqlCommand(qry, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("done");

                    signupmain sig = new signupmain();
                    this.Hide();
                    sig.Show();
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("" + sqlEx);
                }
            }
        }
    }
}
