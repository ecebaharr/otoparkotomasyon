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


namespace otopark
{
    public partial class marka_ekle : Form
    {
        public marka_ekle()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\Ece\\source\\repos\\otomasyon\\otomasyon\\bin\\Debug\\net8.0-windows\\otomasyon.accdb");

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            connection.Open();
          
            bool kayitli_mi = false;

            string yeniMarka = txt_yenimarka.Text; 

            
            OleDbCommand command = new OleDbCommand("SELECT aracmarka FROM aracBilgileri WHERE aracmarka = @marka", connection);
            command.Parameters.AddWithValue("@marka", yeniMarka);

            OleDbDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Eklediğiniz marka sistemimizde bulunmaktadır. Lütfen geçerli bir marka yazınız ya da kayıt sayfasına dönüp geçerli bir marka seçiniz.");
                txt_yenimarka.Clear();
            }
            else
            {
                reader.Close();

                OleDbCommand insertCommand = new OleDbCommand("INSERT INTO aracBilgileri(aracmarka) VALUES (@marka)", connection);
                insertCommand.Parameters.AddWithValue("@marka", yeniMarka);

                int affectedRows = insertCommand.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Marka başarıyla eklendi.");
                    kayitli_mi = true;

                    Form giris = new araç_kayıt();
                    giris.Show();
                    this.Hide();
                }
            }

            connection.Close();

   
        }

        private void marka_ekle_Load(object sender, EventArgs e)
        {

        }

       

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form geri = new araç_kayıt();
            geri.Show();
            this.Hide();
        }

        private void txt_yenimarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();

           
        }
    }
}
