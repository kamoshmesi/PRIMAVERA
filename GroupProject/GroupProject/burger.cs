using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
