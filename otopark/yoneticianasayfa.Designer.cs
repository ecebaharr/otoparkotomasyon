namespace otopark
{
    partial class yoneticianasayfa
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
            System.Windows.Forms.Button btn_geri;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yoneticianasayfa));
            this.btn_gelir = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_gecmis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ucret_label = new System.Windows.Forms.Label();
            btn_geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_geri
            // 
            btn_geri.BackColor = System.Drawing.SystemColors.WindowFrame;
            btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            btn_geri.Location = new System.Drawing.Point(498, 333);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new System.Drawing.Size(95, 34);
            btn_geri.TabIndex = 1;
            btn_geri.Text = "Geri Dön";
            btn_geri.UseVisualStyleBackColor = false;
            btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_gelir
            // 
            this.btn_gelir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(184)))), ((int)(((byte)(71)))));
            this.btn_gelir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gelir.Location = new System.Drawing.Point(44, 217);
            this.btn_gelir.Name = "btn_gelir";
            this.btn_gelir.Size = new System.Drawing.Size(296, 52);
            this.btn_gelir.TabIndex = 2;
            this.btn_gelir.Text = "Toplam Geliri Hesapla";
            this.btn_gelir.UseVisualStyleBackColor = false;
            this.btn_gelir.Click += new System.EventHandler(this.btn_gelir_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(43)))), ((int)(((byte)(22)))));
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Location = new System.Drawing.Point(551, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(42, 37);
            this.btn_cikis.TabIndex = 14;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_gecmis
            // 
            this.btn_gecmis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(184)))), ((int)(((byte)(71)))));
            this.btn_gecmis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gecmis.Location = new System.Drawing.Point(44, 95);
            this.btn_gecmis.Name = "btn_gecmis";
            this.btn_gecmis.Size = new System.Drawing.Size(296, 52);
            this.btn_gecmis.TabIndex = 15;
            this.btn_gecmis.Text = "Geçmiş";
            this.btn_gecmis.UseVisualStyleBackColor = false;
            this.btn_gecmis.Click += new System.EventHandler(this.btn_gecmis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(365, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Toplam Gelir=";
            // 
            // ucret_label
            // 
            this.ucret_label.AutoSize = true;
            this.ucret_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucret_label.ForeColor = System.Drawing.Color.Red;
            this.ucret_label.Location = new System.Drawing.Point(519, 237);
            this.ucret_label.Name = "ucret_label";
            this.ucret_label.Size = new System.Drawing.Size(0, 16);
            this.ucret_label.TabIndex = 17;
            // 
            // yoneticianasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(609, 381);
            this.Controls.Add(this.ucret_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_gecmis);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_gelir);
            this.Controls.Add(btn_geri);
            this.Name = "yoneticianasayfa";
            this.Text = "Yönetici Anasayfa";
            this.Load += new System.EventHandler(this.yoneticianasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_gelir;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_gecmis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ucret_label;
    }
}