using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace otopark
{
    public partial class kullanici_giris : Form
    {

       
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =C:\\Users\\Ece\\source\\repos\\otomasyon\\otomasyon\\bin\\Debug\\net8.0-windows\\otomasyon.accdb")
        {
        };

        public kullanici_giris()
        {
            InitializeComponent();
        }

        private void kullanici_giris_Load(object sender, EventArgs e)
        {

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linklbl_sifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form sifre = new sifremi_unuttum();
            sifre.Show();
            this.Hide();
        }
        int hak = 3;
        private void btn_giris_Click(object sender, EventArgs e)
        {
            connection.Open();

            string kullaniciadi = txt_kullanici.Text;
            string sifre = txt_sifre.Text;
            bool kayitli_mi = false;

           // connection.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM kullanicilar", connection);
            OleDbDataReader reader = cmd.ExecuteReader(); //executeReader select sorgusuyla ile çektiğimiz kayıtların veri akışını sağlar
            while (reader.Read())
            {
                if (kullaniciadi == reader["kullaniciadi"].ToString() && sifre == reader["sifre"].ToString())
                {
                    MessageBox.Show("Giriş başarıyla gerçekleşti.");
                        kayitli_mi =true;
                    Form giriş = new Giriş_sayfası();
                    giriş.Show();
                    this.Hide();

                }
                else 
                {
                    hak--;
                    MessageBox.Show("Kullanıcı adı veya şifreyi hatalı girdiniz. Lütfen tekrar deneyiniz ve " + hak + " hakkınızın kaldığını unutmayınız.");
                    txt_kullanici.Clear();
                    txt_sifre.Clear();
                    if(hak==0)
                    {
                        MessageBox.Show("Uygulamadan çıkışınız yapılıyor.");
                        Application.Exit();
                    }
                }

                break;
               
            }
            connection.Close();

        }
  

        private void button2_Click(object sender, EventArgs e)
        {
            Form yönetici = new yönetici_girisi();
            yönetici.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }


