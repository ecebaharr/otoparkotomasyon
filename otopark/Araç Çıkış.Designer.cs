namespace otopark
{
    partial class Araç_Çıkış
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Araç_Çıkış));
            this.lbl_aracplaka = new System.Windows.Forms.Label();
            this.cmbbox_plaka = new System.Windows.Forms.ComboBox();
            this.lbl_ucret = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_telno = new System.Windows.Forms.Label();
            this.lbl_marka = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_adtxt = new System.Windows.Forms.Label();
            this.lbl_soyadtxt = new System.Windows.Forms.Label();
            this.lbl_telnotxt = new System.Windows.Forms.Label();
            this.groupBox_abilgi = new System.Windows.Forms.GroupBox();
            this.lbl_yikama = new System.Windows.Forms.Label();
            this.lbl_aracyikama = new System.Windows.Forms.Label();
            this.lbl_markatxt = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_modeltxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ucrettxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_parkyeri = new System.Windows.Forms.Label();
            this.lbl_parkyeritxt = new System.Windows.Forms.Label();
            this.groupBox_ucret = new System.Windows.Forms.GroupBox();
            this.lbl_gtarihitxt = new System.Windows.Forms.Label();
            this.lbl_ctarihitxt = new System.Windows.Forms.Label();
            this.lbl_ctarihi = new System.Windows.Forms.Label();
            this.lbl_gtarih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.groupBox_abilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_ucret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_aracplaka
            // 
            this.lbl_aracplaka.AutoSize = true;
            this.lbl_aracplaka.BackColor = System.Drawing.Color.Transparent;
            this.lbl_aracplaka.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_aracplaka.ForeColor = System.Drawing.Color.Black;
            this.lbl_aracplaka.Location = new System.Drawing.Point(61, 54);
            this.lbl_aracplaka.Name = "lbl_aracplaka";
            this.lbl_aracplaka.Size = new System.Drawing.Size(140, 24);
            this.lbl_aracplaka.TabIndex = 0;
            this.lbl_aracplaka.Text = "Araç Plakası:";
            // 
            // cmbbox_plaka
            // 
            this.cmbbox_plaka.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbbox_plaka.FormattingEnabled = true;
            this.cmbbox_plaka.Location = new System.Drawing.Point(221, 50);
            this.cmbbox_plaka.Name = "cmbbox_plaka";
            this.cmbbox_plaka.Size = new System.Drawing.Size(191, 33);
            this.cmbbox_plaka.TabIndex = 1;
            this.cmbbox_plaka.SelectedIndexChanged += new System.EventHandler(this.cmbbox_plaka_SelectedIndexChanged);
            // 
            // lbl_ucret
            // 
            this.lbl_ucret.AutoSize = true;
            this.lbl_ucret.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ucret.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ucret.ForeColor = System.Drawing.Color.Black;
            this.lbl_ucret.Location = new System.Drawing.Point(11, 145);
            this.lbl_ucret.Name = "lbl_ucret";
            this.lbl_ucret.Size = new System.Drawing.Size(147, 24);
            this.lbl_ucret.TabIndex = 3;
            this.lbl_ucret.Text = "Toplam tutar:";
            this.lbl_ucret.Click += new System.EventHandler(this.lbl_ucret_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_geri.ForeColor = System.Drawing.Color.White;
            this.btn_geri.Location = new System.Drawing.Point(663, 574);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(255, 45);
            this.btn_geri.TabIndex = 15;
            this.btn_geri.Text = "Anasayfaya dön";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Red;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikis.Location = new System.Drawing.Point(882, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(36, 36);
            this.btn_cikis.TabIndex = 16;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ad.Location = new System.Drawing.Point(111, 77);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(44, 24);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Ad:";
            // 
            // lbl_telno
            // 
            this.lbl_telno.AutoSize = true;
            this.lbl_telno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_telno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_telno.Location = new System.Drawing.Point(30, 164);
            this.lbl_telno.Name = "lbl_telno";
            this.lbl_telno.Size = new System.Drawing.Size(125, 24);
            this.lbl_telno.TabIndex = 1;
            this.lbl_telno.Text = "Telefon No:";
            // 
            // lbl_marka
            // 
            this.lbl_marka.AutoSize = true;
            this.lbl_marka.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_marka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_marka.Location = new System.Drawing.Point(7, 210);
            this.lbl_marka.Name = "lbl_marka";
            this.lbl_marka.Size = new System.Drawing.Size(148, 24);
            this.lbl_marka.TabIndex = 2;
            this.lbl_marka.Text = "Araç Markası:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_soyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_soyad.Location = new System.Drawing.Point(76, 119);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(79, 24);
            this.lbl_soyad.TabIndex = 3;
            this.lbl_soyad.Text = "Soyad:";
            // 
            // lbl_adtxt
            // 
            this.lbl_adtxt.AutoSize = true;
            this.lbl_adtxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_adtxt.Location = new System.Drawing.Point(180, 76);
            this.lbl_adtxt.Name = "lbl_adtxt";
            this.lbl_adtxt.Size = new System.Drawing.Size(0, 25);
            this.lbl_adtxt.TabIndex = 17;
            // 
            // lbl_soyadtxt
            // 
            this.lbl_soyadtxt.AutoSize = true;
            this.lbl_soyadtxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyadtxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_soyadtxt.Location = new System.Drawing.Point(180, 118);
            this.lbl_soyadtxt.Name = "lbl_soyadtxt";
            this.lbl_soyadtxt.Size = new System.Drawing.Size(0, 25);
            this.lbl_soyadtxt.TabIndex = 18;
            // 
            // lbl_telnotxt
            // 
            this.lbl_telnotxt.AutoSize = true;
            this.lbl_telnotxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telnotxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_telnotxt.Location = new System.Drawing.Point(180, 163);
            this.lbl_telnotxt.Name = "lbl_telnotxt";
            this.lbl_telnotxt.Size = new System.Drawing.Size(0, 25);
            this.lbl_telnotxt.TabIndex = 19;
            // 
            // groupBox_abilgi
            // 
            this.groupBox_abilgi.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_abilgi.Controls.Add(this.lbl_yikama);
            this.groupBox_abilgi.Controls.Add(this.lbl_aracyikama);
            this.groupBox_abilgi.Controls.Add(this.lbl_markatxt);
            this.groupBox_abilgi.Controls.Add(this.lbl_model);
            this.groupBox_abilgi.Controls.Add(this.lbl_modeltxt);
            this.groupBox_abilgi.Controls.Add(this.lbl_telnotxt);
            this.groupBox_abilgi.Controls.Add(this.lbl_soyadtxt);
            this.groupBox_abilgi.Controls.Add(this.lbl_adtxt);
            this.groupBox_abilgi.Controls.Add(this.lbl_soyad);
            this.groupBox_abilgi.Controls.Add(this.lbl_marka);
            this.groupBox_abilgi.Controls.Add(this.lbl_telno);
            this.groupBox_abilgi.Controls.Add(this.lbl_ad);
            this.groupBox_abilgi.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox_abilgi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox_abilgi.Location = new System.Drawing.Point(12, 132);
            this.groupBox_abilgi.Name = "groupBox_abilgi";
            this.groupBox_abilgi.Size = new System.Drawing.Size(467, 345);
            this.groupBox_abilgi.TabIndex = 2;
            this.groupBox_abilgi.TabStop = false;
            this.groupBox_abilgi.Text = "Araç Bilgileri";
            // 
            // lbl_yikama
            // 
            this.lbl_yikama.AutoSize = true;
            this.lbl_yikama.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yikama.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_yikama.Location = new System.Drawing.Point(180, 291);
            this.lbl_yikama.Name = "lbl_yikama";
            this.lbl_yikama.Size = new System.Drawing.Size(0, 25);
            this.lbl_yikama.TabIndex = 24;
            // 
            // lbl_aracyikama
            // 
            this.lbl_aracyikama.AutoSize = true;
            this.lbl_aracyikama.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_aracyikama.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_aracyikama.Location = new System.Drawing.Point(19, 292);
            this.lbl_aracyikama.Name = "lbl_aracyikama";
            this.lbl_aracyikama.Size = new System.Drawing.Size(143, 24);
            this.lbl_aracyikama.TabIndex = 23;
            this.lbl_aracyikama.Text = "Araç Yıkama:";
            // 
            // lbl_markatxt
            // 
            this.lbl_markatxt.AutoSize = true;
            this.lbl_markatxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_markatxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_markatxt.Location = new System.Drawing.Point(180, 209);
            this.lbl_markatxt.Name = "lbl_markatxt";
            this.lbl_markatxt.Size = new System.Drawing.Size(0, 25);
            this.lbl_markatxt.TabIndex = 22;
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_model.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_model.Location = new System.Drawing.Point(19, 251);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(136, 24);
            this.lbl_model.TabIndex = 21;
            this.lbl_model.Text = "Araç Modeli:";
            // 
            // lbl_modeltxt
            // 
            this.lbl_modeltxt.AutoSize = true;
            this.lbl_modeltxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_modeltxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_modeltxt.Location = new System.Drawing.Point(180, 251);
            this.lbl_modeltxt.Name = "lbl_modeltxt";
            this.lbl_modeltxt.Size = new System.Drawing.Size(0, 25);
            this.lbl_modeltxt.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(397, 517);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_ucrettxt
            // 
            this.lbl_ucrettxt.AutoSize = true;
            this.lbl_ucrettxt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ucrettxt.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ucrettxt.ForeColor = System.Drawing.Color.Red;
            this.lbl_ucrettxt.Location = new System.Drawing.Point(178, 147);
            this.lbl_ucrettxt.Name = "lbl_ucrettxt";
            this.lbl_ucrettxt.Size = new System.Drawing.Size(0, 22);
            this.lbl_ucrettxt.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(349, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Araç çıkışı için yukarıya tıklayınız.";
            // 
            // lbl_parkyeri
            // 
            this.lbl_parkyeri.AutoSize = true;
            this.lbl_parkyeri.BackColor = System.Drawing.Color.Transparent;
            this.lbl_parkyeri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_parkyeri.ForeColor = System.Drawing.Color.Black;
            this.lbl_parkyeri.Location = new System.Drawing.Point(92, 94);
            this.lbl_parkyeri.Name = "lbl_parkyeri";
            this.lbl_parkyeri.Size = new System.Drawing.Size(109, 24);
            this.lbl_parkyeri.TabIndex = 22;
            this.lbl_parkyeri.Text = "Park Yeri:";
            // 
            // lbl_parkyeritxt
            // 
            this.lbl_parkyeritxt.AutoSize = true;
            this.lbl_parkyeritxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_parkyeritxt.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_parkyeritxt.Location = new System.Drawing.Point(227, 93);
            this.lbl_parkyeritxt.Name = "lbl_parkyeritxt";
            this.lbl_parkyeritxt.Size = new System.Drawing.Size(0, 25);
            this.lbl_parkyeritxt.TabIndex = 23;
            // 
            // groupBox_ucret
            // 
            this.groupBox_ucret.Controls.Add(this.lbl_gtarihitxt);
            this.groupBox_ucret.Controls.Add(this.lbl_ctarihitxt);
            this.groupBox_ucret.Controls.Add(this.lbl_ctarihi);
            this.groupBox_ucret.Controls.Add(this.lbl_gtarih);
            this.groupBox_ucret.Controls.Add(this.lbl_ucret);
            this.groupBox_ucret.Controls.Add(this.lbl_ucrettxt);
            this.groupBox_ucret.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_ucret.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox_ucret.Location = new System.Drawing.Point(496, 319);
            this.groupBox_ucret.Name = "groupBox_ucret";
            this.groupBox_ucret.Size = new System.Drawing.Size(426, 192);
            this.groupBox_ucret.TabIndex = 24;
            this.groupBox_ucret.TabStop = false;
            this.groupBox_ucret.Text = "Ücretlendirme";
            // 
            // lbl_gtarihitxt
            // 
            this.lbl_gtarihitxt.AutoSize = true;
            this.lbl_gtarihitxt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gtarihitxt.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gtarihitxt.ForeColor = System.Drawing.Color.Red;
            this.lbl_gtarihitxt.Location = new System.Drawing.Point(178, 49);
            this.lbl_gtarihitxt.Name = "lbl_gtarihitxt";
            this.lbl_gtarihitxt.Size = new System.Drawing.Size(0, 22);
            this.lbl_gtarihitxt.TabIndex = 26;
            // 
            // lbl_ctarihitxt
            // 
            this.lbl_ctarihitxt.AutoSize = true;
            this.lbl_ctarihitxt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ctarihitxt.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ctarihitxt.ForeColor = System.Drawing.Color.Red;
            this.lbl_ctarihitxt.Location = new System.Drawing.Point(178, 99);
            this.lbl_ctarihitxt.Name = "lbl_ctarihitxt";
            this.lbl_ctarihitxt.Size = new System.Drawing.Size(0, 22);
            this.lbl_ctarihitxt.TabIndex = 25;
            // 
            // lbl_ctarihi
            // 
            this.lbl_ctarihi.AutoSize = true;
            this.lbl_ctarihi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ctarihi.ForeColor = System.Drawing.Color.Black;
            this.lbl_ctarihi.Location = new System.Drawing.Point(30, 97);
            this.lbl_ctarihi.Name = "lbl_ctarihi";
            this.lbl_ctarihi.Size = new System.Drawing.Size(128, 24);
            this.lbl_ctarihi.TabIndex = 24;
            this.lbl_ctarihi.Text = "Çıkış Tarihi:";
            // 
            // lbl_gtarih
            // 
            this.lbl_gtarih.AutoSize = true;
            this.lbl_gtarih.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_gtarih.ForeColor = System.Drawing.Color.Black;
            this.lbl_gtarih.Location = new System.Drawing.Point(35, 49);
            this.lbl_gtarih.Name = "lbl_gtarih";
            this.lbl_gtarih.Size = new System.Drawing.Size(123, 24);
            this.lbl_gtarih.TabIndex = 21;
            this.lbl_gtarih.Text = "Giriş tarihi:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(530, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(221, 591);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(102, 74);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 30;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(799, 218);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(119, 95);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(35, 502);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(132, 90);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 32;
            this.pictureBox9.TabStop = false;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim.ForeColor = System.Drawing.Color.Red;
            this.lbl_isim.Location = new System.Drawing.Point(488, 132);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(435, 71);
            this.lbl_isim.TabIndex = 44;
            this.lbl_isim.Text = "ⒺⓈⓄⓉⓄⓅⒶⓇⓀ";
            // 
            // Araç_Çıkış
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 677);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox_ucret);
            this.Controls.Add(this.lbl_parkyeritxt);
            this.Controls.Add(this.lbl_parkyeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.groupBox_abilgi);
            this.Controls.Add(this.cmbbox_plaka);
            this.Controls.Add(this.lbl_aracplaka);
            this.Name = "Araç_Çıkış";
            this.Text = "Araç Çıkış";
            this.Load += new System.EventHandler(this.Araç_Çıkış_Load);
            this.groupBox_abilgi.ResumeLayout(false);
            this.groupBox_abilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_ucret.ResumeLayout(false);
            this.groupBox_ucret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_aracplaka;
        private System.Windows.Forms.ComboBox cmbbox_plaka;
        private System.Windows.Forms.Label lbl_ucret;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_telno;
        private System.Windows.Forms.Label lbl_marka;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_adtxt;
        private System.Windows.Forms.Label lbl_soyadtxt;
        private System.Windows.Forms.Label lbl_telnotxt;
        private System.Windows.Forms.GroupBox groupBox_abilgi;
        private System.Windows.Forms.Label lbl_markatxt;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ucrettxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_aracyikama;
        private System.Windows.Forms.Label lbl_yikama;
        private System.Windows.Forms.Label lbl_modeltxt;
        private System.Windows.Forms.Label lbl_parkyeri;
        private System.Windows.Forms.Label lbl_parkyeritxt;
        private System.Windows.Forms.GroupBox groupBox_ucret;
        private System.Windows.Forms.Label lbl_gtarih;
        private System.Windows.Forms.Label lbl_ctarihi;
        private System.Windows.Forms.Label lbl_gtarihitxt;
        private System.Windows.Forms.Label lbl_ctarihitxt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lbl_isim;
    }
}