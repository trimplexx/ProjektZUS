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
    public partial class LoginPanel : Form
    {
        public string connectionSting = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserRegistrationDB; Integrated Security=true;";

        public LoginPanel()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }

        private void GoToSingUp_Click(object sender, EventArgs e)
        {
            new SingUpPanel().Show();
            this.Hide();
        }

        public void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPasswordCheckBox.Checked)
                PasswordTextBox.PasswordChar = '\0';

            else
                PasswordTextBox.PasswordChar = '*';

        }

        private void LoginButton(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionSting))
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand("select * from tabUser where Username='" + LoginTextBox.Text + "' and Haslo='" + PasswordTextBox.Text + "'", con);
                SqlDataReader  dr = sqlCmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    new MainWindow().Show();
                    this.Hide();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Wprowadzono zle dane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}