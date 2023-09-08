namespace HastaneOdevAdo
{
    partial class Doktorlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktorlar));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_doktorAdi = new System.Windows.Forms.TextBox();
            this.txt_doktorSoyadi = new System.Windows.Forms.TextBox();
            this.txt_telefonu = new System.Windows.Forms.TextBox();
            this.btn_doktorEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwDoktor = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_doktorGüncelle = new System.Windows.Forms.Button();
            this.btn_doktorSil = new System.Windows.Forms.Button();
            this.btn_doktorListesi = new System.Windows.Forms.Button();
            this.btn_doktorAra = new System.Windows.Forms.Button();
            this.txt_doktorArama = new System.Windows.Forms.TextBox();
            this.btn_sirala = new System.Windows.Forms.Button();
            this.btn_raporlarEkraniGetir = new System.Windows.Forms.Button();
            this.txt_hizliAra = new System.Windows.Forms.TextBox();
            this.btn_hizliArama = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ünvan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_yas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoktor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktorun Adı";
            // 
            // txt_doktorAdi
            // 
            this.txt_doktorAdi.Location = new System.Drawing.Point(175, 13);
            this.txt_doktorAdi.Name = "txt_doktorAdi";
            this.txt_doktorAdi.Size = new System.Drawing.Size(168, 20);
            this.txt_doktorAdi.TabIndex = 1;
            // 
            // txt_doktorSoyadi
            // 
            this.txt_doktorSoyadi.Location = new System.Drawing.Point(175, 52);
            this.txt_doktorSoyadi.Name = "txt_doktorSoyadi";
            this.txt_doktorSoyadi.Size = new System.Drawing.Size(168, 20);
            this.txt_doktorSoyadi.TabIndex = 3;
            // 
            // txt_telefonu
            // 
            this.txt_telefonu.Location = new System.Drawing.Point(175, 88);
            this.txt_telefonu.Name = "txt_telefonu";
            this.txt_telefonu.Size = new System.Drawing.Size(168, 20);
            this.txt_telefonu.TabIndex = 5;
            // 
            // btn_doktorEkle
            // 
            this.btn_doktorEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_doktorEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doktorEkle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_doktorEkle.ForeColor = System.Drawing.Color.Red;
            this.btn_doktorEkle.Location = new System.Drawing.Point(34, 227);
            this.btn_doktorEkle.Name = "btn_doktorEkle";
            this.btn_doktorEkle.Size = new System.Drawing.Size(117, 55);
            this.btn_doktorEkle.TabIndex = 6;
            this.btn_doktorEkle.Text = "Doktor Ekle";
            this.btn_doktorEkle.UseVisualStyleBackColor = false;
            this.btn_doktorEkle.Click += new System.EventHandler(this.btn_doktorEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwDoktor);
            this.groupBox1.Location = new System.Drawing.Point(380, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 228);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgileri";
            // 
            // dgwDoktor
            // 
            this.dgwDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwDoktor.Location = new System.Drawing.Point(3, 16);
            this.dgwDoktor.Name = "dgwDoktor";
            this.dgwDoktor.Size = new System.Drawing.Size(582, 209);
            this.dgwDoktor.TabIndex = 0;
            this.dgwDoktor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDoktor_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Doktorun Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Doktorun Telefonu";
            // 
            // btn_doktorGüncelle
            // 
            this.btn_doktorGüncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_doktorGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doktorGüncelle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_doktorGüncelle.ForeColor = System.Drawing.Color.Red;
            this.btn_doktorGüncelle.Location = new System.Drawing.Point(197, 227);
            this.btn_doktorGüncelle.Name = "btn_doktorGüncelle";
            this.btn_doktorGüncelle.Size = new System.Drawing.Size(117, 55);
            this.btn_doktorGüncelle.TabIndex = 13;
            this.btn_doktorGüncelle.Text = "Doktor Güncelle";
            this.btn_doktorGüncelle.UseVisualStyleBackColor = false;
            this.btn_doktorGüncelle.Click += new System.EventHandler(this.btn_doktorGüncelle_Click);
            // 
            // btn_doktorSil
            // 
            this.btn_doktorSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_doktorSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doktorSil.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_doktorSil.ForeColor = System.Drawing.Color.Red;
            this.btn_doktorSil.Location = new System.Drawing.Point(34, 288);
            this.btn_doktorSil.Name = "btn_doktorSil";
            this.btn_doktorSil.Size = new System.Drawing.Size(117, 57);
            this.btn_doktorSil.TabIndex = 14;
            this.btn_doktorSil.Text = "Doktor Sil";
            this.btn_doktorSil.UseVisualStyleBackColor = false;
            this.btn_doktorSil.Click += new System.EventHandler(this.btn_doktorSil_Click);
            // 
            // btn_doktorListesi
            // 
            this.btn_doktorListesi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_doktorListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doktorListesi.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_doktorListesi.ForeColor = System.Drawing.Color.Red;
            this.btn_doktorListesi.Location = new System.Drawing.Point(197, 288);
            this.btn_doktorListesi.Name = "btn_doktorListesi";
            this.btn_doktorListesi.Size = new System.Drawing.Size(117, 57);
            this.btn_doktorListesi.TabIndex = 15;
            this.btn_doktorListesi.Text = "Doktor Listesi";
            this.btn_doktorListesi.UseVisualStyleBackColor = false;
            this.btn_doktorListesi.Click += new System.EventHandler(this.btn_doktorListesi_Click);
            // 
            // btn_doktorAra
            // 
            this.btn_doktorAra.ForeColor = System.Drawing.Color.Red;
            this.btn_doktorAra.Location = new System.Drawing.Point(380, 40);
            this.btn_doktorAra.Name = "btn_doktorAra";
            this.btn_doktorAra.Size = new System.Drawing.Size(75, 23);
            this.btn_doktorAra.TabIndex = 16;
            this.btn_doktorAra.Text = "ARA";
            this.btn_doktorAra.UseVisualStyleBackColor = true;
            this.btn_doktorAra.Click += new System.EventHandler(this.btn_doktorAra_Click);
            // 
            // txt_doktorArama
            // 
            this.txt_doktorArama.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_doktorArama.Location = new System.Drawing.Point(507, 42);
            this.txt_doktorArama.Name = "txt_doktorArama";
            this.txt_doktorArama.Size = new System.Drawing.Size(239, 20);
            this.txt_doktorArama.TabIndex = 17;
            this.txt_doktorArama.Text = "Doktor ismini giriniz...";
            this.txt_doktorArama.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_doktorArama_MouseClick);
            // 
            // btn_sirala
            // 
            this.btn_sirala.ForeColor = System.Drawing.Color.Red;
            this.btn_sirala.Location = new System.Drawing.Point(383, 96);
            this.btn_sirala.Name = "btn_sirala";
            this.btn_sirala.Size = new System.Drawing.Size(134, 23);
            this.btn_sirala.TabIndex = 19;
            this.btn_sirala.Text = "İsme göre sırala";
            this.btn_sirala.UseVisualStyleBackColor = true;
            this.btn_sirala.Click += new System.EventHandler(this.btn_sirala_Click);
            // 
            // btn_raporlarEkraniGetir
            // 
            this.btn_raporlarEkraniGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_raporlarEkraniGetir.ForeColor = System.Drawing.Color.Red;
            this.btn_raporlarEkraniGetir.Location = new System.Drawing.Point(764, 12);
            this.btn_raporlarEkraniGetir.Name = "btn_raporlarEkraniGetir";
            this.btn_raporlarEkraniGetir.Size = new System.Drawing.Size(100, 107);
            this.btn_raporlarEkraniGetir.TabIndex = 20;
            this.btn_raporlarEkraniGetir.Text = "Raporlar Ekranı";
            this.btn_raporlarEkraniGetir.UseVisualStyleBackColor = true;
            this.btn_raporlarEkraniGetir.Click += new System.EventHandler(this.btn_raporlarEkraniGetir_Click);
            // 
            // txt_hizliAra
            // 
            this.txt_hizliAra.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_hizliAra.Location = new System.Drawing.Point(637, 101);
            this.txt_hizliAra.Name = "txt_hizliAra";
            this.txt_hizliAra.Size = new System.Drawing.Size(100, 20);
            this.txt_hizliAra.TabIndex = 21;
            this.txt_hizliAra.Text = "Hızlı Ara";
            this.txt_hizliAra.TextChanged += new System.EventHandler(this.txt_hizliAra_TextChanged);
            // 
            // btn_hizliArama
            // 
            this.btn_hizliArama.Location = new System.Drawing.Point(556, 98);
            this.btn_hizliArama.Name = "btn_hizliArama";
            this.btn_hizliArama.Size = new System.Drawing.Size(75, 23);
            this.btn_hizliArama.TabIndex = 22;
            this.btn_hizliArama.Text = "Hızlı Arama";
            this.btn_hizliArama.UseVisualStyleBackColor = true;
            this.btn_hizliArama.Click += new System.EventHandler(this.btn_hizliArama_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Doktorun Unvanı";
            // 
            // txt_ünvan
            // 
            this.txt_ünvan.Location = new System.Drawing.Point(177, 122);
            this.txt_ünvan.Name = "txt_ünvan";
            this.txt_ünvan.Size = new System.Drawing.Size(168, 20);
            this.txt_ünvan.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Doktorun Maaşı";
            // 
            // txt_maas
            // 
            this.txt_maas.Location = new System.Drawing.Point(177, 158);
            this.txt_maas.Name = "txt_maas";
            this.txt_maas.Size = new System.Drawing.Size(168, 20);
            this.txt_maas.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Doktorun Yaşı";
            // 
            // txt_yas
            // 
            this.txt_yas.Location = new System.Drawing.Point(177, 193);
            this.txt_yas.Name = "txt_yas";
            this.txt_yas.Size = new System.Drawing.Size(168, 20);
            this.txt_yas.TabIndex = 27;
            // 
            // Doktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 375);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_yas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_maas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ünvan);
            this.Controls.Add(this.btn_hizliArama);
            this.Controls.Add(this.txt_hizliAra);
            this.Controls.Add(this.btn_raporlarEkraniGetir);
            this.Controls.Add(this.btn_sirala);
            this.Controls.Add(this.txt_doktorArama);
            this.Controls.Add(this.btn_doktorAra);
            this.Controls.Add(this.btn_doktorListesi);
            this.Controls.Add(this.btn_doktorSil);
            this.Controls.Add(this.btn_doktorGüncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_doktorEkle);
            this.Controls.Add(this.txt_telefonu);
            this.Controls.Add(this.txt_doktorSoyadi);
            this.Controls.Add(this.txt_doktorAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Doktorlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktorlar";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoktor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_doktorAdi;
        private System.Windows.Forms.TextBox txt_doktorSoyadi;
        private System.Windows.Forms.TextBox txt_telefonu;
        private System.Windows.Forms.Button btn_doktorEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwDoktor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_doktorGüncelle;
        private System.Windows.Forms.Button btn_doktorSil;
        private System.Windows.Forms.Button btn_doktorListesi;
        private System.Windows.Forms.Button btn_doktorAra;
        private System.Windows.Forms.TextBox txt_doktorArama;
        private System.Windows.Forms.Button btn_sirala;
        private System.Windows.Forms.Button btn_raporlarEkraniGetir;
        private System.Windows.Forms.TextBox txt_hizliAra;
        private System.Windows.Forms.Button btn_hizliArama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ünvan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_yas;
    }
}