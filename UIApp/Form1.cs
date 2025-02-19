namespace UIApp
{
    public partial class MainForm : Form
    {
        private bool felfele=true, iranybalra = true;
        private int lepesfel = 20, lepesoldal=20;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_clickme_Click(object sender, EventArgs e)
        {
            btn_clickme.Text = "Megnyomtál";
            Point p = btn_clickme.Location;
            Console.WriteLine(p);
            if (p.X- lepesoldal > 0 && iranybalra && p.Y - lepesfel > 0 && felfele)
            {
                btn_clickme.Location = new Point(btn_clickme.Location.X-20 , btn_clickme.Location.Y - 20);
                Console.WriteLine("Felfele");

            }
            if (p.X + lepesoldal+ btn_clickme.Width < Width && iranybalra && p.Y + lepesfel+ btn_clickme.Height < Height && felfele)
            {
                Console.WriteLine("Lefele");
                btn_clickme.Location = new Point(btn_clickme.Location.X + 20, btn_clickme.Location.Y + 20);

            }

            else
            {
                if (!iranybalra)
                {
                    btn_clickme.Location = new Point(btn_clickme.Location.X-0 , btn_clickme.Location.Y + 20);

                }
                if (!felfele)
                {
                    btn_clickme.Location = new Point(btn_clickme.Location.X + 20, btn_clickme.Location.Y -0);

                }
            }

                if (p.X - lepesoldal < 0)
                {
                    felfele = false;
                     iranybalra = false;

            }
            if (p.Y - lepesfel < 0)
                {
                    iranybalra = false;
                    felfele = false;


            }

        }

        private void btn_hover(object sender, EventArgs e)
        {
            btn_clickme.BackColor = Color.Black;
            btn_clickme.ForeColor = Color.White;
            btn_clickme.Width = 470;


        }

        private void b(object sender, EventArgs e)
        {
            btn_clickme.BackColor = Color.White;
            btn_clickme.ForeColor = Color.Black;
            btn_clickme.Width = 370;

        }
    }
}
