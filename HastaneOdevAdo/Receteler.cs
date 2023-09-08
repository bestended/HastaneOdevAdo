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
    public partial class Receteler : Form
    {

        SqlConnection con;
        public Receteler()
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

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "receteEkle";

            cmd.Parameters.AddWithValue("tanim", txt_tanim.Text);
            cmd.Parameters.AddWithValue("aciklama", txt_aciklama.Text);
            cmd.Parameters.AddWithValue("tarih", Convert.ToDateTime(dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("doktorId", cmb_doktorNo.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("hastaNo", cmb_hastaNo.SelectedItem.ToString());

            int sonuc = cmd.ExecuteNonQuery();
            con.Close();
            #endregion
            
            if (sonuc > 0)
            {

                MessageBox.Show("Kayıt başarılı");

            }
        }

        private void Receteler_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "receteListe";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmb_doktorNo.Items.Add(reader["doktorId"]);
                cmb_hastaNo.Items.Add(reader["hastaNo"]);


            }

            con.Close();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "receteGüncelle";

            cmd.Parameters.AddWithValue("receteId",txt_tanim.Tag);
            cmd.Parameters.AddWithValue("tanim", txt_tanim.Text);
            cmd.Parameters.AddWithValue("aciklama", txt_aciklama.Text);
            cmd.Parameters.AddWithValue("tarih", Convert.ToDateTime(dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("doktorId", cmb_doktorNo.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("hastaNo", cmb_hastaNo.SelectedItem.ToString());

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
            cmd.CommandText = "receteSil";

            cmd.Parameters.AddWithValue("receteId", txt_tanim.Tag);

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
            cmd.CommandText = "receteListe";

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);


            dgw_receteler.DataSource = dttbl;

            #endregion
        }

        private void dgw_receteler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dgw_receteler.CurrentRow;
            txt_tanim.Tag = satir.Cells["receteId"].Value.ToString();
            txt_tanim.Text = satir.Cells["tanim"].Value.ToString();
            txt_aciklama.Text = satir.Cells["aciklama"].Value.ToString();
            dateTimePicker1.Text = satir.Cells["tarih"].Value.ToString();


        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "receteSorgu";


            cmd.Parameters.AddWithValue("tanim", txt_tanimArama.Text);

            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dttbl = new DataTable();

            dta.Fill(dttbl);
            dgw_receteler.DataSource = dttbl;
            con.Close();



        }

        private void txt_tanimArama_MouseClick(object sender, MouseEventArgs e)
        {
            txt_tanimArama.Clear();
        }
    }
}
