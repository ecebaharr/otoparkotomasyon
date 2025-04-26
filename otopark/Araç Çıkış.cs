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
using Xamarin.Forms;
using System.Globalization;

namespace otopark
{
    public partial class Araç_Çıkış : Form
    {

        public Araç_Çıkış()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\Ece\\source\\repos\\otomasyon\\otomasyon\\bin\\Debug\\net8.0-windows\\otomasyon.accdb");


        private void Araç_Çıkış_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM müsteriBilgi WHERE durum =0", connection);
            OleDbDataReader reader  = command.ExecuteReader();
            while (reader.Read())
            {
                cmbbox_plaka.Items.Add(reader["plaka"].ToString());
            } connection.Close();
        }
       
        DateTime Tarih;
        string parkyeri = "";
       
        
        


        private void btn_cikis_Click(object sender, EventArgs e)
        {
           // Application.Exit();
           this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form çıkış = new Otopark_anasayfa();
            çıkış.Show();
            this.Hide();
        }

        private void cmbbox_plaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            double aracyikama = 0;
            connection.Open();
            OleDbCommand command2 = new OleDbCommand(" SELECT * FROM müsteriBilgi WHERE durum=0 and plaka LIKE'" + cmbbox_plaka.Text + "'",connection);   
            OleDbDataReader reader2 = command2.ExecuteReader();
            
          
           
            while (reader2.Read())
            {
                lbl_adtxt.Text = reader2["ad"].ToString();
                lbl_soyadtxt.Text = reader2["soyad"].ToString();
                lbl_telnotxt.Text = reader2["telno"].ToString();
                lbl_markatxt.Text = reader2["marka"].ToString();
                lbl_modeltxt.Text = reader2["model"].ToString();
                lbl_yikama.Text = reader2["aracyikama"].ToString(); 

                Tarih = Convert.ToDateTime(reader2["giristarihi"].ToString());
                parkyeri = reader2["parkno"].ToString();
            }
            if (lbl_yikama.Text == "Evet")
            {
                aracyikama = 85;
            }
            else if(lbl_yikama.Text=="Hayır") {
                aracyikama = 0;
                    }

            connection.Close();
            

            connection.Open();
            OleDbCommand command3 = new OleDbCommand("SELECT * FROM gecmis where plaka LIKE'"+cmbbox_plaka.Text+"'", connection);
            OleDbDataReader reader3 = command3.ExecuteReader();
            while(reader3.Read())
            {
                
                lbl_parkyeritxt.Text = reader3["parkno"].ToString();
                lbl_gtarihitxt.Text = reader3["giristarihi"].ToString();
            }

            connection.Close ();



            System.TimeSpan zaman;
             DateTime sonzaman = DateTime.Now;
             zaman = sonzaman.Subtract(Tarih);
             double saat = Convert.ToDouble(zaman.TotalHours);
             double ucret = 10 * double .Parse(saat.ToString("0.##"));
             lbl_ucrettxt.Text= (aracyikama+ucret).ToString() + "₺";


            /*DateTime giriş, çıkış;
            giriş = DateTime.Parse(lbl_gtarihitxt.Text);
            çıkış = DateTime.Parse(lbl_ctarihitxt.Text) ;
            TimeSpan fark;
            fark = çıkış - giriş;
            lbl_suretxt.Text = fark.TotalHours.ToString("0.00");
            lbl_ucrettxt.Text = (double.Parse(lbl_suretxt.Text) * 0.75).ToString("0.00");*/






        }

        private void lbl_ucret_Click(object sender, EventArgs e)
        {

        }

         private void pictureBox1_Click(object sender, EventArgs e)
          {
            connection.Open();  
            OleDbCommand command3 = new OleDbCommand("UPDATE parkYerleri set durum= 0 WHERE parkyeri='" + parkyeri +"'", connection);
            command3.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            OleDbCommand command4 = new OleDbCommand("UPDATE müsteriBilgi set durum=1 WHERE plaka='" + cmbbox_plaka.Text+"'", connection); 
            command4.ExecuteNonQuery();
            connection.Close();

            connection.Open();
            OleDbCommand command5 = new OleDbCommand("UPDATE gecmis set cikistarihi='" + DateTime.Now + "',ucret= '" + lbl_ucrettxt.Text + "' where plaka='" + cmbbox_plaka.SelectedItem.ToString() + "'", connection); ;
            command5.ExecuteNonQuery();
            connection.Close();



            connection.Open();
            OleDbCommand command6 = new OleDbCommand("SELECT * FROM gecmis where plaka LIKE'" + cmbbox_plaka.Text + "'", connection);
            OleDbDataReader reader3 = command6.ExecuteReader();

            

            
            while (reader3.Read())
            {
                
                lbl_ctarihitxt.Text = reader3["cikistarihi"].ToString();
                   
            } timer1.Stop();
           



            MessageBox.Show("Aracınızın çıkış işlemi başarıyla gerçekleşmiştir. Tekrar bekleriz.");
            connection.Close();
          
            cmbbox_plaka.Items.Clear();
            Araç_Çıkış_Load(sender, e);
         
            timer1.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            lbl_ctarihitxt.Text = DateTime.Now.ToString();

           
        }  
    }
}
