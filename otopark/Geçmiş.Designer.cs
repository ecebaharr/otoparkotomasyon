namespace otopark
{
    partial class gecmis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gecmis));
            this.btn_geri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_plaka = new System.Windows.Forms.Label();
            this.picturebox_sorgu = new System.Windows.Forms.PictureBox();
            this.btn_çıkış = new System.Windows.Forms.Button();
            this.cmbbox_plaka = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_sorgu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_geri.Location = new System.Drawing.Point(694, 476);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(158, 40);
            this.btn_geri.TabIndex = 12;
            this.btn_geri.Text = "Geri dön";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(840, 396);
            this.dataGridView1.TabIndex = 13;
            // 
            // lbl_plaka
            // 
            this.lbl_plaka.AutoSize = true;
            this.lbl_plaka.BackColor = System.Drawing.Color.Transparent;
            this.lbl_plaka.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_plaka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(148)))), ((int)(((byte)(32)))));
            this.lbl_plaka.Location = new System.Drawing.Point(129, 470);
            this.lbl_plaka.Name = "lbl_plaka";
            this.lbl_plaka.Size = new System.Drawing.Size(72, 24);
            this.lbl_plaka.TabIndex = 14;
            this.lbl_plaka.Text = "Plaka:";
            // 
            // picturebox_sorgu
            // 
            this.picturebox_sorgu.BackColor = System.Drawing.Color.Transparent;
            this.picturebox_sorgu.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_sorgu.Image")));
            this.picturebox_sorgu.Location = new System.Drawing.Point(327, 460);
            this.picturebox_sorgu.Name = "picturebox_sorgu";
            this.picturebox_sorgu.Size = new System.Drawing.Size(46, 46);
            this.picturebox_sorgu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_sorgu.TabIndex = 16;
            this.picturebox_sorgu.TabStop = false;
            this.picturebox_sorgu.Click += new System.EventHandler(this.picturebox_sorgu_Click);
            // 
            // btn_çıkış
            // 
            this.btn_çıkış.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(43)))), ((int)(((byte)(22)))));
            this.btn_çıkış.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_çıkış.BackgroundImage")));
            this.btn_çıkış.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_çıkış.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_çıkış.Location = new System.Drawing.Point(812, 420);
            this.btn_çıkış.Name = "btn_çıkış";
            this.btn_çıkış.Size = new System.Drawing.Size(40, 41);
            this.btn_çıkış.TabIndex = 17;
            this.btn_çıkış.UseVisualStyleBackColor = false;
            this.btn_çıkış.Click += new System.EventHandler(this.btn_çıkış_Click);
            // 
            // cmbbox_plaka
            // 
            this.cmbbox_plaka.FormattingEnabled = true;
            this.cmbbox_plaka.Location = new System.Drawing.Point(200, 470);
            this.cmbbox_plaka.Name = "cmbbox_plaka";
            this.cmbbox_plaka.Size = new System.Drawing.Size(121, 24);
            this.cmbbox_plaka.TabIndex = 18;
            // 
            // gecmis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 528);
            this.Controls.Add(this.cmbbox_plaka);
            this.Controls.Add(this.btn_çıkış);
            this.Controls.Add(this.picturebox_sorgu);
            this.Controls.Add(this.lbl_plaka);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_geri);
            this.Name = "gecmis";
            this.Text = "Geçmiş";
            this.Load += new System.EventHandler(this.gecmis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_sorgu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_plaka;
        private System.Windows.Forms.PictureBox picturebox_sorgu;
        private System.Windows.Forms.Button btn_çıkış;
        private System.Windows.Forms.ComboBox cmbbox_plaka;
    }
}