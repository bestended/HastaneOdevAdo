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
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
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

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "hastaEkle";
          
            cmd.Parameters.AddWithValue("adSoyad", txt_adSoyad.Text);
            cmd.Parameters.AddWithValue("yas", txt_yas.Text);
            cmd.Parameters.AddWithValue("boy", txt_boy.Text);
            cmd.Parameters.AddWithValue("kilo", txt_kilo.Text);
            cmd.Parameters.AddWithValue("RaporDurum", txt_raporDurumu.Text);

            int sonuc=cmd.ExecuteNonQuery();
            con.Close();
            #endregion

            if (sonuc > 0)
            {

                MessageBox.Show("Kayıt başarılı");

            }


        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "hastaGüncelle";

            cmd.Parameters.AddWithValue("hastaNo", txt_adSoyad.Tag);
            cmd.Parameters.AddWithValue("hastaAd", txt_adSoyad.Text);
            cmd.Parameters.AddWithValue("yas", txt_yas.Text);
            cmd.Parameters.AddWithValue("boy", txt_boy.Text);
            cmd.Parameters.AddWithValue("kilo", txt_kilo.Text);
            cmd.Parameters.AddWithValue("RaporDurum", txt_raporDurumu.Text);


            int sonuc = cmd.ExecuteNonQuery();
            con.Close();
            #endregion

            if (sonuc > 0)
            {

                MessageBox.Show("Güncelleme başarılı");

            }



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "hastaSil";

            cmd.Parameters.AddWithValue("hastaNo", txt_adSoyad.Tag);

            int sonuc = cmd.ExecuteNonQuery();
            con.Close();
            #endregion

            if (sonuc > 0)
            {

                MessageBox.Show("Silme başarılı");

            }
        }

        private void btn_liste_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "hastaListele";

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);


            dataGridView1.DataSource = dttbl;

            #endregion

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txt_adSoyad.Tag = satir.Cells["hastaNo"].Value.ToString();
            txt_adSoyad.Text = satir.Cells["adSoyad"].Value.ToString();
            txt_yas.Text = satir.Cells["yas"].Value.ToString();
            txt_boy.Text = satir.Cells["boy"].Value.ToString();
            txt_kilo.Text = satir.Cells["kilo"].Value.ToString();
         




        }

        private void txt_hastaAdi_MouseClick(object sender, MouseEventArgs e)
        {
            txt_hastaAdi.Clear();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "hastaAdSorgu";


            cmd.Parameters.AddWithValue("hastaAdi", txt_hastaAdi.Text);

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);
            dataGridView1.DataSource = dttbl;
            con.Close();



        }
    }
}