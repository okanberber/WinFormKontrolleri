namespace WinFormKontrolleri
{
    partial class ComboBoxKontrolu
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_departman = new System.Windows.Forms.ComboBox();
            this.btn_departmanSec = new System.Windows.Forms.Button();
            this.lbl_secilenDepartman = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_egitim = new System.Windows.Forms.ComboBox();
            this.lbl_Eğitim = new System.Windows.Forms.Label();
            this.cb_Markalar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_MarkaSec = new System.Windows.Forms.Button();
            this.lbl_MarkaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman Seçiniz";
            // 
            // cb_departman
            // 
            this.cb_departman.FormattingEnabled = true;
            this.cb_departman.Items.AddRange(new object[] {
            "Satış",
            "Muhasebe",
            "Levazım",
            "İnsan Kaynakları"});
            this.cb_departman.Location = new System.Drawing.Point(12, 25);
            this.cb_departman.Name = "cb_departman";
            this.cb_departman.Size = new System.Drawing.Size(167, 21);
            this.cb_departman.TabIndex = 1;
            this.cb_departman.Text = "Seçiniz...";
            // 
            // btn_departmanSec
            // 
            this.btn_departmanSec.Location = new System.Drawing.Point(185, 23);
            this.btn_departmanSec.Name = "btn_departmanSec";
            this.btn_departmanSec.Size = new System.Drawing.Size(75, 23);
            this.btn_departmanSec.TabIndex = 2;
            this.btn_departmanSec.Text = "SEÇ";
            this.btn_departmanSec.UseVisualStyleBackColor = true;
            this.btn_departmanSec.Click += new System.EventHandler(this.btn_departmanSec_Click);
            // 
            // lbl_secilenDepartman
            // 
            this.lbl_secilenDepartman.AutoSize = true;
            this.lbl_secilenDepartman.Location = new System.Drawing.Point(279, 28);
            this.lbl_secilenDepartman.Name = "lbl_secilenDepartman";
            this.lbl_secilenDepartman.Size = new System.Drawing.Size(35, 13);
            this.lbl_secilenDepartman.TabIndex = 3;
            this.lbl_secilenDepartman.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Katılınacak Eğitim";
            // 
            // cb_egitim
            // 
            this.cb_egitim.FormattingEnabled = true;
            this.cb_egitim.Items.AddRange(new object[] {
            "Yazılım Uzmanlığı",
            "İleri Yazılım Uzmanlığı",
            "İleri Sürüş Eğitimi",
            "Domates Yetiştiriciliği"});
            this.cb_egitim.Location = new System.Drawing.Point(12, 77);
            this.cb_egitim.Name = "cb_egitim";
            this.cb_egitim.Size = new System.Drawing.Size(126, 21);
            this.cb_egitim.TabIndex = 5;
            this.cb_egitim.SelectedIndexChanged += new System.EventHandler(this.cb_egitim_SelectedIndexChanged);
            // 
            // lbl_Eğitim
            // 
            this.lbl_Eğitim.AutoSize = true;
            this.lbl_Eğitim.Location = new System.Drawing.Point(144, 80);
            this.lbl_Eğitim.Name = "lbl_Eğitim";
            this.lbl_Eğitim.Size = new System.Drawing.Size(35, 13);
            this.lbl_Eğitim.TabIndex = 6;
            this.lbl_Eğitim.Text = "label3";
            // 
            // cb_Markalar
            // 
            this.cb_Markalar.FormattingEnabled = true;
            this.cb_Markalar.Location = new System.Drawing.Point(12, 137);
            this.cb_Markalar.Name = "cb_Markalar";
            this.cb_Markalar.Size = new System.Drawing.Size(126, 21);
            this.cb_Markalar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marka Seçiniz...";
            // 
            // btn_MarkaSec
            // 
            this.btn_MarkaSec.Location = new System.Drawing.Point(147, 135);
            this.btn_MarkaSec.Name = "btn_MarkaSec";
            this.btn_MarkaSec.Size = new System.Drawing.Size(75, 23);
            this.btn_MarkaSec.TabIndex = 9;
            this.btn_MarkaSec.Text = "Seç";
            this.btn_MarkaSec.UseVisualStyleBackColor = true;
            this.btn_MarkaSec.Click += new System.EventHandler(this.btn_MarkaSec_Click);
            // 
            // lbl_MarkaLabel
            // 
            this.lbl_MarkaLabel.AutoSize = true;
            this.lbl_MarkaLabel.Location = new System.Drawing.Point(228, 140);
            this.lbl_MarkaLabel.Name = "lbl_MarkaLabel";
            this.lbl_MarkaLabel.Size = new System.Drawing.Size(35, 13);
            this.lbl_MarkaLabel.TabIndex = 10;
            this.lbl_MarkaLabel.Text = "label4";
            // 
            // ComboBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_MarkaLabel);
            this.Controls.Add(this.btn_MarkaSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Markalar);
            this.Controls.Add(this.lbl_Eğitim);
            this.Controls.Add(this.cb_egitim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_secilenDepartman);
            this.Controls.Add(this.btn_departmanSec);
            this.Controls.Add(this.cb_departman);
            this.Controls.Add(this.label1);
            this.Name = "ComboBoxKontrolu";
            this.Text = "ComboBoxKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_departman;
        private System.Windows.Forms.Button btn_departmanSec;
        private System.Windows.Forms.Label lbl_secilenDepartman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_egitim;
        private System.Windows.Forms.Label lbl_Eğitim;
        private System.Windows.Forms.ComboBox cb_Markalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_MarkaSec;
        private System.Windows.Forms.Label lbl_MarkaLabel;
    }
}