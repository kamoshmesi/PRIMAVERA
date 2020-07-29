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
    public partial class pizza : UserControl
    {
        public pizza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total;
            double inc1, inc2, inc3, inc4;

            inc1 = Convert.ToDouble(numericUpDow1.Value);
            inc2 = Convert.ToDouble(numericUpDown2.Value);
            inc3 = Convert.ToDouble(numericUpDown3.Value);
            inc4 = Convert.ToDouble(numericUpDown4.Value);

            total = inc1 * 60 + inc2 * 75.5 + inc3 * 70.5 + inc4 * 85.7;

            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (radioButton1.Checked == true)
                {
                    total1.Text = total.ToString() + "$";
                }
                else
                {
                    total = total + (total / 100) * 10;
                    total1.Text = total.ToString() + "$";
                }
            }
            else
            {
                MessageBox.Show("please select delivery method");
            }
        }
    }
}
