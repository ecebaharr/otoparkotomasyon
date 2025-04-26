namespace otopark
{
    partial class yönetici_girisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yönetici_girisi));
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_yönetici = new System.Windows.Forms.TextBox();
            this.lbl_syonetici = new System.Windows.Forms.Label();
            this.lbl_kyönetici = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lnklbl_sifreunuttum = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(206, 177);
            this.txt_sifre.Multiline = true;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(169, 33);
            this.txt_sifre.TabIndex = 11;
            // 
            // txt_yönetici
            // 
            this.txt_yönetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yönetici.Location = new System.Drawing.Point(206, 101);
            this.txt_yönetici.Multiline = true;
            this.txt_yönetici.Name = "txt_yönetici";
            this.txt_yönetici.Size = new System.Drawing.Size(169, 33);
            this.txt_yönetici.TabIndex = 10;
            // 
            // lbl_syonetici
            // 
            this.lbl_syonetici.AutoSize = true;
            this.lbl_syonetici.BackColor = System.Drawing.Color.Transparent;
            this.lbl_syonetici.Font = new System.Drawing.Font("Trebuchet MS", 13.2F, System.Drawing.FontStyle.Bold);
            this.lbl_syonetici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_syonetici.Location = new System.Drawing.Point(123, 183);
            this.lbl_syonetici.Name = "lbl_syonetici";
            this.lbl_syonetici.Size = new System.Drawing.Size(68, 27);
            this.lbl_syonetici.TabIndex = 8;
            this.lbl_syonetici.Text = "Şifre:";
            // 
            // lbl_kyönetici
            // 
            this.lbl_kyönetici.AutoSize = true;
            this.lbl_kyönetici.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kyönetici.Font = new System.Drawing.Font("Trebuchet MS", 13.2F, System.Drawing.FontStyle.Bold);
            this.lbl_kyönetici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_kyönetici.Location = new System.Drawing.Point(43, 107);
            this.lbl_kyönetici.Name = "lbl_kyönetici";
            this.lbl_kyönetici.Size = new System.Drawing.Size(148, 27);
            this.lbl_kyönetici.TabIndex = 9;
            this.lbl_kyönetici.Text = "Kullanıcı adı:";
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.Transparent;
            this.btn_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_giris.BackgroundImage")));
            this.btn_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_giris.Location = new System.Drawing.Point(241, 252);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(79, 69);
            this.btn_giris.TabIndex = 12;
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.SystemColors.Window;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.Location = new System.Drawing.Point(326, 259);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(51, 55);
            this.btn_cikis.TabIndex = 13;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(333, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kullanıcı girişi yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lnklbl_sifreunuttum
            // 
            this.lnklbl_sifreunuttum.AutoSize = true;
            this.lnklbl_sifreunuttum.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic);
            this.lnklbl_sifreunuttum.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lnklbl_sifreunuttum.LinkColor = System.Drawing.Color.Gray;
            this.lnklbl_sifreunuttum.Location = new System.Drawing.Point(384, 229);
            this.lnklbl_sifreunuttum.Name = "lnklbl_sifreunuttum";
            this.lnklbl_sifreunuttum.Size = new System.Drawing.Size(129, 23);
            this.lnklbl_sifreunuttum.TabIndex = 15;
            this.lnklbl_sifreunuttum.TabStop = true;
            this.lnklbl_sifreunuttum.Text = "Şifremi unuttum";
            this.lnklbl_sifreunuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_sifreunuttum_LinkClicked);
            // 
            // yönetici_girisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(535, 343);
            this.Controls.Add(this.lnklbl_sifreunuttum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_yönetici);
            this.Controls.Add(this.lbl_syonetici);
            this.Controls.Add(this.lbl_kyönetici);
            this.Name = "yönetici_girisi";
            this.Text = "Yönetici girişi";
            this.Load += new System.EventHandler(this.yönetici_girisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_yönetici;
        private System.Windows.Forms.Label lbl_syonetici;
        private System.Windows.Forms.Label lbl_kyönetici;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lnklbl_sifreunuttum;
    }
}