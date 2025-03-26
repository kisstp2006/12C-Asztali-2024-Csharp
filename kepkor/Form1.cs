namespace kepkor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Forgats();

        }
        public async Task Forgats()
        {
            while (true)
            {
                await Task.Delay(1000);
                ChangeImg();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void ChangeImg()
        {
            var tempImage = label10.Image;


            label10.Image = label9.Image;
            label9.Image = label8.Image;
            label8.Image = label5.Image;
            label5.Image = label4.Image;
            label4.Image = label3.Image;
            label3.Image = label2.Image;
            label2.Image = label1.Image;


            label1.Image = tempImage;

        }
        private void ChangeImgBackward()
        {
            var tempImage = label1.Image;


            label9.Image = label10.Image;
            label8.Image = label9.Image;
            label5.Image = label8.Image;
            label4.Image = label5.Image;
            label3.Image = label4.Image;
            label2.Image = label3.Image;
            label1.Image = label2.Image;


            label10.Image = tempImage;

        }

        private void label7_Click(object sender, EventArgs e)
        {
            ChangeImg();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ChangeImg();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
