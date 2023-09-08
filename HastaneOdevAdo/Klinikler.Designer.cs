namespace HastaneOdevAdo
{
    partial class Klinikler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klinikler));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_poliAdi = new System.Windows.Forms.TextBox();
            this.txt_calisanAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPoliklinikler = new System.Windows.Forms.GroupBox();
            this.dgwPoliklinik = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_tümListe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_hastaNom = new System.Windows.Forms.ComboBox();
            this.btn_arama = new System.Windows.Forms.Button();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.txt_yatakSayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_uzmanSayisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpPoliklinikler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPoliklinik)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poliklinik Adı";
            // 
            // txt_poliAdi
            // 
            this.txt_poliAdi.Location = new System.Drawing.Point(183, 28);
            this.txt_poliAdi.Name = "txt_poliAdi";
            this.txt_poliAdi.Size = new System.Drawing.Size(256, 20);
            this.txt_poliAdi.TabIndex = 1;
            // 
            // txt_calisanAdi
            // 
            this.txt_calisanAdi.Location = new System.Drawing.Point(183, 77);
            this.txt_calisanAdi.Name = "txt_calisanAdi";
            this.txt_calisanAdi.Size = new System.Drawing.Size(256, 20);
            this.txt_calisanAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çalışan Adı";
            // 
            // grpPoliklinikler
            // 
            this.grpPoliklinikler.Controls.Add(this.dgwPoliklinik);
            this.grpPoliklinikler.Location = new System.Drawing.Point(43, 226);
            this.grpPoliklinikler.Name = "grpPoliklinikler";
            this.grpPoliklinikler.Size = new System.Drawing.Size(699, 212);
            this.grpPoliklinikler.TabIndex = 4;
            this.grpPoliklinikler.TabStop = false;
            this.grpPoliklinikler.Text = "Poliklinikler";
            // 
            // dgwPoliklinik
            // 
            this.dgwPoliklinik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPoliklinik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPoliklinik.Location = new System.Drawing.Point(3, 16);
            this.dgwPoliklinik.Name = "dgwPoliklinik";
            this.dgwPoliklinik.Size = new System.Drawing.Size(693, 193);
            this.dgwPoliklinik.TabIndex = 0;
            this.dgwPoliklinik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPoliklinik_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(479, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_güncelle.ForeColor = System.Drawing.Color.Red;
            this.btn_güncelle.Location = new System.Drawing.Point(617, 14);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(122, 41);
            this.btn_güncelle.TabIndex = 6;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.ForeColor = System.Drawing.Color.Red;
            this.btn_sil.Location = new System.Drawing.Point(481, 62);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(81, 35);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_tümListe
            // 
            this.btn_tümListe.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tümListe.ForeColor = System.Drawing.Color.Red;
            this.btn_tümListe.Location = new System.Drawing.Point(617, 62);
            this.btn_tümListe.Name = "btn_tümListe";
            this.btn_tümListe.Size = new System.Drawing.Size(122, 35);
            this.btn_tümListe.TabIndex = 8;
            this.btn_tümListe.Text = "Tüm Liste";
            this.btn_tümListe.UseVisualStyleBackColor = true;
            this.btn_tümListe.Click += new System.EventHandler(this.btn_tümListe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hasta No";
            // 
            // cmb_hastaNom
            // 
            this.cmb_hastaNom.FormattingEnabled = true;
            this.cmb_hastaNom.Location = new System.Drawing.Point(183, 114);
            this.cmb_hastaNom.Name = "cmb_hastaNom";
            this.cmb_hastaNom.Size = new System.Drawing.Size(256, 21);
            this.cmb_hastaNom.TabIndex = 12;
            // 
            // btn_arama
            // 
            this.btn_arama.ForeColor = System.Drawing.Color.Red;
            this.btn_arama.Location = new System.Drawing.Point(481, 118);
            this.btn_arama.Name = "btn_arama";
            this.btn_arama.Size = new System.Drawing.Size(97, 23);
            this.btn_arama.TabIndex = 19;
            this.btn_arama.Text = "ARA";
            this.btn_arama.UseVisualStyleBackColor = true;
            this.btn_arama.Click += new System.EventHandler(this.btn_arama_Click);
            // 
            // txt_ara
            // 
            this.txt_ara.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_ara.Location = new System.Drawing.Point(608, 118);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(134, 20);
            this.txt_ara.TabIndex = 20;
            this.txt_ara.Text = "Poliklinik adı giriniz...";
            this.txt_ara.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_ara_MouseClick);
            // 
            // txt_yatakSayisi
            // 
            this.txt_yatakSayisi.Location = new System.Drawing.Point(183, 153);
            this.txt_yatakSayisi.Name = "txt_yatakSayisi";
            this.txt_yatakSayisi.Size = new System.Drawing.Size(256, 20);
            this.txt_yatakSayisi.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "Yatak Sayısı";
            // 
            // txt_uzmanSayisi
            // 
            this.txt_uzmanSayisi.Location = new System.Drawing.Point(183, 191);
            this.txt_uzmanSayisi.Name = "txt_uzmanSayisi";
            this.txt_uzmanSayisi.Size = new System.Drawing.Size(256, 20);
            this.txt_uzmanSayisi.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "Uzman Sayısı";
            // 
            // Klinikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_uzmanSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_yatakSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ara);
            this.Controls.Add(this.btn_arama);
            this.Controls.Add(this.cmb_hastaNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_tümListe);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpPoliklinikler);
            this.Controls.Add(this.txt_calisanAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_poliAdi);
            this.Controls.Add(this.label1);
            this.Name = "Klinikler";
            this.Text = "Klinikler";
            this.Load += new System.EventHandler(this.Klinikler_Load);
            this.grpPoliklinikler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPoliklinik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_poliAdi;
        private System.Windows.Forms.TextBox txt_calisanAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPoliklinikler;
        private System.Windows.Forms.DataGridView dgwPoliklinik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_tümListe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_hastaNom;
        private System.Windows.Forms.Button btn_arama;
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.TextBox txt_yatakSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_uzmanSayisi;
        private System.Windows.Forms.Label label5;
    }
}