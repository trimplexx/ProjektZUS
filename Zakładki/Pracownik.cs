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
    public partial class Pracownik : Form
    {
        public Pracownik()
        {
            InitializeComponent();
        }

        /* Metoda obsługuje dodawanie nowego pracownika do bazy danych.
         */
        private void AddNewWorker_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(StaticPomClass.connectionSting))
            {
                if (ImieTextBox.MaxLength == 0 || NazwiskoTextBox.MaxLength == 0 || PeselTextBox.MaxLength < 11 ||
                    DowodTextBox.MaxLength == 0 || BruttoTextBox.MaxLength == 0)
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
                        SqlCommand sqlCmd = new SqlCommand("WorkerAdd3", con);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ImiePrac", ImieTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@NazwiskoPrac", NazwiskoTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@PeselPrac", PeselTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@DowodPrac", DowodTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@BruttoPrac", BruttoTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@UserIDPrac", StaticPomClass.UserID);
                        MessageBox.Show("Podany pracownik został pomyślnie dodany", "Info",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sqlCmd.ExecuteNonQuery();
                        con.Close();
                        AddNewWorker.Enabled = false;
                    }
                }
            }
        }
    }
}
