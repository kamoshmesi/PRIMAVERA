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
    public partial class burger : UserControl
    {
        public burger()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total;
            double inc1, inc2, inc3, inc4;

            inc1 = Convert.ToDouble(numericUpDow1.Value);
            inc2 = Convert.ToDouble(numericUpDown2.Value);
            inc3 = Convert.ToDouble(numericUpDown3.Value);
            inc4 = Convert.ToDouble(numericUpDown4.Value);

            total = inc1*20 + inc2*21.5 + inc3*18.6 + inc4*25.5;

            if (radioButton1.Checked || radioButton2.Checked)
            {
                if(radioButton1.Checked==true)
                {
                    total1.Text = total.ToString()+"$";
                }
                else
                {
                    total = total + (total / 100) * 10;
                    total1.Text = total.ToString()+"$";
                }
            }
            else
            {
                MessageBox.Show("please select delivery method");
            }

            

        }

        string customername, deliverymethod;

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDow1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Text = "";
            total1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            customername = textBox1.Text;

            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (radioButton1.Checked == true)
                {
                    deliverymethod = "take away";
                }
                else
                {
                    deliverymethod = "delivery";
                }
            }
            else
            {
                MessageBox.Show("please select delivery method");
            }

            double total;
            double inc1, inc2, inc3, inc4;

            inc1 = Convert.ToDouble(numericUpDow1.Value);
            inc2 = Convert.ToDouble(numericUpDown2.Value);
            inc3 = Convert.ToDouble(numericUpDown3.Value);
            inc4 = Convert.ToDouble(numericUpDown4.Value);

            total = inc1 * 60 + inc2 * 75.5 + inc3 * 70.5 + inc4 * 85.7;




            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\assessment\c#\PRIMAVERA\database\signup.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "Insert into burger values('" + customername + "','" + total + "','" + deliverymethod + "','"+DateTime.Now+"')";
            SqlCommand cmd = new SqlCommand(qry, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("done");


            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("" + sqlEx);
            }
        }
    }
}
