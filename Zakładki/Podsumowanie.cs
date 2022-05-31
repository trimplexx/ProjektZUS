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
    /// <summary>
    /// Klasa podsumowanie odpowiada za wyświetlenie podsumowania firmy pracodawcy
    /// </summary>
    public partial class Podsumowanie : Form
    {
        SqlConnection con = null;
        SqlDataReader reader = null;
        private string imie;
        private string nazwisko;
        private string pesel;
        private string bruttoString;
        private double brutto;
        private double suma;
        private double zdrowotnaSUM;
        private List<string> Skladki = new List<string>();

        //Tablica w której znajdują się oprocentowania poszczególnych składek
        double [] procety = new double[5] {0.0976, 0.015, 0.0245, 0.0167, 0.0245};

  
        public Podsumowanie()
        {
            InitializeComponent();
            FillTabele();//wypełnienie tabeli w podsumowaniu danymi pracownikow oraz wyliczonych składek
            PayTextBoxes();//wypełnienie textboxów kosztami pracodawcy oraz pracowników odpowiednich składek
        }

        // Metoda podsumowanie odpowiada za wyświetlenie tabeli wyliczonych składek
        private void FillTabele()
        {
            //Pętla służąca do wpisywania wszystkich pracowników firmy do dataGridBoxa
            for (int i = 0; i < StaticPomClass.WorkersNum; i++)
            {
                try
                {
                    using (con = new SqlConnection(StaticPomClass.connectionSting))
                    {

                        con.Open();
                        //Przekazanie ID pracownika oraz pracodawcy z tablicy
                        SqlCommand sqlCmd = new SqlCommand($"SELECT ImiePrac, NazwiskoPrac, PeselPrac, BruttoPrac FROM tabWorker WHERE UserIDPrac=" +
                            $"'{StaticPomClass.UserID}' and WorkerID='{StaticPomClass.WorkerID[i]}'", con);

                        reader = sqlCmd.ExecuteReader();
                        if (reader.Read())
                        {
                            //Przekzanie danych z bazdy danych do zmiennych
                            imie = reader.GetString(0);
                            nazwisko = reader.GetString(1);
                            pesel = reader.GetString(2);
                            bruttoString = reader.GetString(3);
                            reader.Close();
                            con.Close();
                        }

                        brutto = double.Parse(bruttoString);
                        
                        //Zliczenie wszystkich wynagrodzeń brutto do zmiennej suma 
                        suma += brutto;

                        //Wyliczenie składki zdrowotnej
                        double zdro = (brutto - (brutto * 0.1371)) * 0.09;
                        string pomString = zdro.ToString();

                        //Zakroąglenie składki zdrowotnej do 2 miejsc po przecinku 
                        string Zdrowotna = pomString.Substring(0, pomString.IndexOf(",") + 3);
                        zdrowotnaSUM += zdro;

                        double JednaSkladka;
                        Skladki.Clear();

                        //Pętla licząca oraz zaokrąglająca poszczęgólne składki do 2 miejsc po przecinku 
                        for (int j = 0; j < 5; j++)
                        {
                            JednaSkladka = brutto * procety[j]; // suma dla pracodawcy
                            string pomSkladka = JednaSkladka.ToString();
                            Skladki.Add(pomSkladka.Substring(0, pomSkladka.IndexOf(",") + 3));
                        }

                        //Wstawienie wyliczonych składek oraz danych pracownika do dataGridView
                        //Emerytalna 9,76% * Brutto
                        //Rentowa 1,5% * Brutto
                        //Chorobowa 2,45% * Brutto
                        //Wypadkowa 1,67% * Brutto
                        //Zdrowotna:
                        //Brutto * 13,71% = zmienna
                        //Brutto - zmienna = zmienna2
                        //Zmienna2 * 9% = wynikzdrowotnej
                        //Funduesz Pracy Brutto * 2,45%
                        dgv1.Rows.Add(i + 1, imie, nazwisko, pesel, bruttoString.Substring(0, bruttoString.IndexOf(",") + 3) + " zł", Skladki[0] + " zł",
                        Skladki[1] + " zł", Skladki[2] + " zł", Skladki[3] + " zł", Zdrowotna + " zł", Skladki[4] + " zł");
                        con.Close();
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

        //Metoda wstawiająca do textBoxów kosztów, które poniesie pracownik oraz pracownicy
        //Koszty pracodawcy:
        //Razem:20,38%*Brutto
        //Koszty pracownika:
        //Razem:(13,71%*brutto)+zdrowotna
        //Razem do zapłaty:
        //Koszty pracodawcy+Koszty Pracownika
        private void PayTextBoxes()
        {
            //Warunek, który sprawdza czy pracodawca posiada pracowników 
            if(suma != 0 || zdrowotnaSUM != 0)
            {
                double UserSum = suma * 0.2038; // suma dla pracodawcy
                string pomString = UserSum.ToString();
                UserPay.Text = pomString.Substring(0, pomString.IndexOf(",") + 3) + " zł";

                double WorkerSum = (0.1371 * suma) + zdrowotnaSUM;
                pomString = WorkerSum.ToString();
                WorkerPay.Text = pomString.Substring(0, pomString.IndexOf(",") + 3) + " zł";

                double razem = UserSum + WorkerSum;
                pomString = razem.ToString();
                Sum.Text = pomString.Substring(0, pomString.IndexOf(",") + 3) + " zł";
            }
        }

        //Metoda służacą do wygenerowania tabeli z podsumowania do programu Excel
        private void exportToExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application wsApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wsBook = wsApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet wsWorksheet = null;
            wsWorksheet = wsBook.ActiveSheet;
            wsWorksheet.Name = "ZusDetail";

            //Zczytywanie wszystkich kolumn tabeli
            for (int i = 1; i < dgv1.Columns.Count + 1; i++)
            {
                wsWorksheet.Cells[1, i] = dgv1.Columns[i - 1].HeaderText;
            }

            //Zczytywanie wszystkich wierszy tabeli 
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                for (int j = 0; j < dgv1.Columns.Count; j++)
                {
                    wsWorksheet.Cells[i + 2, j + 1] = dgv1.Rows[i].Cells[j].Value.ToString();
                }
            }

            //Możliwość zapisania pliku.xlsx w każdym miejscu na komputerze
            var saveFile = new SaveFileDialog();
            saveFile.FileName = "Podsumowanie Zus";//domyślna nazwa zapisywanego pliku
            saveFile.DefaultExt = ".xlsx";//domyślne roszerzenie zapisywanego pliku

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                wsBook.SaveAs(saveFile.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            else
            {
                saveFile.Reset();
            }
            wsApp.Quit();
        }
    }
}
