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
        public List<double> Zarobki = new List<double>();
        public Podsumowanie()
        {
            InitializeComponent();
            dataGridView1_CellContentClick();
            //Calculate();
            GetBrutto();
        }

        private void dataGridView1_CellContentClick()
        {
            using (con = new SqlConnection(StaticPomClass.connectionSting))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter($"SELECT * FROM tabWorker where UserIDPrac ='{StaticPomClass.UserID}'", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv1.AutoGenerateColumns = false;
                dgv1.DataSource = dtbl;
                con.Close();
                
            }
        }
        private void GetBrutto()
        {
           
            using (con = new SqlConnection(StaticPomClass.connectionSting))
            {
                con.Open();
                for (int i = 0; i < StaticPomClass.Workers; i++)
                {
                    SqlCommand sqlCmd = new SqlCommand($"SELECT BruttoPrac FROM tabWorker where UserIDPrac ='{StaticPomClass.UserID}' and " +
                                                        $"WorkerID = '{StaticPomClass.WorkerID[i]}'", con);
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    if(reader.Read())
                    {
                        Zarobki.Add(double.Parse(reader.GetString(0)));
                        reader.Close();
                    }
                    reader.Close();
                }
                con.Close ();
            }
        }
    }
}
