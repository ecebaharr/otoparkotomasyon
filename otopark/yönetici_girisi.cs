using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace otopark
{
    public partial class yönetici_girisi : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\Ece\\source\\repos\\otomasyon\\otomasyon\\bin\\Debug\\net8.0-windows\\otomasyon.accdb");
   
        public yönetici_girisi()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {

            string yoneticiadi = txt_yönetici.Text;
            string sifre = txt_sifre.Text;
            bool kayitli_mi = false;


            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM yoneticiBilgi", connection);
            OleDbDataReader reader = command.ExecuteReader(); //executeReader select sorgusuyla ile çektiğimiz kayıtların veri akışını sağlar

            while (reader.Read())
            {
                if (yoneticiadi == reader["yoneticiK_adi"].ToString() && sifre == reader["yonetici_sifre"].ToString())
                {
                    MessageBox.Show("Giriş başarıyla gerçekleşti.");
                    kayitli_mi = true;
                    Form giriş = new yoneticianasayfa();
                    giriş.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifreyi hatalı girdiniz. Lütfen tekrar deneyiniz.");
                    txt_yönetici.Clear();
                    txt_sifre.Clear();
                }

                break;

            }
            connection.Close();


        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form kullanicigiris = new kullanici_giris();
            kullanicigiris.Show();
            this.Hide();
        }

        private void yönetici_girisi_Load(object sender, EventArgs e)
        {

        }

        private void lnklbl_sifreunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form sifre = new yonetici_sifreunuttum();
            sifre.Show();
            this.Hide();
        }
    }
}
