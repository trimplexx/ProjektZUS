﻿using System;
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
    // Klasa panelu rejestracji użytkowników
    public partial class SingUpPanel : Form
    {
        private SqlDataReader reader;
        private SqlConnection con = null;
        public SingUpPanel()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*'; //ukrycie hasła od początku programu
        }

        //label przechodządzy do panelu logowania
        private void GoToLogin_Click(object sender, EventArgs e)
        {
            new LoginPanel().Show();
            Hide();
        }

        // Przycisk obsługujący wyświetlanie bądź ukrywanie hasła
        public void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
                PasswordTextBox.PasswordChar = '\0';
            else
                PasswordTextBox.PasswordChar = '*';
        }

        
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                //połączenie z bazą danych
                using (con = new SqlConnection(StaticPomClass.connectionSting))
                {
                    // walidacja długości peselu oraz pól
                    if (PeselTextBox.TextLength < 11 || ImieTextBox.TextLength == 0 || NazwiskoTextBox.TextLength == 0 ||
                        LoginTextBox.TextLength == 0 || PasswordTextBox.TextLength == 0)
                    {
                        MessageBox.Show("Podany numer pesel jest za krótki, bądź któreś pole nie zostało uzupełnione", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();

                        //Deklaracja komend do walidacji danych z bazy danych dla peselu oraz nazwy użytkownika.
                        SqlCommand sqlCmdPesel = new SqlCommand($"select * from tabUser where Username='{LoginTextBox.Text}' or Pesel='{PeselTextBox.Text}'", con);
                        reader = sqlCmdPesel.ExecuteReader();

                        //walidacja numeru pesel oraz nazwy użytkownika, gdyż ta z założenia nie może się powtarzać
                        if (reader.Read())
                        {
                            MessageBox.Show("Podany numer pesel, bądź nazwa użytkownika już istnieje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            reader.Close();
                            // Deklaracja komendy dodawania do tabeli w bazie danych
                            SqlCommand sqlCmd = new SqlCommand("UserAdd", con);
                            sqlCmd.CommandType = CommandType.StoredProcedure;

                            // wczytywanie danych rejestracji do bazy danych z pominięciem pustych znaków
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
                            GoToLogin_Click(sender, e);
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
