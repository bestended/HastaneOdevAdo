namespace HastaneOdevAdo
{
    partial class Anaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anaform));
            this.btn_hastalar = new System.Windows.Forms.Button();
            this.btn_klinikler = new System.Windows.Forms.Button();
            this.btn_doktorlar = new System.Windows.Forms.Button();
            this.btn_receteler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hastalar
            // 
            this.btn_hastalar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hastalar.BackgroundImage")));
            this.btn_hastalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hastalar.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hastalar.ForeColor = System.Drawing.Color.White;
            this.btn_hastalar.Location = new System.Drawing.Point(12, 12);
            this.btn_hastalar.Name = "btn_hastalar";
            this.btn_hastalar.Size = new System.Drawing.Size(272, 145);
            this.btn_hastalar.TabIndex = 0;
            this.btn_hastalar.Text = "HASTALAR";
            this.btn_hastalar.UseVisualStyleBackColor = true;
            this.btn_hastalar.Click += new System.EventHandler(this.btn_hastalar_Click);
            // 
            // btn_klinikler
            // 
            this.btn_klinikler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_klinikler.BackgroundImage")));
            this.btn_klinikler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_klinikler.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_klinikler.ForeColor = System.Drawing.Color.White;
            this.btn_klinikler.Location = new System.Drawing.Point(458, 12);
            this.btn_klinikler.Name = "btn_klinikler";
            this.btn_klinikler.Size = new System.Drawing.Size(275, 145);
            this.btn_klinikler.TabIndex = 1;
            this.btn_klinikler.Text = "POLİKLİNİKLER";
            this.btn_klinikler.UseVisualStyleBackColor = true;
            this.btn_klinikler.Click += new System.EventHandler(this.btn_klinikler_Click);
            // 
            // btn_doktorlar
            // 
            this.btn_doktorlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_doktorlar.BackgroundImage")));
            this.btn_doktorlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doktorlar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_doktorlar.ForeColor = System.Drawing.Color.White;
            this.btn_doktorlar.Location = new System.Drawing.Point(12, 194);
            this.btn_doktorlar.Name = "btn_doktorlar";
            this.btn_doktorlar.Size = new System.Drawing.Size(272, 145);
            this.btn_doktorlar.TabIndex = 2;
            this.btn_doktorlar.Text = "DOKTORLAR";
            this.btn_doktorlar.UseVisualStyleBackColor = true;
            this.btn_doktorlar.Click += new System.EventHandler(this.btn_doktorlar_Click);
            // 
            // btn_receteler
            // 
            this.btn_receteler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_receteler.BackgroundImage")));
            this.btn_receteler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_receteler.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_receteler.ForeColor = System.Drawing.Color.White;
            this.btn_receteler.Location = new System.Drawing.Point(458, 184);
            this.btn_receteler.Name = "btn_receteler";
            this.btn_receteler.Size = new System.Drawing.Size(275, 145);
            this.btn_receteler.TabIndex = 3;
            this.btn_receteler.Text = "REÇETELER";
            this.btn_receteler.UseVisualStyleBackColor = true;
            this.btn_receteler.Click += new System.EventHandler(this.btn_receteler_Click);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(786, 397);
            this.Controls.Add(this.btn_receteler);
            this.Controls.Add(this.btn_doktorlar);
            this.Controls.Add(this.btn_klinikler);
            this.Controls.Add(this.btn_hastalar);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anaform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_hastalar;
        private System.Windows.Forms.Button btn_klinikler;
        private System.Windows.Forms.Button btn_doktorlar;
        private System.Windows.Forms.Button btn_receteler;
    }
}