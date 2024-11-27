using System;
using System.Drawing;
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
            try
            {
                var bevitel = Convert.ToInt32(textBox1.Text);
                if (bevitel % 2 == 0)
                {
                    label4.Text = "paros";
                }
                else
                {
                    label4.Text = "paratlan";

                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message, "Hiba történt");
                label4.Text = "Hiba";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            random.Text = Convert.ToString(rand.Next(600));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            random.Text = Convert.ToString(rand.Next(600));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //páros
            var a = Convert.ToInt32(random.Text);
            if (a % 2 == 0)
            {
                valasz.Text = "Helyes";
                valasz.ForeColor = Color.Green;
                MessageBox.Show("Helyes");

            }
            else
            {
                valasz.Text = "Helytelen";
                valasz.ForeColor = Color.Red;
                MessageBox.Show("Helytelen");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //páratlan
            var a = Convert.ToInt32(random.Text);
            if (a % 2 != 0)
            {
                valasz.Text = "Helyes";
                valasz.ForeColor = Color.Green;
                MessageBox.Show("Helyes");
            }
            else
            {
                valasz.Text = "Helytelen";
                valasz.ForeColor = Color.Red;
                MessageBox.Show("Helytelen");
            }
        }
    }
}
