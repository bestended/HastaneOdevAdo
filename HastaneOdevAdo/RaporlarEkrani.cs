using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOdevAdo
{
    public partial class RaporlarEkrani : Form
    {
        SqlConnection con;
        public RaporlarEkrani()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectionStringOlustur());
        }
        public string ConnectionStringOlustur()
        {
            SqlConnectionStringBuilder build = new SqlConnectionStringBuilder();
            #region
            build.DataSource = "DESKTOP-1PBLKBH\\SQLEXPRESS";
            build.InitialCatalog = "Hastaneler";
            build.UserID = "sa";
            build.Password = "12345";
            return build.ConnectionString;
            #endregion
        }
        private void btn_yasOtuzBüyükOrt_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "yasOtuzOrt";

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);


            dgw_Bilgiler.DataSource = dttbl;

            #endregion

          

        }


        private void btn_listeGetir_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "hastaListele";

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);


            dgw_Bilgiler.DataSource = dttbl;

            #endregion



        }

        private void btn_yasOtuzBoyOrt_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "yasOtuzBoyOrt";

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);


            dgw_Bilgiler.DataSource = dttbl;

            #endregion
        }

        private void btn_boySinirYasOrt_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "boyYüzatmisYasOrt";

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);


            dgw_Bilgiler.DataSource = dttbl;

            #endregion
        }

        private void btn_polkIsimUzmSayi_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "polUzmSayi";


            cmd.Parameters.AddWithValue("polIsim", txt_doktorIsimUzmSayi.Text);

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);
            dgw_Bilgiler.DataSource = dttbl;
            con.Close();
        }

        private void btn_polkAdiYatakSayi_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "polYatakSayi";


            cmd.Parameters.AddWithValue("polIsim", txt_polkAdiYatakSayi.Text);

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);
            dgw_Bilgiler.DataSource = dttbl;
            con.Close();
        }

        private void btn_doktorAdiGrup_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "doktorAdGrup";


            //cmd.Parameters.AddWithValue("doktorAd", txt_DrAdiGrup.Text);

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);
            dgw_Bilgiler.DataSource = dttbl;
            con.Close();
        }

        private void btn_unvanYasGrup_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "unvanYas";


            cmd.Parameters.AddWithValue("ünvan", txt_ünvanYasGrup.Text);

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);
            dgw_Bilgiler.DataSource = dttbl;
            con.Close();
        }

        private void btn_unvanMaas_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "unvanMaas";


            cmd.Parameters.AddWithValue("ünvan", txt_ünvanMaas.Text);

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);
            dgw_Bilgiler.DataSource = dttbl;
            con.Close();
        }

        private void btn_raporDurumYasOrt_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "raporYasOrt";


            cmd.Parameters.AddWithValue("raporDurum", txt_raporDurumYas.Text);

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);
            dgw_Bilgiler.DataSource = dttbl;
            con.Close();
        }

        private void btn_sonKayitYüzdeBes_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sonKayitYüzdeBes";

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);


            dgw_Bilgiler.DataSource = dttbl;

            #endregion
        }

        private void btn_yasaGöreGrupSira_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "yasGrupTersSira";

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);


            dgw_Bilgiler.DataSource = dttbl;

            #endregion
        }

        private void btn_polHastaDoktor_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PolHastDoktor";

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);

            con.Close();
            dgw_Bilgiler.DataSource = dttbl;

            #endregion
        }

        private void btn_polHastalar_Click(object sender, EventArgs e)
        {
            con.Open();
           
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "polHastaList";

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);

            con.Close();
            dgw_Bilgiler.DataSource = dttbl;
        
            #endregion
        }

        private void btn_dahiliyeHastalar_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dahiliyeHastalar";

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);

            con.Close();
            dgw_Bilgiler.DataSource = dttbl;

            #endregion
            
        }

        private void btn_yasAraalikPolDoktor_Click(object sender, EventArgs e)
        {

            con.Open()
;            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "yasAraligiPolDoktor";

            cmd.Parameters.AddWithValue("max",Convert.ToInt32(txt_maksYas.Text));
            cmd.Parameters.AddWithValue("min", Convert.ToInt32(txt_minYas.Text));

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);
            con.Close();

            dgw_Bilgiler.DataSource = dttbl;

            #endregion


        }
    }
}
