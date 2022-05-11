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
    public partial class SingUpPanel : Form
    {
        public string connectionSting = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserRegistrationDB; Integrated Security=true;";

        public SingUpPanel()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }

        private void GoToLogin_Click(object sender, EventArgs e)
        {
            new LoginPanel().Show();
            this.Hide();
        }

        public void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
                PasswordTextBox.PasswordChar = '\0';
            else
                PasswordTextBox.PasswordChar = '*';
        }

        
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionSting))
            {
                // walidacja długości peselu oraz pól
                if(PeselTextBox.TextLength < 11 || ImieTextBox.TextLength == 0 || NazwiskoTextBox.TextLength == 0 || 
                    LoginTextBox.TextLength == 0 || PasswordTextBox.TextLength == 0)
                {
                    MessageBox.Show("Podany numer pesel jest za krótki, bądź któreś pole nie zostało uzupełnione", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    // Deklaracja komendy dodawania do tabeli w bazie danych
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", con);

                    //Deklaracja komend do walidacji danych z bazy danych
                    SqlCommand sqlCmdPesel = new SqlCommand($"select * from tabUser where Username='{LoginTextBox.Text}' or Pesel='{PeselTextBox.Text}'", con);
                    SqlDataReader dr = sqlCmdPesel.ExecuteReader();
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    //walidacja numeru pesel
                    if (dr.Read())
                    {
                        MessageBox.Show("Podany numer pesel, bądź nazwa użytkownika już istnieje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dr.Close();
                    }
                    else
                    {
                        dr.Close();
                        sqlCmd.Parameters.AddWithValue("@Imie", ImieTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Nazwisko", NazwiskoTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Pesel", PeselTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Username", LoginTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Haslo", PasswordTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Dowod", "");
                        sqlCmd.Parameters.AddWithValue("@NIP", "");
                        sqlCmd.Parameters.AddWithValue("@REGON", "");
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Zajerestrowano pomyslnie!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        GoToLogin_Click(sender, e);
                    }
                } 
            }
        }
        //czyszczenie textboxów
        private void Clear()
        {
            ImieTextBox.Text = NazwiskoTextBox.Text = PeselTextBox.Text = LoginTextBox.Text = PasswordTextBox.Text = "";
        }

    }
}
