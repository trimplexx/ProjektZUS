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
        private SqlDataReader reader;
        private SqlConnection con = null;
        public LoginPanel()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*'; //ukrycie has�a
        }

        // wy�wietlenie panelu rejestracji po klikni�ci 'zajestruj si�'
        private void GoToSingUp_Click(object sender, EventArgs e)
        {
            new SingUpPanel().Show();
            Hide();
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
            try
            {
                using (con = new SqlConnection(StaticPomClass.connectionSting))
                {
                    con.Open();
                    // Komenda sql odpowiadaj�ca za wyszukiwanie pasuj�cego u�ytkownika i jego has�a
                    SqlCommand sqlCmd = new SqlCommand($"select * from tabUser where Username='{LoginTextBox.Text}' and Haslo='{PasswordTextBox.Text}'", con);
                    reader = sqlCmd.ExecuteReader();
                    if (reader.Read()) // gdy uda�o si� znale� pasuj�ce dane
                    {
                        reader.Close();
                        /* zapisanie userID przy pomocy loginudo zmiennej statycznej potrzebnej w p�niejszym 
                         * odwo�ywaniu si� w oknach
                         */
                        SqlCommand sqlCmdID = new SqlCommand($"select UserID from tabUser where Username='{LoginTextBox.Text}'", con);
                        reader = sqlCmdID.ExecuteReader();
                        if (reader.Read())
                        {
                            StaticPomClass.UserID = reader.GetInt32(0);
                            reader.Close();
                        }
                        // otworzenie g��wnego okna programu
                        new MainWindow().Show();
                        Hide();
                    }
                    else // gdy nie uda�o si� znale�� pasuj�cych danych
                    {
                        reader.Close();
                        MessageBox.Show("Wprowadzono zle dane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new BasicErrorException("Og�lny problem z baz� danych");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if(con != null)
                    con.Close();
            }
        }
    }
}