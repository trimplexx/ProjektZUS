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
    public partial class MainWindow : Form
    {
        public int _numerOfWorkers;
        private Form activePanel;
        public MainWindow()
        {
            InitializeComponent();
            UsernameLabel();
        }

        /* Metoda odpowiadająca za wymianę panelu w głównym oknie na nowy klikając poszczególne przyciski
        * posiadające swoje metody poniżej.
        */
        private void OpenNewPanel(Form newPanel, object btnSender)
        {
            if (activePanel != null)
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

        // Panel strona główna
        private void StronaGlownaButton_Click(object sender, EventArgs e)
        {
            OpenNewPanel(new Zakładki.StronaGlowna(), sender);
            UsernameLabel();
            titleLabel.Text = "Strona Główna";
        }

        // Panel profilu użytkownika
        private void ProfilButton_Click(object sender, EventArgs e)
        {
            OpenNewPanel(new Zakładki.Profil(), sender);
            UsernameLabel();
            titleLabel.Text = "Profil";
        }

        // Panel pracowników
        private void PracownicyButton_Click(object sender, EventArgs e)
        {
            UsernameLabel();
            CountWorkers();
            WorkersOnList();
            MenuPracownikow.Show(PracownicyButton, PracownicyButton.Width, 0);
        }

        // Panel przechodzący do podsumowania składek
        private void PodsumowanieButton_Click(object sender, EventArgs e)
        {
            OpenNewPanel(new Zakładki.Podsumowanie(), sender);
            UsernameLabel();
            titleLabel.Text = "Podsumowanie";
        }

        // Przycisk obsługujący wylogowanie z okna głównego, przechodzi do panelu logowania
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            new LoginPanel().Show();
            this.Hide();
        }

        /* Metoda przekazuje 'Imie' zalogowanego użytkownika odczytanego ze zmiennej statycznej 
         * do textBoxa pod ikonką usera w lewym górnym rogu okna głównego.
         */
        private void UsernameLabel()
        {
            using (SqlConnection con = new SqlConnection(StaticPomClass.connectionSting))
            {
                con.Open();
                // Komenda bazy danych wybierająca zmienną Imie 
                SqlCommand sqlCmd = new SqlCommand($"select Imie from tabUser where UserID='{StaticPomClass.UserID}'", con);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader.GetString(0);
                    reader.Close();
                    con.Close();
                }
            }
        }

        /* Metoda obsługująca dodanie nowego pracownika, otwiera nowe okno, gdzie nalezy wpsisać oraz zapisać dane 
         * aby został on dodany do bazy danych.
         */
        private void AddWorker_Click(object sender, EventArgs e)
        {
            if(_numerOfWorkers >  299)
            {
                AddWorker.Enabled = false;
            }
            OpenNewPanel(new Zakładki.Pracownik(), sender);
            titleLabel.Text = "Nowy Pracownik";
        }

        // Metoda odpowiada za zliczanie wszystkich pracowników z bazy danych posiadających takie samo ID pracodawcy.
        private void CountWorkers()
        {
            using (SqlConnection con = new SqlConnection(StaticPomClass.connectionSting))
            {
                con.Open();
                SqlCommand sqlCmd = new SqlCommand($"SELECT COUNT(1) FROM tabWorker WHERE UserIDPrac='{StaticPomClass.UserID}'", con);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    _numerOfWorkers = reader.GetInt32(0);
                    reader.Close();
                    con.Close();
                }
            }
        }

        private void WorkersOnList()
        {
            //czyszczenie listy itemów oraz tablicy ID pracowników 
            MenuPracownikow.Items.Clear();
            Array.Clear(StaticPomClass.WorkerID);

            //deklaracja tablicy obiektów zgodna z liczbą pracowników w bazie danych
            ToolStripMenuItem[] workerToolStripMenuItem = new ToolStripMenuItem[_numerOfWorkers];

            using (SqlConnection con = new SqlConnection(StaticPomClass.connectionSting))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                // Podany string ustawia wszystkie komórki w pomocniczej kolumnie dla pracowników danego użytkownika na wartość 'a'
                string sql = $"Update tabWorker set PomNum='a'WHERE UserIDPrac='{StaticPomClass.UserID}'";
                SqlCommand sqlCmd2 = new SqlCommand(sql, con);
                adapter.UpdateCommand = new SqlCommand(sql, con);
                adapter.UpdateCommand.ExecuteNonQuery();
                sqlCmd2.Dispose();
            }
            // Pętla wykonywana jest tyle razy ilu zliczy pracowników użytkownika
            for (int i = 0; i < _numerOfWorkers; i++)
            {
                using (SqlConnection con = new SqlConnection(StaticPomClass.connectionSting))
                {
                    con.Open();

                    // String wybiera zmienne pierwszego napotkanego pracownika w tabeli, któremu odpowiada numerID użytkownika oraz zmienna pomocnicza
                    SqlCommand sqlCmd = new SqlCommand($"SELECT ImiePrac, NazwiskoPrac, PeselPrac, WorkerID FROM tabWorker WHERE UserIDPrac=" +
                        $"'{StaticPomClass.UserID}' and PomNum='a'", con);
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        StaticPomClass.ImiePracownika = reader.GetString(0);
                        StaticPomClass.NaziwskoPracownika = reader.GetString(1);
                        StaticPomClass.PeselPrac = reader.GetString(2);
                        StaticPomClass.WorkerID[i] = reader.GetInt32(3);
                        reader.Close();

                        // Zmienna pomocnicza następnie ulega zmianie aby ciągle nie był brany ten sam pracownik
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        string sql = $"Update tabWorker set PomNum='z' where ImiePrac='{StaticPomClass.ImiePracownika}' and" +
                            $" NazwiskoPrac='{StaticPomClass.NaziwskoPracownika}' and PeselPrac='{StaticPomClass.PeselPrac}'";
                        SqlCommand sqlCmd2 = new SqlCommand(sql, con);
                        adapter.UpdateCommand = new SqlCommand(sql, con);
                        adapter.UpdateCommand.ExecuteNonQuery();
                        sqlCmd2.Dispose();
                        con.Close();
                    }
                }
                /* Tworzenie MenuItemów wysuwanych w przypadku kliknięcia przycisku 'pracownicy' w MainWindow, Przycisków zostanie utworzona taka ilość,
                 * ile zostało znalezionych pracowników dla danego użytkownika. Do Każdego Itemu przypisane zostaje zczytane imie oraz nazwisko oraz 
                 * metoda odpowiadająca za jego kliknięcie.
                 */
                workerToolStripMenuItem[i] = new ToolStripMenuItem($"{StaticPomClass.ImiePracownika}" +
                    $" {StaticPomClass.NaziwskoPracownika}", null, WorkerToolStripMenuItem_Click, $"Pracownik{i}");
                MenuPracownikow.Items.Add(workerToolStripMenuItem[i]);
            }
        }

        // Obsługa przycisku wcześniej tworzonych MenuItemów 
        private void WorkerToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            // Numer wciśniętego przycisku zostanie wysłany do zmiennej, która będzie wskazywała index danych pracowników
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                StaticPomClass.Index = MenuPracownikow.Items.IndexOf(item);
            }
            OpenNewPanel(new Zakładki.EdycjaPracownika(), sender);
            titleLabel.Text = "Profil Pracownika";
        }
    }
}
