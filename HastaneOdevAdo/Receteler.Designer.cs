namespace HastaneOdevAdo
{
    partial class Receteler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receteler));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tanim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_receteler = new System.Windows.Forms.DataGridView();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_tümListe = new System.Windows.Forms.Button();
            this.cmb_doktorNo = new System.Windows.Forms.ComboBox();
            this.cmb_hastaNo = new System.Windows.Forms.ComboBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_tanimArama = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_receteler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanım";
            // 
            // txt_tanim
            // 
            this.txt_tanim.Location = new System.Drawing.Point(176, 20);
            this.txt_tanim.Name = "txt_tanim";
            this.txt_tanim.Size = new System.Drawing.Size(194, 20);
            this.txt_tanim.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_receteler);
            this.groupBox1.Location = new System.Drawing.Point(448, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 349);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reçete Listesi";
            // 
            // dgw_receteler
            // 
            this.dgw_receteler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_receteler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_receteler.Location = new System.Drawing.Point(3, 16);
            this.dgw_receteler.Name = "dgw_receteler";
            this.dgw_receteler.Size = new System.Drawing.Size(486, 330);
            this.dgw_receteler.TabIndex = 0;
            this.dgw_receteler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_receteler_CellClick);
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(176, 58);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(194, 20);
            this.txt_aciklama.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(46, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(46, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(46, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doktor No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(46, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hasta No";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ekle.ForeColor = System.Drawing.Color.Red;
            this.btn_ekle.Location = new System.Drawing.Point(42, 270);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(121, 38);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_güncelle.ForeColor = System.Drawing.Color.Red;
            this.btn_güncelle.Location = new System.Drawing.Point(205, 270);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(165, 38);
            this.btn_güncelle.TabIndex = 13;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.ForeColor = System.Drawing.Color.Red;
            this.btn_sil.Location = new System.Drawing.Point(42, 335);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(121, 39);
            this.btn_sil.TabIndex = 14;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_tümListe
            // 
            this.btn_tümListe.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tümListe.ForeColor = System.Drawing.Color.Red;
            this.btn_tümListe.Location = new System.Drawing.Point(205, 335);
            this.btn_tümListe.Name = "btn_tümListe";
            this.btn_tümListe.Size = new System.Drawing.Size(165, 39);
            this.btn_tümListe.TabIndex = 15;
            this.btn_tümListe.Text = "TÜM LİSTE";
            this.btn_tümListe.UseVisualStyleBackColor = true;
            this.btn_tümListe.Click += new System.EventHandler(this.btn_tümListe_Click);
            // 
            // cmb_doktorNo
            // 
            this.cmb_doktorNo.FormattingEnabled = true;
            this.cmb_doktorNo.Location = new System.Drawing.Point(176, 153);
            this.cmb_doktorNo.Name = "cmb_doktorNo";
            this.cmb_doktorNo.Size = new System.Drawing.Size(194, 21);
            this.cmb_doktorNo.TabIndex = 16;
            // 
            // cmb_hastaNo
            // 
            this.cmb_hastaNo.FormattingEnabled = true;
            this.cmb_hastaNo.Location = new System.Drawing.Point(176, 206);
            this.cmb_hastaNo.Name = "cmb_hastaNo";
            this.cmb_hastaNo.Size = new System.Drawing.Size(194, 21);
            this.cmb_hastaNo.TabIndex = 17;
            // 
            // btn_ara
            // 
            this.btn_ara.ForeColor = System.Drawing.Color.Red;
            this.btn_ara.Location = new System.Drawing.Point(448, 20);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(130, 23);
            this.btn_ara.TabIndex = 18;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_tanimArama
            // 
            this.txt_tanimArama.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_tanimArama.Location = new System.Drawing.Point(618, 20);
            this.txt_tanimArama.Name = "txt_tanimArama";
            this.txt_tanimArama.Size = new System.Drawing.Size(232, 20);
            this.txt_tanimArama.TabIndex = 19;
            this.txt_tanimArama.Text = "Aranacak tanımı giriniz...";
            this.txt_tanimArama.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_tanimArama_MouseClick);
            // 
            // Receteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.txt_tanimArama);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.cmb_hastaNo);
            this.Controls.Add(this.cmb_doktorNo);
            this.Controls.Add(this.btn_tümListe);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_tanim);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Receteler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receteler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Receteler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_receteler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tanim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_receteler;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_tümListe;
        private System.Windows.Forms.ComboBox cmb_doktorNo;
        private System.Windows.Forms.ComboBox cmb_hastaNo;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_tanimArama;
    }
}