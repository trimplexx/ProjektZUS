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
    // Klasa głównego okna programu
    public partial class MainWindow : Form
    {
        public int NumerOfWorkers { get; set; }
        private string ImiePracownika { get; set; }
        private string NazwiskoPracownika { set; get; }
        private string PeselPracownika { set; get; }

        private SqlDataReader reader;
        private SqlConnection con = null;

        private Form activePanel;
        public MainWindow()
        {
            InitializeComponent();
            OpenNewPanel(new Zakładki.StronaGlowna());
            UsernameLabel(); // Przekazanie imienia do textBoxa pod ikoną profilu
        }

        /* Metoda odpowiadająca za wymianę panelu w głównym oknie na nowy klikając poszczególne przyciski
        * posiadające swoje metody poniżej.
        */
        private void OpenNewPanel(Form newPanel)
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
            OpenNewPanel(new Zakładki.StronaGlowna());
            titleLabel.Text = "Strona Główna";
            UsernameLabel(); // odświeżenie nazwy użytkownika po zmianie
        }

        // Panel profilu użytkownika
        private void ProfilButton_Click(object sender, EventArgs e)
        {
            OpenNewPanel(new Zakładki.Profil());
            titleLabel.Text = "Profil";
            UsernameLabel();
        }

        // Panel pracowników
        private void PracownicyButton_Click(object sender, EventArgs e)
        {
            CountWorkers();
            WorkersOnList();
            // Pokazanie listy pracowników zaraz obok przycisku
            MenuPracownikow.Show(PracownicyButton, PracownicyButton.Width, 0);
            UsernameLabel();
        }

        // Panel przechodzący do podsumowania składek
        private void PodsumowanieButton_Click(object sender, EventArgs e)
        {
            CountWorkers();
            ResetPomColumn("", "a"); // resetowanie kolumny pomocniczej w bazie danych
            for (int i = 0; i < NumerOfWorkers; i++)
            {
                ResetPomColumn($"and PeselPrac='{PeselPracownika}'", "z");
                GetData();
                ResetPomColumn($"and PeselPrac='{PeselPracownika}'", "z");
            }
            OpenNewPanel(new Zakładki.Podsumowanie());
            titleLabel.Text = "Podsumowanie";
            UsernameLabel();
        }

        // Przycisk obsługujący wylogowanie z okna głównego, przechodzi do panelu logowania
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            new LoginPanel().Show();
            Hide();
        }

        /* Metoda przekazuje 'Imie' zalogowanego użytkownika odczytanego ze zmiennej statycznej 
         * do textBoxa pod ikonką usera w lewym górnym rogu okna głównego.
         */
        private void UsernameLabel()
        {
            try
            {
                using (con = new SqlConnection(StaticPomClass.connectionSting))
                {
                    con.Open();
                    // Komenda bazy danych wybierająca zmienną Imie 
                    SqlCommand sqlCmd = new SqlCommand($"select Imie from tabUser where UserID='{StaticPomClass.UserID}'", con);
                    reader = sqlCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox1.Text = reader.GetString(0);
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

        /* Metoda obsługująca dodanie nowego pracownika, otwiera nowe okno, gdzie nalezy wpsisać oraz zapisać dane 
         * aby został on dodany do bazy danych.
         */
        private void AddWorker_Click(object sender, EventArgs e)
        {
            // Liczba pracowników nie może przekroczyć 2999 w danej firmie inaczej przycisk zostanie zablokowany
            if(NumerOfWorkers >  StaticPomClass.WorkerID.Count)
            {
                AddWorker.Enabled = false;
            }
            OpenNewPanel(new Zakładki.Pracownik());
            titleLabel.Text = "Nowy Pracownik";
        }

        // Metoda odpowiada za zliczanie wszystkich pracowników z bazy danych posiadających takie samo ID pracodawcy.
        private void CountWorkers()
        {
            try
            {
                using (con = new SqlConnection(StaticPomClass.connectionSting))
                {
                    con.Open();
                    SqlCommand sqlCmd = new SqlCommand($"SELECT COUNT(1) FROM tabWorker WHERE UserIDPrac='{StaticPomClass.UserID}'", con);
                    reader = sqlCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Przypisanie zwróconej liczby do zmiennej _numOfWorkers
                        NumerOfWorkers = reader.GetInt32(0);
                        StaticPomClass.WorkersNum = NumerOfWorkers;
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
        /* Metoda przypisuje pomocnicze 'a' dla wszystkich komórek w kolumnie pomocniczej w SQL. Jest to metoda pomocnicza w celu późniejszego
         * zczytywania kolejnych pracowników bazdy danych.
        */
        private void ResetPomColumn(string Next, string PomLetter)
        {
            try
            {
                using (con = new SqlConnection(StaticPomClass.connectionSting))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    // Podany string ustawia wszystkie komórki w pomocniczej kolumnie dla pracowników danego użytkownika na wartość 'a'
                    string sql = $"Update tabWorker set PomNum='{PomLetter}' WHERE UserIDPrac='{StaticPomClass.UserID}' {Next}";
                    SqlCommand sqlCmd2 = new SqlCommand(sql, con);
                    adapter.UpdateCommand = new SqlCommand(sql, con);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    sqlCmd2.Dispose();
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

        // Metoda służy pobraniu danych o pracowniku do późniejszego ich użycia przy wyświetlaniu oraz pobraniu pozostałych informacji
        private void GetData()
        {
            try
            {
                using (con = new SqlConnection(StaticPomClass.connectionSting))
                {
                    con.Open();
                    // String wybiera zmienne pierwszego napotkanego pracownika w tabeli, któremu odpowiada numerID użytkownika oraz zmienna pomocnicza
                    SqlCommand sqlCmd = new SqlCommand($"SELECT ImiePrac, NazwiskoPrac, PeselPrac, WorkerID FROM tabWorker WHERE UserIDPrac=" +
                        $"'{StaticPomClass.UserID}' and PomNum='a'", con);

                    reader = sqlCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Tymczasowe przypisanie do zmiennych zczytanych danych z bazy
                        ImiePracownika = reader.GetString(0);
                        NazwiskoPracownika = reader.GetString(1);
                        PeselPracownika = reader.GetString(2); // Zczytanie unikatowego numeru pesel dla pracownika
                        StaticPomClass.WorkerID.Add(reader.GetInt32(3));
                        reader.Close();
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


        /* Metoda służy do tworzenia ToolStripMenuitemów w wysuwanej liście po kliknięciu przycisku pracownicy. Ilość itemów tworzona jest w
        *  zależności od ilości zliczonych pracowników w bazie danych.
        */
        private void WorkersOnList()
        {
            //czyszczenie listy itemów oraz tablicy ID pracowników 
            MenuPracownikow.Items.Clear();
            StaticPomClass.WorkerID.Clear();

            //deklaracja tablicy obiektów zgodna z liczbą pracowników w bazie danych
            ToolStripMenuItem[] workerToolStripMenuItem = new ToolStripMenuItem[NumerOfWorkers];

            ResetPomColumn("", "a") ; // resetowanie kolumny pomocniczej w bazie danych

            // Pętla wykonywana jest tyle razy ilu zliczy pracowników użytkownika. Odpowiada za tworzenie itemów na liście.
            for (int i = 0; i < NumerOfWorkers; i++)
            {
                // Pobranie danych z bazy do uzupełnienia menuItemów
                GetData();

                // Ustawienie kolumny pomocniczej na 'z' aby nie zczytywać tego samego użytkownika ponownie dzięki unikatowemu numerowi pesel
                ResetPomColumn($"and PeselPrac='{PeselPracownika}'", "z");

                    /* Tworzenie MenuItemów wysuwanych w przypadku kliknięcia przycisku 'pracownicy' w MainWindow, Przycisków zostanie utworzona taka ilość,
                     * ile zostało znalezionych pracowników dla danego użytkownika. Do Każdego Itemu przypisane zostaje zczytane imie oraz nazwisko oraz 
                     * metoda odpowiadająca za jego kliknięcie.
                     */
                    workerToolStripMenuItem[i] = new ToolStripMenuItem($"{ImiePracownika}" +
                        $" {NazwiskoPracownika}", null, WorkerToolStripMenuItem_Click, $"Pracownik{i}");
                    MenuPracownikow.Items.Add(workerToolStripMenuItem[i]);
            }
        }

        // Obsługa przycisku wcześniej tworzonych MenuItemów.
        private void WorkerToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            // Numer wciśniętego przycisku zostanie wysłany do zmiennej, która będzie wskazywała index danych pracowników
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                StaticPomClass.Index = MenuPracownikow.Items.IndexOf(item);
            }
            OpenNewPanel(new Zakładki.EdycjaPracownika());
            titleLabel.Text = "Profil Pracownika";
        }
    }
}
