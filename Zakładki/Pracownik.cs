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
    // Klasa odpowiada za panel dodawania pracowników do bazy danych
    public partial class Pracownik : Form
    {
        SqlConnection con = null;
        public Pracownik()
        {
            InitializeComponent();
        }

        // Metoda obsługuje dodawanie nowego pracownika do bazy danych.
        private void AddNewWorker_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(StaticPomClass.connectionSting))
                {
                    // Walidacja czy każde pole zostało uzupełnione oraz czy długość numeru pesel jest odpowiednia
                    if (ImieTextBox.TextLength == 0 || NazwiskoTextBox.TextLength == 0 || PeselTextBox.TextLength < 11 ||
                        DowodTextBox.TextLength == 0 || BruttoTextBox.TextLength == 0)
                    {
                        MessageBox.Show("Podany numer pesel jest za krótki, bądź któreś pole nie zostało uzupełnione", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        /* sprawdzanie czy podany numer pesel został już wpisany do bazy danych, tak żeby nie wpisać 2 razy 
                         * ten sam pracownik w jednej firmie.
                         */
                        SqlCommand sqlCmdPesel = new SqlCommand($"select * from tabWorker where PeselPrac='{PeselTextBox.Text}' " +
                            $"and UserIDPrac= '{StaticPomClass.UserID}'", con);
                        SqlDataReader dr = sqlCmdPesel.ExecuteReader();

                        //walidacja numeru pesel, gdyż ten z założenia nie może się powtarzać
                        if (dr.Read())
                        {
                            MessageBox.Show("Podany numer pesel już istnieje w bazie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dr.Close();
                        }
                        else
                        {
                            dr.Close();

                            // Wywołanie query odpowiadającego za dodawanie pracowników do tabeli
                            SqlCommand sqlCmd = new SqlCommand("WorkerAdd3", con);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@ImiePrac", ImieTextBox.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@NazwiskoPrac", NazwiskoTextBox.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@PeselPrac", PeselTextBox.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@DowodPrac", DowodTextBox.Text.Trim());
                            try
                            {
                                sqlCmd.Parameters.AddWithValue("@BruttoPrac", double.Parse(BruttoTextBox.Text));
                            }
                            catch (Exception ex)
                            {
                                throw new BasicErrorException("Podano złą wartość zarobków (Poprawny zapis to np. 123,14)");
                            }
                            sqlCmd.Parameters.AddWithValue("@UserIDPrac", StaticPomClass.UserID); // Przypisanie dla pracownika ID pracodawcy

                            MessageBox.Show("Podany pracownik został pomyślnie dodany", "Info",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            sqlCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new BasicErrorException("Ogólny problem z bazą danych");
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
    }
}
