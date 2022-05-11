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
                con.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAdd", con);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Imie", ImieTextBox.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Nazwisko", NazwiskoTextBox.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Pesel", PeselTextBox.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Username", LoginTextBox.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Haslo", PasswordTextBox.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Dowod", textBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@NIP", textBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@REGON", textBox1.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Zajerestrowano pomyslnie!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                GoToLogin_Click(sender,e);
            }
        }
        private void Clear()
        {
            ImieTextBox.Text = NazwiskoTextBox.Text = PeselTextBox.Text = LoginTextBox.Text = PasswordTextBox.Text = "";
        }

    }
}
