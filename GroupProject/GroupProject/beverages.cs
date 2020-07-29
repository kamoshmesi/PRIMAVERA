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
    public partial class beverages : UserControl
    {
        public beverages()
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

            total = inc1 * 2 + inc2 * 1.7 + inc3 * 2 + inc4 * 1.8;

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
