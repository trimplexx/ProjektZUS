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
            PasswordTextBox.PasswordChar = '*'; //ukrycie has³a
        }

        // wyœwietlenie panelu rejestracji po klikniêci 'zajestruj siê'
        private void GoToSingUp_Click(object sender, EventArgs e)
        {
            new SingUpPanel().Show();
            Hide();
        }

        // checkBox obs³uguj¹cy ukrycie oraz pokazanie siê has³a
        public void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPasswordCheckBox.Checked)
                PasswordTextBox.PasswordChar = '\0';

            else
                PasswordTextBox.PasswordChar = '*';

        }

        /* Metoda obs³uguje przycisk 'Login' poprzez, który wyszukiwana jest nazwa u¿ytkownika oraz has³o
         * pasuj¹ce do za³o¿onych wczeœniej kont. Po udanym logowaniu zostaje otworzone g³ówne okno programu.
         */
        private void LoginButton(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(StaticPomClass.connectionSting))
                {
                    con.Open();
                    // Komenda sql odpowiadaj¹ca za wyszukiwanie pasuj¹cego u¿ytkownika i jego has³a
                    SqlCommand sqlCmd = new SqlCommand($"select * from tabUser where Username='{LoginTextBox.Text}' and Haslo='{PasswordTextBox.Text}'", con);
                    reader = sqlCmd.ExecuteReader();
                    if (reader.Read()) // gdy uda³o siê znaleŸ pasuj¹ce dane
                    {
                        reader.Close();
                        /* zapisanie userID przy pomocy loginudo zmiennej statycznej potrzebnej w póŸniejszym 
                         * odwo³ywaniu siê w oknach
                         */
                        SqlCommand sqlCmdID = new SqlCommand($"select UserID from tabUser where Username='{LoginTextBox.Text}'", con);
                        reader = sqlCmdID.ExecuteReader();
                        if (reader.Read())
                        {
                            StaticPomClass.UserID = reader.GetInt32(0);
                            reader.Close();
                        }
                        // otworzenie g³ównego okna programu
                        new MainWindow().Show();
                        Hide();
                    }
                    else // gdy nie uda³o siê znaleŸæ pasuj¹cych danych
                    {
                        reader.Close();
                        MessageBox.Show("Wprowadzono zle dane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new BasicErrorException("Ogólny problem z baz¹ danych");
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