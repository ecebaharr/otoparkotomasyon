using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark
{
    public partial class Otopark_anasayfa : Form
    {
        public Otopark_anasayfa()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Otopark_anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form kullanıcıgirisi = new kullanici_giris();
            kullanıcıgirisi.Show();
            this.Hide();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            Form araçkayıt = new araç_kayıt();
            araçkayıt.Show();
            this.Hide();

        }

        private void btn_acikis_Click(object sender, EventArgs e)
        {
            Form araççıkış = new Araç_Çıkış();
            araççıkış.Show();
            this.Hide();

        }

        private void btn_otoparkyer_Click(object sender, EventArgs e)
        {
            Form yerdurumu = new park_yeri();
            yerdurumu.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
