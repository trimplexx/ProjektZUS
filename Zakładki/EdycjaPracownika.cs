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
    // Metoda obsługująca panel edycji pracowników otwierający się po wyborze danego pracownika z listy.
    public partial class EdycjaPracownika : Form
    {
        SqlConnection con = null;
        SqlDataReader reader = null;
        public EdycjaPracownika()
        {
            InitializeComponent();
            Dane(); // Wyświetlenie wpisanych przy tworzeniu pracownika danych
        }
        // Wyświetlanie danych w textBoxach wcześniej utworzonego pracownika 
        public void Dane()
        {
            try
            {
                using (con = new SqlConnection(StaticPomClass.connectionSting))
                {
                    con.Open();
                    // Przekazanie ID pracownika z tablicy, pod odpowiednim indexem wysłanym przez sender przycisku
                    SqlCommand sqlCmd = new SqlCommand($"select ImiePrac, NazwiskoPrac, PeselPrac, DowodPrac, BruttoPrac " +
                        $"from tabWorker where WorkerID='{StaticPomClass.WorkerID[StaticPomClass.Index]}'", con);
                    reader = sqlCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Wpisywanie danych do textBoxów
                        ImieTextBox.Text = reader.GetString(0);
                        NazwiskoTextBox.Text = reader.GetString(1);
                        PeselTextBox.Text = reader.GetString(2);
                        DowodTextBox.Text = reader.GetString(3);
                        BruttoTextBox.Text = reader.GetString(4);
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd przy wczytywaniu pracownika", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Zapisanie zmian wprowadzonych dla pracownika (obsługa przycisku 'Zapisz')
        private void SaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(StaticPomClass.connectionSting))
                {
                    // walidacja długości zmienianych pól
                    if (ImieTextBox.TextLength == 0 || NazwiskoTextBox.TextLength == 0 ||
                        DowodTextBox.TextLength == 0 || BruttoTextBox.TextLength == 0)
                    {
                        MessageBox.Show("Uzupełnij wszystkie pola (sprawdź poprawność peselu)", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        double value;
                        if (double.TryParse(BruttoTextBox.Text.Substring(0, BruttoTextBox.Text.IndexOf(",") + 3), out value))
                        {
                            con.Open();

                            SqlDataAdapter adapter = new SqlDataAdapter();

                            /* string sql będący komendą updatowania poszczególnych zmiennych w bazie danych
                             *  poprzez zczytywanie wartości z TextBoxów, gdzie nazwa użytkownika zgadza się z tą,
                             *  którą się logowaliśmy
                             */
                            string sql = $"Update tabWorker set ImiePrac='{ImieTextBox.Text}'," +
                                        $"NazwiskoPrac='{NazwiskoTextBox.Text}', PeselPrac='{PeselTextBox.Text}'," +
                                        $"DowodPrac='{DowodTextBox.Text}', BruttoPrac='{value}' " +
                                        $"where WorkerID='{StaticPomClass.WorkerID[StaticPomClass.Index]}'";

                            SqlCommand sqlCmd = new SqlCommand(sql, con);
                            adapter.UpdateCommand = new SqlCommand(sql, con);
                            adapter.UpdateCommand.ExecuteNonQuery();
                            sqlCmd.Dispose();

                            MessageBox.Show("Dane zostały pomyślnie zmienione", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            throw new BasicErrorException("Podano wartość zarobków, która nie jest liczbą");
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

        /* Metoda odpowiada za usuwanie wybranego pracownika (obsługuje przycisk usuń)
         */
        private void DeleteWorker_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(StaticPomClass.connectionSting))
                {
                    DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć pracownika?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    // jeśli kliknie się tak, to usunie pracownika
                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        // Usunięcie pracownika z bazy danych
                        SqlCommand sqlCmd = new SqlCommand($"Delete from tabWorker where WorkerID='{StaticPomClass.WorkerID[StaticPomClass.Index]}'", con);
                        reader = sqlCmd.ExecuteReader();
                        Hide();
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
