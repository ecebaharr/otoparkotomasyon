namespace otopark
{
    partial class kullanici_giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanici_giris));
            this.lbl_kullanici = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_kullanici = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.linklbl_sifre = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(-2, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(387, 470);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_kullanici
            // 
            this.lbl_kullanici.AutoSize = true;
            this.lbl_kullanici.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kullanici.Font = new System.Drawing.Font("Trebuchet MS", 13.2F, System.Drawing.FontStyle.Bold);
            this.lbl_kullanici.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_kullanici.Location = new System.Drawing.Point(483, 118);
            this.lbl_kullanici.Name = "lbl_kullanici";
            this.lbl_kullanici.Size = new System.Drawing.Size(148, 27);
            this.lbl_kullanici.TabIndex = 1;
            this.lbl_kullanici.Text = "Kullanıcı adı:";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sifre.Font = new System.Drawing.Font("Trebuchet MS", 13.2F, System.Drawing.FontStyle.Bold);
            this.lbl_sifre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_sifre.Location = new System.Drawing.Point(563, 194);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(68, 27);
            this.lbl_sifre.TabIndex = 1;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanici.Location = new System.Drawing.Point(646, 112);
            this.txt_kullanici.Multiline = true;
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.Size = new System.Drawing.Size(169, 33);
            this.txt_kullanici.TabIndex = 2;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.Transparent;
            this.btn_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_giris.BackgroundImage")));
            this.btn_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_giris.Location = new System.Drawing.Point(660, 290);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(79, 69);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.SystemColors.Window;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.Location = new System.Drawing.Point(773, 297);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(51, 55);
            this.btn_cikis.TabIndex = 6;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.Location = new System.Drawing.Point(646, 188);
            this.txt_sifre.Multiline = true;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(169, 33);
            this.txt_sifre.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(662, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Yönetici Girişi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linklbl_sifre
            // 
            this.linklbl_sifre.ActiveLinkColor = System.Drawing.Color.Red;
            this.linklbl_sifre.AutoSize = true;
            this.linklbl_sifre.BackColor = System.Drawing.Color.Transparent;
            this.linklbl_sifre.DisabledLinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.linklbl_sifre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklbl_sifre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.linklbl_sifre.LinkColor = System.Drawing.Color.Silver;
            this.linklbl_sifre.Location = new System.Drawing.Point(716, 242);
            this.linklbl_sifre.Name = "linklbl_sifre";
            this.linklbl_sifre.Size = new System.Drawing.Size(99, 23);
            this.linklbl_sifre.TabIndex = 4;
            this.linklbl_sifre.TabStop = true;
            this.linklbl_sifre.Text = "Şifre değiştir";
            this.linklbl_sifre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_sifre_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 522);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ⓔ\r\nⓈ\r\nⓄ\r\nⓉ\r\nⓄ\r\nⓅ\r\nⒶ\r\nⓇ\r\nⓀ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(83, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 58);
            this.label2.TabIndex = 12;
            this.label2.Text = "ⒺⓈⓄⓉⓄⓅⒶⓇⓀ";
            // 
            // kullanici_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(189)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 530);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.linklbl_sifre);
            this.Controls.Add(this.txt_kullanici);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kullanici);
            this.Name = "kullanici_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.kullanici_giris_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullanici;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_kullanici;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linklbl_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

