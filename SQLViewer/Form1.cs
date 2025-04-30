using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SQLViewer
{
    public partial class Form1 : Form
    {
        //V�ltoz�k defini�l�sa
        #region Kapcsolat properties
        private MySqlConnection msqlConn;
        private MySqlDataReader msqlDR;
        #endregion
        #region Tarolt eljarasok
        private string userTeljesLista = "usersTeljesLista";
        private string userInsert = "userInsert";
        private string userUpdate = "userUpdate";
        private string userDelete = "userDelete";
        #endregion


        enum FormState
        {
            Closed, // Z�rva , nincs csatlakozva
            Opened, // Adatb�zis csatlakoztatva de olvas�sra nincs megnyitva
            Reading, // Olvas�s k�zben
            EditInsert, // Besz�r�s adatainak be�r�sa k�rben
            EditUpdate  //Rekord szerkezt�se
        }
        private FormState formState = FormState.Closed;

        private string insBasic = "Besz�r�s";
        private string insEdit = "Szerkeszt�s v�ge";
        private string updBasic = "M�dos�t�s";
        private string updEdit = "M�dos�t�s v�ge";


        private string openSikeres = "Az adatb�zis sikeresen meg van nyitva ",
            openNemSikeres = "Az adatb�zishoz val� kapcsol�d�s sikertelen",
            canToRead = "Az olvas�s elkezd�d�tt,",
            closedDB = "Bez�rva";

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
                MessageBox.Show(openSikeres);

                formState = FormState.Opened;

                buttonSwitch(formState);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{openNemSikeres} \n {ex.Message}");
            }
        }
        private void buttonSwitch(FormState fs)
        {
            switch (fs)
            {
                case FormState.Closed:
                    btnCon.Enabled = true;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = false;
                    break;
                case FormState.Opened:
                    btnCon.Enabled = false;
                    btnOpen.Enabled = true;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;

                    tbxID.Enabled = false;
                    tbxNev.Enabled = false;
                    tbxJelszo.Enabled = false;
                    cbxAdmin.Enabled = false;

                    //Gomb feliratok
                    btnInsert.Text = insBasic;
                    btnUpdate.Text = updBasic;
                    break;

                case FormState.Reading:
                    btnCon.Enabled = false;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = true;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClose.Enabled = true;
                    break;
                case FormState.EditInsert:
                    btnCon.Enabled = false;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = true;

                    //beviteli mez�k el�rhet�s�ge
                    tbxNev.Enabled = true;
                    tbxJelszo.Enabled = true;
                    cbxAdmin.Enabled = true;

                    //Beviteli mez�k �r�t�se
                    tbxNev.Text = string.Empty;
                    tbxJelszo.Text = string.Empty;
                    cbxAdmin.Checked = false;

                    //Gomb feliratok
                    btnInsert.Text = insEdit;
                    break;
                case FormState.EditUpdate:
                    btnCon.Enabled = false;
                    btnOpen.Enabled = false;
                    btnRead.Enabled = false;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = false;
                    btnClose.Enabled = true;

                    tbxNev.Enabled = true;
                    tbxJelszo.Enabled = true;
                    cbxAdmin.Enabled = true;

                    //GOmb feliratok
                    btnUpdate.Text = updEdit;
                    break;

            }
        }
        private void btxdiscon_Click(object sender, EventArgs e)
        {
            msqlConn.Close();
            MessageBox.Show(closedDB);

            formState = FormState.Closed;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(userTeljesLista, msqlConn))
            {
                sqlComm.CommandType = System.Data.CommandType.StoredProcedure;

                try
                {
                    msqlDR = sqlComm.ExecuteReader();

                    MessageBox.Show(canToRead);

                    formState = FormState.Reading;
                    buttonSwitch(formState);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void NextUser()
        {
            msqlDR.Read();
            tbxID.Text = msqlDR[0].ToString().Trim();
            tbxNev.Text = msqlDR[1].ToString().Trim();
            tbxJelszo.Text = msqlDR[2].ToString().Trim();
            cbxAdmin.Checked = (bool)msqlDR[3];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.Opened:
                    formState = FormState.EditInsert;
                    buttonSwitch(formState);
                    break;
                case FormState.Reading:
                    msqlDR.Close();
                    formState = FormState.EditInsert;
                    buttonSwitch(formState);
                    break;
                case FormState.EditInsert:
                    InsertUser(tbxNev.Text, tbxJelszo.Text, (cbxAdmin.Checked) ? 1 : 0);
                    formState = FormState.Opened;
                    buttonSwitch(formState);
                    break;
            }
        }

        private void InsertUser(string nev, string jelszo, int admin)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(userInsert, msqlConn))
            {
                sqlComm.CommandType = System.Data.CommandType.StoredProcedure;

                // Param�terek be�ll�t�sa
                MySqlParameter p = new MySqlParameter();
                p.ParameterName = "pNev";
                p.Value = nev;
                p.MySqlDbType = MySqlDbType.String;
                sqlComm.Parameters.Add(p);

                sqlComm.Parameters.AddWithValue("pJelszo", jelszo);

                sqlComm.Parameters.AddWithValue("pAdmin", admin);

                try
                {
                    sqlComm.ExecuteNonQuery();

                    MessageBox.Show("A rekord felv�tele sikeres");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.Opened:
                    formState = FormState.EditUpdate;
                    buttonSwitch(formState);
                    break;
                case FormState.Reading:
                    msqlDR.Close();
                    formState = FormState.EditUpdate;
                    buttonSwitch(formState);
                    break;
                case FormState.EditUpdate:
                    UpdateUser(Convert.ToInt32(tbxID.Text), tbxNev.Text, tbxJelszo.Text, (cbxAdmin.Checked) ? 1 : 0);
                    formState = FormState.Opened;
                    buttonSwitch(formState);
                    break;
            }
        }

        private void UpdateUser(int pID, string pUser, string pJelszo, int pAdmin)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(userInsert, msqlConn))
            {
                sqlComm.CommandType = System.Data.CommandType.StoredProcedure;

                sqlComm.Parameters.AddWithValue("pID", pID);

                MySqlParameter p = new MySqlParameter();
                p.ParameterName = "pNev";
                p.Value = pUser;
                p.MySqlDbType = MySqlDbType.String;
                sqlComm.Parameters.Add(p);

                sqlComm.Parameters.AddWithValue("pJelszo", pJelszo);

                sqlComm.Parameters.AddWithValue("pAdmin", pAdmin);

                try
                {
                    sqlComm.ExecuteNonQuery();

                    MessageBox.Show("A rekord m�dos�t�sa sikeres");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (formState == FormState.Reading)
            {
                msqlDR.Close();
                formState = FormState.Opened;
                buttonSwitch(formState);
            }
            DeleteUser(Convert.ToInt32(tbxID.Text));
        }
        private void DeleteUser(int pID)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(userInsert, msqlConn))
            {
                sqlComm.CommandType = System.Data.CommandType.StoredProcedure;

               
            }
            }
    }
}


