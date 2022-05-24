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
    public partial class Podsumowanie : Form
    {
        SqlConnection con = null;
        SqlDataReader reader = null;
        private string imie;
        private string nazwisko;
        private string pesel;
        private double brutto; 

        public List<double> Zarobki = new List<double>();
        public Podsumowanie()
        {
            InitializeComponent();
            FillTabele();
        }

        private void FillTabele()
        {
            using (con = new SqlConnection(StaticPomClass.connectionSting))
            {
                for (int i = 0; i < StaticPomClass.WorkersNum; i++)
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
                    double zdrowotna = (brutto-(brutto * 0.1371)) * 0.09;
                    dgv1.Rows.Add(i+1,imie, nazwisko, pesel, brutto , brutto*0.0976, brutto*0.015, 
                        brutto*0.0245, brutto*0.0167, zdrowotna , brutto* 0.0245 );
                    con.Close();
                }
            }
        }
    }
}
