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
    public partial class Doktorlar : Form
    {
        SqlConnection con;
        public Doktorlar()
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

        private void btn_doktorEkle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "doktorEkle";

            cmd.Parameters.AddWithValue("doktorAdi", txt_doktorAdi.Text);
            cmd.Parameters.AddWithValue("doktorSoyadi", txt_doktorSoyadi.Text);
            cmd.Parameters.AddWithValue("telefon", txt_telefonu.Text);
            cmd.Parameters.AddWithValue("unvan",txt_ünvan.Text);
            cmd.Parameters.AddWithValue("maas",txt_maas.Text);
            cmd.Parameters.AddWithValue("yas",txt_yas.Text);
            int sonuc = cmd.ExecuteNonQuery();
            con.Close();
            #endregion

            if (sonuc > 0)
            {

                MessageBox.Show("Kayıt başarılı");

            }
        }

        private void btn_doktorGüncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "doktorGüncelle";

            cmd.Parameters.AddWithValue("doktorId", txt_doktorAdi.Tag);
            cmd.Parameters.AddWithValue("doktorAdi", txt_doktorAdi.Text);
            cmd.Parameters.AddWithValue("doktorSoyadi", txt_doktorSoyadi.Text);
            cmd.Parameters.AddWithValue("telefon", txt_telefonu.Text);
            cmd.Parameters.AddWithValue("unvan", txt_ünvan.Text);
            cmd.Parameters.AddWithValue("maas", txt_maas.Text);
            cmd.Parameters.AddWithValue("yas", txt_yas.Text);


            int sonuc = cmd.ExecuteNonQuery();
            con.Close();
            #endregion

            if (sonuc > 0)
            {

                MessageBox.Show("Güncelleme başarılı");

            }




        }

        private void btn_doktorSil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "doktorSil";

            cmd.Parameters.AddWithValue("doktorId", txt_doktorAdi.Tag);

            int sonuc = cmd.ExecuteNonQuery();
            con.Close();
            #endregion

            if (sonuc > 0)
            {

                MessageBox.Show("Silme başarılı");

            }
        }

        private void btn_doktorListesi_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "doktorListesi";

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);


            dgwDoktor.DataSource = dttbl;

            #endregion

        }

        private void dgwDoktor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dgwDoktor.CurrentRow;
            txt_doktorAdi.Tag = satir.Cells["doktorId"].Value.ToString();
           
            txt_doktorAdi.Text = satir.Cells["Adı"].Value.ToString();
            txt_doktorSoyadi.Text = satir.Cells["soyad"].Value.ToString();
            txt_telefonu.Text = satir.Cells["Telefon"].Value.ToString();
     
           


        }

        private void txt_doktorArama_MouseClick(object sender, MouseEventArgs e)
        {
            txt_doktorArama.Clear();
        }

        private void btn_doktorAra_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "icindeGecenArama";


            cmd.Parameters.AddWithValue("doktorAdi", txt_doktorArama.Text);

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);
            dgwDoktor.DataSource = dttbl;
            con.Close();



        }

        private void btn_sirala_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "doktorIsimGrupla";

            

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);
            dgwDoktor.DataSource = dttbl;
            con.Close();




        }

        private void btn_raporlarEkraniGetir_Click(object sender, EventArgs e)
        {
            RaporlarEkrani raporEkran = new RaporlarEkrani();
            raporEkran.Show();
            this.Hide();


        }

        //private void txt_hizliAra_KeyDown(object sender, KeyEventArgs e)
        //{

        //    con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "doktorAra";



        //    cmd.Parameters.AddWithValue("doktorAdi", txt_hizliAra.Text);

        //    SqlDataAdapter dta = new SqlDataAdapter(cmd);
        //    DataTable dttbl = new DataTable();

        //    dta.Fill(dttbl);
        //    dgwDoktor.DataSource = dttbl;
        //    con.Close();

        //}

        private void txt_hizliAra_TextChanged(object sender, EventArgs e)
        {


        }

        private void btn_hizliArama_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "doktorAra";



            cmd.Parameters.AddWithValue("doktorAdi", txt_hizliAra.Text);

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);
            dgwDoktor.DataSource = dttbl;
            con.Close();

        }
    }
}