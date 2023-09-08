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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneOdevAdo
{
    public partial class Klinikler : Form
    {
        SqlConnection con;
        public Klinikler()
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

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "poliklinikEkle";

            cmd.Parameters.AddWithValue("polisim", txt_poliAdi.Text);
            cmd.Parameters.AddWithValue("calisanAdi", txt_calisanAdi.Text);
            cmd.Parameters.AddWithValue("hastaNo", cmb_hastaNom.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("yatakSayisi", txt_yatakSayisi.Text);
            cmd.Parameters.AddWithValue("uzmanSayisi", txt_uzmanSayisi.Text);


            int sonuc = cmd.ExecuteNonQuery();
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
            cmd.CommandText = "poliklinikGüncelle";
           
            cmd.Parameters.AddWithValue("polikId", txt_poliAdi.Tag);
            cmd.Parameters.AddWithValue("polisim", txt_poliAdi.Text);
            cmd.Parameters.AddWithValue("calisanAdi", txt_calisanAdi.Text);
            cmd.Parameters.AddWithValue("hastaNo", cmb_hastaNom.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("yatakSayisi", txt_yatakSayisi.Text);
            cmd.Parameters.AddWithValue("uzmanSayisi", txt_uzmanSayisi.Text);


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
            cmd.CommandText = "polikSil";

            cmd.Parameters.AddWithValue("polikId", txt_poliAdi.Tag);

            int sonuc = cmd.ExecuteNonQuery();
            con.Close();
            #endregion

            if (sonuc > 0)
            {

                MessageBox.Show("Silme başarılı");

            }
        }

        private void btn_tümListe_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "polikListele";

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);


            dgwPoliklinik.DataSource = dttbl;

            #endregion
        }

        private void dgwPoliklinik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dgwPoliklinik.CurrentRow;
            txt_poliAdi.Tag = satir.Cells["polId"].Value.ToString();
            txt_poliAdi.Text = satir.Cells["polIsim"].Value.ToString();
            txt_calisanAdi.Text = satir.Cells["polCalisanAdi"].Value.ToString();
            cmb_hastaNom.Text = satir.Cells["hastaNo"].Value.ToString();
            txt_yatakSayisi.Text = satir.Cells["YatakSayisi"].Value.ToString();
            txt_uzmanSayisi.Text = satir.Cells["uzmanSayisi"].Value.ToString();

        }

        private void Klinikler_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "polikListele";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmb_hastaNom.Items.Add(reader["polId"]);

            }

            con.Close();


        }

        private void btn_arama_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "poliSorgu";
          

            cmd.Parameters.AddWithValue("polIsim",txt_ara.Text);

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);
            dgwPoliklinik.DataSource = dttbl;
            con.Close();


        }

      

        private void txt_ara_MouseClick(object sender, MouseEventArgs e)
        {
            txt_ara.Clear();
        }
    }
}
