namespace WinFormKontrolleri
{
    partial class DateTimeKontrolleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_uretilen = new System.Windows.Forms.Label();
            this.nud_dakika = new System.Windows.Forms.NumericUpDown();
            this.nud_saat = new System.Windows.Forms.NumericUpDown();
            this.lbl_uzunTarih = new System.Windows.Forms.Label();
            this.lbl_kisaTarih = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.btn_TarihGetir = new System.Windows.Forms.Button();
            this.dtp_Dogum = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_aralik = new System.Windows.Forms.Label();
            this.btn_aralik = new System.Windows.Forms.Button();
            this.mc_takvim = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tarihfark = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_saat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_uretilen);
            this.groupBox1.Controls.Add(this.nud_dakika);
            this.groupBox1.Controls.Add(this.nud_saat);
            this.groupBox1.Controls.Add(this.lbl_uzunTarih);
            this.groupBox1.Controls.Add(this.lbl_kisaTarih);
            this.groupBox1.Controls.Add(this.lbl_tarih);
            this.groupBox1.Controls.Add(this.btn_TarihGetir);
            this.groupBox1.Controls.Add(this.dtp_Dogum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doğum Tarihi";
            // 
            // lbl_uretilen
            // 
            this.lbl_uretilen.AutoSize = true;
            this.lbl_uretilen.Location = new System.Drawing.Point(3, 116);
            this.lbl_uretilen.Name = "lbl_uretilen";
            this.lbl_uretilen.Size = new System.Drawing.Size(43, 13);
            this.lbl_uretilen.TabIndex = 6;
            this.lbl_uretilen.Text = "Uretilen";
            // 
            // nud_dakika
            // 
            this.nud_dakika.Location = new System.Drawing.Point(65, 45);
            this.nud_dakika.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_dakika.Name = "nud_dakika";
            this.nud_dakika.Size = new System.Drawing.Size(53, 20);
            this.nud_dakika.TabIndex = 5;
            // 
            // nud_saat
            // 
            this.nud_saat.Location = new System.Drawing.Point(6, 45);
            this.nud_saat.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_saat.Name = "nud_saat";
            this.nud_saat.Size = new System.Drawing.Size(53, 20);
            this.nud_saat.TabIndex = 5;
            // 
            // lbl_uzunTarih
            // 
            this.lbl_uzunTarih.AutoSize = true;
            this.lbl_uzunTarih.Location = new System.Drawing.Point(3, 103);
            this.lbl_uzunTarih.Name = "lbl_uzunTarih";
            this.lbl_uzunTarih.Size = new System.Drawing.Size(56, 13);
            this.lbl_uzunTarih.TabIndex = 4;
            this.lbl_uzunTarih.Text = "UzunTarih";
            // 
            // lbl_kisaTarih
            // 
            this.lbl_kisaTarih.AutoSize = true;
            this.lbl_kisaTarih.Location = new System.Drawing.Point(3, 90);
            this.lbl_kisaTarih.Name = "lbl_kisaTarih";
            this.lbl_kisaTarih.Size = new System.Drawing.Size(54, 13);
            this.lbl_kisaTarih.TabIndex = 3;
            this.lbl_kisaTarih.Text = "Kısa Tarih";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Location = new System.Drawing.Point(3, 77);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(31, 13);
            this.lbl_tarih.TabIndex = 2;
            this.lbl_tarih.Text = "Tarih";
            // 
            // btn_TarihGetir
            // 
            this.btn_TarihGetir.Location = new System.Drawing.Point(212, 19);
            this.btn_TarihGetir.Name = "btn_TarihGetir";
            this.btn_TarihGetir.Size = new System.Drawing.Size(75, 23);
            this.btn_TarihGetir.TabIndex = 1;
            this.btn_TarihGetir.Text = "TarihGetir";
            this.btn_TarihGetir.UseVisualStyleBackColor = true;
            this.btn_TarihGetir.Click += new System.EventHandler(this.btn_TarihGetir_Click);
            // 
            // dtp_Dogum
            // 
            this.dtp_Dogum.Location = new System.Drawing.Point(6, 19);
            this.dtp_Dogum.Name = "dtp_Dogum";
            this.dtp_Dogum.Size = new System.Drawing.Size(200, 20);
            this.dtp_Dogum.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_tarihfark);
            this.groupBox2.Controls.Add(this.lbl_aralik);
            this.groupBox2.Controls.Add(this.btn_aralik);
            this.groupBox2.Controls.Add(this.mc_takvim);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(397, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiralama";
            // 
            // lbl_aralik
            // 
            this.lbl_aralik.AutoSize = true;
            this.lbl_aralik.Location = new System.Drawing.Point(277, 64);
            this.lbl_aralik.Name = "lbl_aralik";
            this.lbl_aralik.Size = new System.Drawing.Size(33, 13);
            this.lbl_aralik.TabIndex = 3;
            this.lbl_aralik.Text = "Aralik";
            // 
            // btn_aralik
            // 
            this.btn_aralik.Location = new System.Drawing.Point(277, 38);
            this.btn_aralik.Name = "btn_aralik";
            this.btn_aralik.Size = new System.Drawing.Size(75, 23);
            this.btn_aralik.TabIndex = 2;
            this.btn_aralik.Text = "Aralik Getir";
            this.btn_aralik.UseVisualStyleBackColor = true;
            this.btn_aralik.Click += new System.EventHandler(this.btn_aralik_Click);
            // 
            // mc_takvim
            // 
            this.mc_takvim.Location = new System.Drawing.Point(12, 38);
            this.mc_takvim.Name = "mc_takvim";
            this.mc_takvim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lbl_tarihfark
            // 
            this.lbl_tarihfark.AutoSize = true;
            this.lbl_tarihfark.Location = new System.Drawing.Point(277, 77);
            this.lbl_tarihfark.Name = "lbl_tarihfark";
            this.lbl_tarihfark.Size = new System.Drawing.Size(28, 13);
            this.lbl_tarihfark.TabIndex = 4;
            this.lbl_tarihfark.Text = "Fark";
            // 
            // DateTimeKontrolleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DateTimeKontrolleri";
            this.Text = "DateTimeKontrolleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_saat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Button btn_TarihGetir;
        private System.Windows.Forms.DateTimePicker dtp_Dogum;
        private System.Windows.Forms.Label lbl_uzunTarih;
        private System.Windows.Forms.Label lbl_kisaTarih;
        private System.Windows.Forms.NumericUpDown nud_dakika;
        private System.Windows.Forms.NumericUpDown nud_saat;
        private System.Windows.Forms.Label lbl_uretilen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_aralik;
        private System.Windows.Forms.Button btn_aralik;
        private System.Windows.Forms.MonthCalendar mc_takvim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tarihfark;
    }
}