﻿namespace Yorukoglu_Komur_Programı
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKullaniciAd = new DevExpress.XtraEditors.TextEdit();
            this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.Location = new System.Drawing.Point(159, 36);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtKullaniciAd.Properties.Appearance.Options.UseFont = true;
            this.TxtKullaniciAd.Size = new System.Drawing.Size(107, 28);
            this.TxtKullaniciAd.TabIndex = 1;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(159, 66);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.TxtSifre.Properties.Appearance.Options.UseFont = true;
            this.TxtSifre.Properties.UseSystemPasswordChar = true;
            this.TxtSifre.Size = new System.Drawing.Size(107, 28);
            this.TxtSifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(99, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.DarkGray;
            this.BtnGirisYap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnGirisYap.Location = new System.Drawing.Point(159, 96);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(107, 29);
            this.BtnGirisYap.TabIndex = 4;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            this.BtnGirisYap.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.BtnGirisYap.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "YÖRÜKOĞLU KÖMÜR TİCARİ OTOMASYON\r\n                                      2023\r\n";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(382, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtKullaniciAd;
        private DevExpress.XtraEditors.TextEdit TxtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.Label label3;
    }
}