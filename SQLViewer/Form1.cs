using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SQLViewer
{
    public partial class Form1 : Form
    {
        MySqlConnection msqlConn;
        MySqlDataReader msqlDR;

        private string openSucces = "Az adatb�zis sikeresen meg van nyitva ", opennemSucces = "Az adatb�zishoz val� kapcsol�d�s sikertelen", canRead = "Az olvas�s elkezd�d�tt,", closeDb = "Bez�rva";

        enum FormState
        {
            Closed,
            Opened,
            Reading,
            EditInsert,
            EditUpdate
        }
        private FormState formState = FormState.Closed;

        private string insBasic = "Besz�r�s";
        private string insEdit = "Szerkeszt�s v�ge";
        private string updBasic = "M�dos�t�s";
        private string updEdit = "M�dos�t�s v�ge";



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Connect(object sender, EventArgs e)
        {
            MySQLConnect();
        }
        private void MySQLConnect()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "iktat";



            try
            {
                msqlConn = new MySqlConnection(sb.ToString());
                msqlConn.Open();
                MessageBox.Show(openSucces);


            }
            catch (Exception ex)
            {
            }
        }

        private void btxdiscon_Click(object sender, EventArgs e)
        {
            msqlConn.Close();
            MessageBox.Show(closeDb);
        }
    }
}
