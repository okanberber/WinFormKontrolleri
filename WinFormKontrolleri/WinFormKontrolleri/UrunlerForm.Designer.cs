namespace WinFormKontrolleri
{
    partial class UrunlerForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.cb_satistami = new System.Windows.Forms.CheckBox();
            this.nud_guvenlikstok = new System.Windows.Forms.NumericUpDown();
            this.nud_stok = new System.Windows.Forms.NumericUpDown();
            this.TedarikciFormac = new System.Windows.Forms.Button();
            this.btn_kategoriFormac = new System.Windows.Forms.Button();
            this.cb_tedarikci = new System.Windows.Forms.ComboBox();
            this.cb_kategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.tb_fiyat = new System.Windows.Forms.TextBox();
            this.tb_paketleme = new System.Windows.Forms.TextBox();
            this.tb_barkod = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_guvenlikstok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(920, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.cb_satistami);
            this.groupBox1.Controls.Add(this.nud_guvenlikstok);
            this.groupBox1.Controls.Add(this.nud_stok);
            this.groupBox1.Controls.Add(this.TedarikciFormac);
            this.groupBox1.Controls.Add(this.btn_kategoriFormac);
            this.groupBox1.Controls.Add(this.cb_tedarikci);
            this.groupBox1.Controls.Add(this.cb_kategori);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.t);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.tb_fiyat);
            this.groupBox1.Controls.Add(this.tb_paketleme);
            this.groupBox1.Controls.Add(this.tb_barkod);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Urun Bilgileri";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(825, 140);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Urun Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            // 
            // cb_satistami
            // 
            this.cb_satistami.AutoSize = true;
            this.cb_satistami.Location = new System.Drawing.Point(720, 126);
            this.cb_satistami.Name = "cb_satistami";
            this.cb_satistami.Size = new System.Drawing.Size(82, 17);
            this.cb_satistami.TabIndex = 5;
            this.cb_satistami.Text = "satis devam";
            this.cb_satistami.UseVisualStyleBackColor = true;
            // 
            // nud_guvenlikstok
            // 
            this.nud_guvenlikstok.Location = new System.Drawing.Point(758, 97);
            this.nud_guvenlikstok.Name = "nud_guvenlikstok";
            this.nud_guvenlikstok.Size = new System.Drawing.Size(142, 20);
            this.nud_guvenlikstok.TabIndex = 4;
            // 
            // nud_stok
            // 
            this.nud_stok.Location = new System.Drawing.Point(758, 71);
            this.nud_stok.Name = "nud_stok";
            this.nud_stok.Size = new System.Drawing.Size(142, 20);
            this.nud_stok.TabIndex = 4;
            // 
            // TedarikciFormac
            // 
            this.TedarikciFormac.Location = new System.Drawing.Point(589, 63);
            this.TedarikciFormac.Name = "TedarikciFormac";
            this.TedarikciFormac.Size = new System.Drawing.Size(27, 21);
            this.TedarikciFormac.TabIndex = 3;
            this.TedarikciFormac.Text = "+";
            this.TedarikciFormac.UseVisualStyleBackColor = true;
            // 
            // btn_kategoriFormac
            // 
            this.btn_kategoriFormac.Location = new System.Drawing.Point(589, 36);
            this.btn_kategoriFormac.Name = "btn_kategoriFormac";
            this.btn_kategoriFormac.Size = new System.Drawing.Size(27, 21);
            this.btn_kategoriFormac.TabIndex = 3;
            this.btn_kategoriFormac.Text = "+";
            this.btn_kategoriFormac.UseVisualStyleBackColor = true;
            this.btn_kategoriFormac.Click += new System.EventHandler(this.btn_kategoriFormac_Click);
            // 
            // cb_tedarikci
            // 
            this.cb_tedarikci.FormattingEnabled = true;
            this.cb_tedarikci.Location = new System.Drawing.Point(400, 63);
            this.cb_tedarikci.Name = "cb_tedarikci";
            this.cb_tedarikci.Size = new System.Drawing.Size(183, 21);
            this.cb_tedarikci.TabIndex = 2;
            // 
            // cb_kategori
            // 
            this.cb_kategori.FormattingEnabled = true;
            this.cb_kategori.Location = new System.Drawing.Point(400, 36);
            this.cb_kategori.Name = "cb_kategori";
            this.cb_kategori.Size = new System.Drawing.Size(183, 21);
            this.cb_kategori.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fiyat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Paketleme:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tedarikci:";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(20, 71);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(44, 13);
            this.t.TabIndex = 1;
            this.t.Text = "Barkod:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Kategori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Isim:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(669, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Guvenlik Stogu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Stok:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(77, 93);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(183, 20);
            this.tb_isim.TabIndex = 0;
            // 
            // tb_fiyat
            // 
            this.tb_fiyat.Location = new System.Drawing.Point(758, 41);
            this.tb_fiyat.Name = "tb_fiyat";
            this.tb_fiyat.Size = new System.Drawing.Size(142, 20);
            this.tb_fiyat.TabIndex = 0;
            // 
            // tb_paketleme
            // 
            this.tb_paketleme.Location = new System.Drawing.Point(400, 93);
            this.tb_paketleme.Name = "tb_paketleme";
            this.tb_paketleme.Size = new System.Drawing.Size(183, 20);
            this.tb_paketleme.TabIndex = 0;
            // 
            // tb_barkod
            // 
            this.tb_barkod.Location = new System.Drawing.Point(77, 67);
            this.tb_barkod.Name = "tb_barkod";
            this.tb_barkod.Size = new System.Drawing.Size(183, 20);
            this.tb_barkod.TabIndex = 0;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(77, 41);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(183, 20);
            this.tb_id.TabIndex = 0;
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrunlerForm";
            this.Text = "Urun Islemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UrunlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_guvenlikstok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.CheckBox cb_satistami;
        private System.Windows.Forms.NumericUpDown nud_guvenlikstok;
        private System.Windows.Forms.NumericUpDown nud_stok;
        private System.Windows.Forms.Button TedarikciFormac;
        private System.Windows.Forms.Button btn_kategoriFormac;
        private System.Windows.Forms.ComboBox cb_tedarikci;
        private System.Windows.Forms.ComboBox cb_kategori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.TextBox tb_paketleme;
        private System.Windows.Forms.TextBox tb_barkod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_fiyat;
    }
}