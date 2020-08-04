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
    public partial class hellouser : Form
    {
        public hellouser()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete de = new delete();
            de.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update up = new update();
            up.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            application fm = new application();
            this.Hide();
            fm.Show();
        }
    }
}
