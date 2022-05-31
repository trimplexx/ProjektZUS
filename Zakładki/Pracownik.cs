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
        SqlDataReader reader = null;
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
                        reader = sqlCmdPesel.ExecuteReader();

                        //walidacja numeru pesel, gdyż ten z założenia nie może się powtarzać
                        if (reader.Read())
                        {
                            MessageBox.Show("Podany numer pesel już istnieje w bazie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            reader.Close();
                            // Wywołanie query odpowiadającego za dodawanie pracowników do tabeli
                            SqlCommand sqlCmd = new SqlCommand("WorkerAdd3", con);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@ImiePrac", ImieTextBox.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@NazwiskoPrac", NazwiskoTextBox.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@PeselPrac", PeselTextBox.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@DowodPrac", DowodTextBox.Text.Trim());

                            double value;
                            string text = string.Empty;
                            // Walidacja zarobków, sprawdzenie w pierwszej kolejności czy wprowadzono przeciniek
                            if (BruttoTextBox.Text.Contains(","))
                            {
                                // jeśli wprowadzono tylko przecinek i nic po nim to doda '001' aby w późniejszym wczytywaniu wzięło zera po przecinku
                                int num = BruttoTextBox.Text.Length - BruttoTextBox.Text.IndexOf(",");
                                if (num == 1)
                                {
                                    text = BruttoTextBox.Text + "001";
                                }
                                // analogicznie jeśli wpisano jedną wartość po przecinku dopisze '01' aby wzięło 0 we wczytywaniu
                                else if (num == 2)
                                {
                                    text = BruttoTextBox.Text + "01";
                                }
                                // i gdy wpiszemy dwie wartości po przecinku dopisze do nich 1 
                                else if (num == 3)
                                {
                                    text = BruttoTextBox.Text + "1";
                                }
                                if (double.TryParse(text.Substring(0, text.IndexOf(",") + 4), out value))
                                {
                                    sqlCmd.Parameters.AddWithValue("@BruttoPrac", value.ToString());
                                }
                                else
                                {
                                    reader.Close();
                                    con.Close();
                                    throw new BasicErrorException("Podano wartość zarobków, która nie jest liczbą");
                                }
                            }

                            else
                            {
                                // ustawienie przecinka i wartości 001 aby czytało ,00 w konwersji na double
                                text = BruttoTextBox.Text + ",001";
                                if (double.TryParse(text.Substring(0, text.IndexOf(",") + 4), out value))
                                {
                                    sqlCmd.Parameters.AddWithValue("@BruttoPrac", value.ToString());
                                }
                                else
                                {
                                    reader.Close();
                                    con.Close();
                                    throw new BasicErrorException("Podano wartość zarobków, która nie jest liczbą");
                                }
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
                if (reader != null)
                    reader.Close();
                if (con != null)
                    con.Close();
            }
        }
    }
}
