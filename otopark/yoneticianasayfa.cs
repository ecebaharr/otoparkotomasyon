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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace otopark
{
    
    public partial class yoneticianasayfa : Form
    {
        public yoneticianasayfa()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =C:\\Users\\Ece\\source\\repos\\otomasyon\\otomasyon\\bin\\Debug\\net8.0-windows\\otomasyon.accdb");

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btn_gecmis_Click(object sender, EventArgs e)
        {
            Form geçmiş = new gecmis();
            geçmiş.Show();
            this.Hide();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form geri = new yönetici_girisi();
            geri.Show();
            this.Hide();
        }

        private void yoneticianasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btn_gelir_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand cmd = new OleDbCommand("Select SUM(ucret) from gecmis", connection);
             object result= cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                decimal toplamUcret = Convert.ToDecimal(result);
              ucret_label.Text = toplamUcret.ToString() + " TL";
            }
            else
            {
                Console.WriteLine("Veri bulunamadı.");
            }

            connection.Close();
        }
    }
}
