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
    public partial class MainWindow : Form
    {
        private Form activePanel;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenNewPanel(Form newPanel, object btnSender)
        {
            if (activePanel!= null)
            {
                activePanel.Close();
            }
            activePanel = newPanel;
            newPanel.TopLevel = false;
            newPanel.FormBorderStyle = FormBorderStyle.None;
            newPanel.Dock = DockStyle.Fill;
            this.OknoPanel.Controls.Add(newPanel);
            this.OknoPanel.Tag = newPanel;
            newPanel.BringToFront();
            newPanel.Show();
        }

        private void StronaGlownaButton_Click(object sender, EventArgs e)
        {
            OpenNewPanel(new Zakładki.StronaGlowna(), sender);
            titleLabel.Text = "Strona Główna";
        }

        private void ProfilButton_Click(object sender, EventArgs e)
        {
            OpenNewPanel(new Zakładki.Profil(), sender);
            titleLabel.Text = "Profil";
        }

        private void PracownicyButton_Click(object sender, EventArgs e)
        {
            OpenNewPanel(new Zakładki.Pracownik(), sender);
            titleLabel.Text = "Pracownik";
        }

        private void PodsumowanieButton_Click(object sender, EventArgs e)
        {
            OpenNewPanel(new Zakładki.Podsumowanie(), sender);
            titleLabel.Text = "Podsumowanie";
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            new LoginPanel().Show();
            this.Hide();
        }
    }
}
