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

namespace ProjektZUS.Zakładki
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
            Dane(); // wyświetlenie danych w textBoxach
            PasswordTextBox.PasswordChar = '*'; //bazowe ukrycie hasła

        }

        /* Metoda 'Dane' odpowiada za uzyskiwanie wszystkich informacji o użytkowniku oraz wpisywanie ich 
         * od razu do textBoxów w celu ich podglądu oraz późniejszej ewentualnej zmiany. Wszystkie dane 
         * wyszukiwane są na bazie loginu wpisanego podczas logowania.
         */
        public void Dane()
        {
            using (SqlConnection con = new SqlConnection(StaticPomClass.connectionSting))
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand($"select Imie, Nazwisko, Pesel, Username, Haslo, Dowod, " +
                    $"NIP, REGON from tabUser where UserID='{StaticPomClass.UserID}'", con);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    ImieTextBox.Text = reader.GetString(0);
                    NazwiskoTextBox.Text = reader.GetString(1);
                    PeselTextBox.Text = reader.GetString(2);
                    LoginTextBox.Text = reader.GetString(3);
                    PasswordTextBox.Text = reader.GetString(4);
                    DowodTextBox.Text = reader.GetString(5);
                    NIPtextBox.Text = reader.GetString(6);
                    REGONtextBox.Text = reader.GetString(7);
                    reader.Close();
                    con.Close();
                }
                else
                {
                    reader.Close();
                    con.Close();
                }  
            }
        }

        // Check box do wyświetlania hasła
        private void ShowPasswordCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
                PasswordTextBox.PasswordChar = '\0';

            else
                PasswordTextBox.PasswordChar = '*';
        }

        /* Metoda polega na nadpisywaniu oraz uzupełnianiu pozostałych zmiennych w bazie danych
        * (obsługuje przycisk zapisz). Nie można jednak zmienić loginu oraz numeru pesel ustawionego
        * podczas rejestracji
        */
        private void SaveChanges_click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(StaticPomClass.connectionSting))
            {
                // walidacja długości zmienianych pól
                if ( ImieTextBox.TextLength == 0 || NazwiskoTextBox.TextLength == 0 ||
                     PasswordTextBox.TextLength == 0 || DowodTextBox.TextLength == 0 ||
                    NIPtextBox.TextLength == 0 || REGONtextBox.TextLength == 0)
                {
                    MessageBox.Show("Uzupełnij wszystkie pola", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    /* string sql będący komendą updatowania poszczególnych zmiennych w bazie danych
                     *  poprzez zczytywanie wartości z TextBoxów, gdzie nazwa użytkownika zgadza się z tą,
                     *  którą się logowaliśmy
                     */
                    string sql = $"Update tabUser set Imie='{ImieTextBox.Text}'," +
                        $"Nazwisko= '{NazwiskoTextBox.Text}'," +
                        $"Haslo='{PasswordTextBox.Text}', Dowod='{DowodTextBox.Text}'," +
                        $"NIP='{NIPtextBox.Text}', REGON='{REGONtextBox.Text}'" +
                        $"where UserID='{StaticPomClass.UserID}'";

                    SqlCommand sqlCmd = new SqlCommand(sql, con);
                    adapter.UpdateCommand = new SqlCommand(sql, con);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    sqlCmd.Dispose();
                    con.Close();

                    MessageBox.Show("Dane zostały pomyślnie zmienione", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}