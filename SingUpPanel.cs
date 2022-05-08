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
    public partial class SingUpPanel : Form
    {
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
    }
}
