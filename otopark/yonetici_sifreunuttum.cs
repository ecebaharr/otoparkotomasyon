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

namespace otopark
{
    public partial class yonetici_sifreunuttum : Form
    {
        public yonetici_sifreunuttum()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =C:\\Users\\Ece\\source\\repos\\otomasyon\\otomasyon\\bin\\Debug\\net8.0-windows\\otomasyon.accdb");


        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection; ;
                command.CommandText = "UPDATE yoneticiBilgi SET yonetici_sifre = '" + txt_yenisifre.Text + "' WHERE yoneticiK_adi = '" + txt_kullaniciadi.Text + "'";
                command.ExecuteNonQuery(); // sql sorgularını yürütmek için kullanılır

                if (txt_yenisifre.Text == txt_sifre1.Text)
                {
                    MessageBox.Show("Şifreniz güncellendi.");
                    this.Hide();
                }

                else
                {
                    connection.Close();
                    MessageBox.Show("Girmiş oldugunuz şifreler farklı tekrar giriniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txt_kullaniciadi.Text = "";
                txt_yenisifre.Clear();
                txt_sifre1.Text = "";
                connection.Close();
            }
            Form giriş = new yönetici_girisi();
            giriş.Show();
            this.Hide();
        }

        private void yonetici_sifreunuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
