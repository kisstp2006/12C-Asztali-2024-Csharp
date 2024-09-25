using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WonForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                var bevitel = Convert.ToInt32(textBox1.Text);


            if (bevitel%2==0)
            {
                label4.Text = "paros";
            }
            else
            {
                label4.Text = "paratlan";
            }
        }
    }
}
