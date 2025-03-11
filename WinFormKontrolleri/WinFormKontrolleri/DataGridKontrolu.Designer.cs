namespace WinFormKontrolleri
{
    partial class DataGridKontrolu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.tb_Aciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_FormuTemizle = new System.Windows.Forms.Button();
            this.BTN_Ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_duzenle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.BTN_Ekle);
            this.groupBox1.Controls.Add(this.BTN_FormuTemizle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Aciklama);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Bilgileri";
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(6, 104);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(226, 20);
            this.tb_isim.TabIndex = 0;
            // 
            // tb_Aciklama
            // 
            this.tb_Aciklama.Location = new System.Drawing.Point(279, 47);
            this.tb_Aciklama.Multiline = true;
            this.tb_Aciklama.Name = "tb_Aciklama";
            this.tb_Aciklama.Size = new System.Drawing.Size(229, 77);
            this.tb_Aciklama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Adi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aciklama :";
            // 
            // BTN_FormuTemizle
            // 
            this.BTN_FormuTemizle.Location = new System.Drawing.Point(279, 139);
            this.BTN_FormuTemizle.Name = "BTN_FormuTemizle";
            this.BTN_FormuTemizle.Size = new System.Drawing.Size(129, 23);
            this.BTN_FormuTemizle.TabIndex = 3;
            this.BTN_FormuTemizle.Text = "Formu Temizle";
            this.BTN_FormuTemizle.UseVisualStyleBackColor = true;
            // 
            // BTN_Ekle
            // 
            this.BTN_Ekle.Location = new System.Drawing.Point(430, 139);
            this.BTN_Ekle.Name = "BTN_Ekle";
            this.BTN_Ekle.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ekle.TabIndex = 3;
            this.BTN_Ekle.Text = "Ekle";
            this.BTN_Ekle.UseVisualStyleBackColor = true;
            this.BTN_Ekle.Click += new System.EventHandler(this.BTN_Ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1060, 376);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(6, 47);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(226, 20);
            this.tb_id.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_duzenle,
            this.TSMI_sil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // TSMI_duzenle
            // 
            this.TSMI_duzenle.Name = "TSMI_duzenle";
            this.TSMI_duzenle.Size = new System.Drawing.Size(116, 22);
            this.TSMI_duzenle.Text = "Duzenle";
            this.TSMI_duzenle.Click += new System.EventHandler(this.TSMI_duzenle_Click);
            // 
            // TSMI_sil
            // 
            this.TSMI_sil.Name = "TSMI_sil";
            this.TSMI_sil.Size = new System.Drawing.Size(180, 22);
            this.TSMI_sil.Text = "Sil";
            this.TSMI_sil.Click += new System.EventHandler(this.TSMI_sil_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(430, 139);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_duzenle.TabIndex = 6;
            this.btn_duzenle.Text = "Duzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Visible = false;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // DataGridKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataGridKontrolu";
            this.Text = "DataGridKontrolu";
            this.Load += new System.EventHandler(this.DataGridKontrolu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Aciklama;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Button BTN_Ekle;
        private System.Windows.Forms.Button BTN_FormuTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_duzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_sil;
        private System.Windows.Forms.Button btn_duzenle;
    }
}