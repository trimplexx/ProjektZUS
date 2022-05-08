using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjektZUS
{
    public partial class LoginPanel : Form
    {
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
    }
}