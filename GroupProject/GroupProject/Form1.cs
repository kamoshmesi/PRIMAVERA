using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class application : Form
    {
        public application()
        {
            InitializeComponent();
           
            homee1.BringToFront();
           

        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homee1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            beverages.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            burger.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pizza.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            viewdataaa1.BringToFront();
        }
    }
}
