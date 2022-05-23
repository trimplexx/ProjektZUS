using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProjektZUS
{
    // Klasa panelu logowania
    public partial class LoginPanel : Form
    {

        public LoginPanel()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*'; //ukrycie has�a
        }

        // wy�wietlenie panelu rejestracji po klikni�ci 'zajestruj si�'
        private void GoToSingUp_Click(object sender, EventArgs e)
        {
            new SingUpPanel().Show();
            this.Hide();
        }

        // checkBox obs�uguj�cy ukrycie oraz pokazanie si� has�a
        public void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPasswordCheckBox.Checked)
                PasswordTextBox.PasswordChar = '\0';

            else
                PasswordTextBox.PasswordChar = '*';

        }

        /* Metoda obs�uguje przycisk 'Login' poprzez, kt�ry wyszukiwana jest nazwa u�ytkownika oraz has�o
         * pasuj�ce do za�o�onych wcze�niej kont. Po udanym logowaniu zostaje otworzone g��wne okno programu.
         */
        private void LoginButton(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(StaticPomClass.connectionSting))
            {
                con.Open();
                // Komenda sql odpowiadaj�ca za wyszukiwanie pasuj�cego u�ytkownika i jego has�a
                SqlCommand sqlCmd = new SqlCommand($"select * from tabUser where Username='{LoginTextBox.Text}' and Haslo='{PasswordTextBox.Text}'", con);
                SqlDataReader dr = sqlCmd.ExecuteReader();
                if (dr.Read()) // gdy uda�o si� znale� pasuj�ce dane
                {
                    
                    dr.Close();
                    /* zapisanie userID przy pomocy loginudo zmiennej statycznej potrzebnej w p�niejszym 
                     * odwo�ywaniu si� w oknach
                     */
                    SqlCommand sqlCmdID = new SqlCommand($"select UserID from tabUser where Username='{LoginTextBox.Text}'", con);
                    SqlDataReader reader = sqlCmdID.ExecuteReader();
                    if (reader.Read())
                    {
                        StaticPomClass.UserID = reader.GetInt32(0);
                        reader.Close();
                    }
                    // otworzenie g��wnego okna programu
                    new MainWindow().Show();
                    this.Hide();
                }
                else // gdy nie uda�o si� znale�� pasuj�cych danych
                {
                    dr.Close();
                    MessageBox.Show("Wprowadzono zle dane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}