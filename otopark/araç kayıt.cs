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

namespace otopark
{
    public partial class araç_kayıt : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\Ece\\source\\repos\\otomasyon\\otomasyon\\bin\\Debug\\net8.0-windows\\otomasyon.accdb");
        public araç_kayıt()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form geri = new Otopark_anasayfa();
            geri.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void araç_kayıt_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM parkYerleri where durum like (0) ", connection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbbox_park.Items.Add(reader["parkyeri"].ToString());
            }
            connection.Close();

            connection.Open();
            OleDbCommand command7 = new OleDbCommand("SELECT aracmarka FROM aracBilgileri", connection);
            OleDbDataReader reader1 = command7.ExecuteReader();
            while (reader1.Read())
            {
                cmbbox_marka.Items.Add(reader1["aracmarka"].ToString());
            }
            connection.Close();

        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {

            string tarih = DateTime.Now.ToString();
            connection.Open();
            OleDbCommand command2 = new OleDbCommand("insert into müsteriBilgi (ad, soyad, telno, marka, model, plaka, parkno, durum, giristarihi, aracyikama)values ('" + txt_ad.Text + "','" + txt_soyad.Text + "','" + txt_telno.Text + "','" + cmbbox_marka.Text + "','" + txt_model.Text + "','" + txt_plaka.Text + "','" + cmbbox_park.Text  + "','0','" + tarih.ToString() + "','"+ cmbbox_yikama.Text+ "')", connection); // "','0'," +
            command2.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            OleDbCommand command3 = new OleDbCommand("update parkYerleri set durum = '1' WHERE parkyeri like'" + cmbbox_park.Text + "'", connection);
            command3.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            OleDbCommand command4 = new OleDbCommand("insert into gecmis (ad, soyad, telno, marka, model, plaka, parkno, giristarihi, aracyikama)values ('" + txt_ad.Text + "','" + txt_soyad.Text + "','" + txt_telno.Text + "','" + cmbbox_marka.Text + "','" + txt_model.Text + "','" + txt_plaka.Text + "','" + cmbbox_park.Text + "','" + tarih.ToString() + "','" + cmbbox_yikama.Text + "')", connection);
            command4.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            OleDbCommand command5 = new OleDbCommand("insert into aracBilgileri (aracmarka)values ('" + cmbbox_marka.Text + "')", connection); // "','0'," +
            command5.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Aracınız başarıyla kaydedildi.");
            Form konum = new park_yeri();
            konum.Show();
            this.Hide();
                }

        private void txt_plaka_TextChanged(object sender, EventArgs e)
        {
            txt_plaka.MaxLength = 11;
        }

        private void txt_model_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void txt_telno_TextChanged(object sender, EventArgs e)
        {
            txt_telno.MaxLength = 11;
        }

        private void btn_markaekle_Click(object sender, EventArgs e)
        {
            Form markaekle = new marka_ekle();
            markaekle.Show();
            this.Hide();

           
        }

        private void txt_telno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; 
            }
        }

       /* private void cmbbox_marka_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 4; 

             if (cmbbox_marka.Text.Length >= maxLength && e.KeyChar != '\b')
            {
                e.Handled = true; 
            }
        }*/

        private void cmbbox_park_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 3; 

             if (cmbbox_park.Text.Length >= maxLength && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void cmbbox_yikama_KeyPress(object sender, KeyPressEventArgs e)
        {
            int maxLength = 5;

            if (cmbbox_yikama.Text.Length >= maxLength && e.KeyChar != '\b')
            {
                e.Handled = true; 
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }
    }
}
