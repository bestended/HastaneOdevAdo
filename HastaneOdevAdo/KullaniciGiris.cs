using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOdevAdo
{
    public partial class KullaniciGiris : Form
    {
        SqlConnection con;
        public object obj;
        public object returnObject;
        public KullaniciGiris()
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

        private void btn_giris_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            #region
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "kullaniciGirisi";
            cmd.Parameters.AddWithValue("kullaniciAdi", txt_kullaniciAdi.Text);
            cmd.Parameters.AddWithValue("sifre", txt_sifre.Text);
            #endregion
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Hoşgeldiniz");
                Anaform ekran = new Anaform();
                ekran.Show();
            }

            else
            {
                MessageBox.Show("Giriş başarısız");
                txt_kullaniciAdi.Clear();
                txt_sifre.Clear();
            }
            con.Close();



        }




    }
}
