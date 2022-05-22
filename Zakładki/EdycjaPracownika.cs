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
    public partial class EdycjaPracownika : Form
    {
        public EdycjaPracownika()
        {
            InitializeComponent();
            Dane();
        }
        public void Dane()
        {
            using (SqlConnection con = new SqlConnection(StaticPomClass.connectionSting))
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand($"select ImiePrac, NazwiskoPrac, PeselPrac, DowodPrac, BruttoPrac " +
                    $"from tabWorker where WorkerID='{StaticPomClass.WorkerID}'", con);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    ImieTextBox.Text = reader.GetString(0);
                    NazwiskoTextBox.Text = reader.GetString(1);
                    PeselTextBox.Text = reader.GetString(2);
                    DowodTextBox.Text = reader.GetString(3);
                    BruttoTextBox.Text = reader.GetString(4);
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

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(StaticPomClass.connectionSting))
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
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    /* string sql będący komendą updatowania poszczególnych zmiennych w bazie danych
                     *  poprzez zczytywanie wartości z TextBoxów, gdzie nazwa użytkownika zgadza się z tą,
                     *  którą się logowaliśmy
                     */
                    string sql = $"Update tabWorker set ImiePrac='{ImieTextBox.Text}'," +
                        $"NazwiskoPrac='{NazwiskoTextBox.Text}', PeselPrac='{PeselTextBox.Text}'," +
                        $"DowodPrac='{DowodTextBox.Text}', BruttoPrac='{BruttoTextBox.Text}' " +
                        $"where WorkerID='{StaticPomClass.WorkerID}'";
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

        private void DeleteWorker_Click(object sender, EventArgs e)
        {

        }
    }
}
