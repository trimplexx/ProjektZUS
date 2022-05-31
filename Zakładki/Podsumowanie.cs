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
    /// Klasa podsumowanie odpowiada za wyświetlenie tabeli wyliczonych składek
    /// </summary>
    public partial class Podsumowanie : Form
    {
        SqlConnection con = null;
        SqlDataReader reader = null;
        private string imie;
        private string nazwisko;
        private string pesel;
        private double brutto;
        private double suma=0;
        private double zdrowotnaSUM=0;
        private List<string> Skladki = new List<string>();
        double [] procety = new double[5] {0.0976, 0.015, 0.0245, 0.0167, 0.0245};


        public Podsumowanie()
        {
            InitializeComponent();
            FillTabele();
            PayTextBoxes();
        }

        /// <summary>
        /// Klasa podsumowanie odpowiada za wyświetlenie tabeli wyliczonych składek
        /// </summary>
        private void FillTabele()
        {
            for (int i = 0; i < StaticPomClass.WorkersNum; i++)
            {
                try
                {
                    using (con = new SqlConnection(StaticPomClass.connectionSting))
                    {

                        con.Open();
                        SqlCommand sqlCmd = new SqlCommand($"SELECT ImiePrac, NazwiskoPrac, PeselPrac, BruttoPrac FROM tabWorker WHERE UserIDPrac=" +
                            $"'{StaticPomClass.UserID}' and WorkerID='{StaticPomClass.WorkerID[i]}'", con);

                        reader = sqlCmd.ExecuteReader();
                        if (reader.Read())
                        {
                            imie = reader.GetString(0);
                            nazwisko = reader.GetString(1);
                            pesel = reader.GetString(2);
                            brutto = double.Parse(reader.GetString(3));
                            reader.Close();
                            con.Close();
                        }
                        //Emerytalna 9,76% * Brutto
                        //Rentowa 1,5% * Brutto
                        //Chorobowa 2,45% * Brutto
                        //Wypadkowa 1,67% * Brutto
                        //Zdrowotna:
                        //Brutto * 13,71% = zmienna
                        //Brutto - zmienna = zmienna2
                        //Zmienna2 * 9% = wynikzdrowotnej
                        //Funduesz Pracy Brutto * 2,45%
                        
                        suma += brutto;
                        double zdro = (brutto - (brutto * 0.1371)) * 0.09;
                        string pomString = zdro.ToString();
                        string Zdrowotna = pomString.Substring(0, pomString.IndexOf(",") + 3);
                        zdrowotnaSUM += zdro;

                        double JednaSkladka;
                        Skladki.Clear();
                        for (int j = 0; j < 5; j++)
                        {
                            JednaSkladka = brutto * procety[j]; // suma dla pracodawcy
                            string pomSkladka = JednaSkladka.ToString();
                            Skladki.Add(pomSkladka.Substring(0, pomSkladka.IndexOf(",") + 3));
                        }
                        

                    dgv1.Rows.Add(i + 1, imie, nazwisko, pesel, brutto, Skladki[0], Skladki[1], Skladki[2], Skladki[3], zdro, Skladki[4]);
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

        //Koszty pracodawcy:
        //9,76%*Brutto
        //6,5%*Brutto
        //2,45%*Brutto
        //1,67%*Brutto
        //Razem:20,38%*Brutto
        //Koszty pracownika:
        //9,76%*Brutto
        //1,5%*Brutto
        //2,45%*Brutto
        //(brutto - (brutto * 0.1371)) * 0.09
        //Razem:(13,71%*brutto)+zdrowotna
        //Razem do zapłaty:
        //Koszty pracodawcy+Koszty Pracownika
        private void PayTextBoxes()
        {
            double UserSum = suma * 0.2038; // suma dla pracodawcy
            string pomString = UserSum.ToString();
            UserPay.Text = pomString.Substring(0, pomString.IndexOf(",") + 3) + " zł";

            double WorkerSum = (0.1371 * suma) + zdrowotnaSUM;
            pomString = WorkerSum.ToString();
            WorkerPay.Text = pomString.Substring(0, pomString.IndexOf(",") + 3) + " zł";

            double razem = UserSum + WorkerSum;
            pomString= razem.ToString();
            Sum.Text = pomString.Substring(0, pomString.IndexOf(",") + 3) + " zł";
        }
    }
}
