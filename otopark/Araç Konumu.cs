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
    public partial class park_yeri : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\Ece\\source\\repos\\otomasyon\\otomasyon\\bin\\Debug\\net8.0-windows\\otomasyon.accdb");
        public park_yeri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form geri = new Otopark_anasayfa();
            geri.Show();
            this.Hide();
        }

        private void park_yeri_Load(object sender, EventArgs e)
        {
             connection.Open();
            OleDbCommand command = new OleDbCommand("select*from parkYerleri,müsteriBilgi where parkYerleri.parkyeri=müsteriBilgi.parkno and müsteriBilgi.durum like(0)",connection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["parkno"].ToString()=="E1") {
                    E1yer.BackColor=Color.Red;
                    E1PLAKA.Text = reader["plaka"].ToString();
                    label1.BackColor = Color.Red;
                    E1PLAKA.BackColor = Color.Red;
                }
                if (reader["parkno"].ToString() == "E2")
                {
                    E2yer.BackColor = Color.Red;
                    E2plaka.Text = reader["plaka"].ToString();
                    label2.BackColor = Color.Red;
                    E2plaka.BackColor = Color.Red;
                }
                if (reader["parkno"].ToString() == "E3")
                {
                    E3yer.BackColor = Color.Red;
                    E3plaka.Text = reader["plaka"].ToString();
                    label3.BackColor = Color.Red;
                    E3plaka.BackColor = Color.Red;
                }
                if (reader["parkno"].ToString() == "E4")
                {
                    E4yer.BackColor = Color.Red;
                    E4plaka.Text = reader["plaka"].ToString();
                    label4.BackColor = Color.Red;
                    E4plaka.BackColor = Color.Red;
                }
                if (reader["parkno"].ToString() == "E5")
                {
                    E5yer.BackColor = Color.Red;
                    E5plaka.Text = reader["plaka"].ToString();
                    label5.BackColor = Color.Red;
                    E5plaka.BackColor = Color.Red;
                }
                if (reader["parkno"].ToString() == "E6")
                {
                    E6yer.BackColor = Color.Red;
                    E6plaka.Text = reader["plaka"].ToString();
                    label6.BackColor = Color.Red;
                    E6plaka.BackColor = Color.Red;
                }
                if (reader["parkno"].ToString() == "E7")
                {
                    E7yer.BackColor = Color.Red;
                    E7plaka.Text = reader["plaka"].ToString();
                    label7.BackColor = Color.Red;
                    E7plaka.BackColor = Color.Red;
                }
                if (reader["parkno"].ToString() == "E8")
                {
                    E8yer.BackColor = Color.Red;
                    E8plaka.Text = reader["plaka"].ToString();
                    label8.BackColor = Color.Red;
                    E8plaka.BackColor = Color.Red;
                }
                if (reader["parkno"].ToString() == "E9")
                {
                    E9yer.BackColor = Color.Red;
                    E9plaka.Text = reader["plaka"].ToString();
                    label9.BackColor = Color.Red;
                    E9plaka.BackColor = Color.Red;
                }
                if (reader["parkno"].ToString() == "E10")
                {
                    E10yer.BackColor = Color.Red;
                    E10plaka.Text = reader["plaka"].ToString();
                    label10.BackColor = Color.Red;
                    E10plaka.BackColor = Color.Red;
                }
                if (reader["parkno"].ToString() == "E11")
                {
                    E11yer.BackColor = Color.Red;
                    E11plaka.Text = reader["plaka"].ToString();
                    label13.BackColor = Color.Red;
                    E11plaka.BackColor = Color.Red;
                }
                if (reader["parkno"].ToString() == "E12")
                {
                    E12yer.BackColor = Color.Red;
                    E12plaka.Text = reader["plaka"].ToString();
                    label12.BackColor = Color.Red;
                    E12plaka.BackColor = Color.Red;
                }
            }


        }

        private void btn_araccikisi_Click(object sender, EventArgs e)
        {
            Form araççıkış = new Araç_Çıkış();
            araççıkış.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
