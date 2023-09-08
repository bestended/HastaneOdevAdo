using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOdevAdo
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void btn_hastalar_Click(object sender, EventArgs e)
        {

            Form1 frm = new Form1();
            frm.Show();
            this.Hide();




        }

        private void btn_doktorlar_Click(object sender, EventArgs e)
        {
            Doktorlar dktor = new Doktorlar();
            dktor.Show();
            this.Hide();
        }

        private void btn_klinikler_Click(object sender, EventArgs e)
        {

            Klinikler kln = new Klinikler();
            kln.Show();
            this.Hide();


        }

        private void btn_receteler_Click(object sender, EventArgs e)
        {

            Receteler recete = new Receteler();
            recete.Show();
            this.Hide();


        }
    }
}
