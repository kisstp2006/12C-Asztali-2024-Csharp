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

        private string openSucces = "Az adatbázis sikeresen meg van nyitva ", opennemSucces = "Az adatbázishoz való kapcsolódás sikertelen", canRead = "Az olvasás elkezdõdött,", closeDb = "Bezárva";

        enum FormState
        {
            Closed,
            Opened,
            Reading,
            EditInsert,
            EditUpdate
        }
        private FormState formState = FormState.Closed;

        private string insBasic = "Beszúrás";
        private string insEdit = "Szerkesztés vége";
        private string updBasic = "Módosítás";
        private string updEdit = "Módosítás vége";



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
