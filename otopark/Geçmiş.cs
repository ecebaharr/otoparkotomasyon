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
    public partial class gecmis : Form
    {
        public gecmis()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source =C:\\Users\\Ece\\source\\repos\\otomasyon\\otomasyon\\bin\\Debug\\net8.0-windows\\otomasyon.accdb")


;        DataTable gecmistablo = new DataTable();    
      
        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form geri = new yoneticianasayfa();
            geri.Show();
            this.Hide();
        }

        private void gecmis_Load(object sender, EventArgs e)
        {
            connection.Open();
            gecmistablo.Clear();
            OleDbDataAdapter adapter2 = new OleDbDataAdapter(" SELECT * FROM gecmis", connection);
            adapter2.Fill(gecmistablo);
            dataGridView1.DataSource = gecmistablo;
            connection.Close();

            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM gecmis WHERE plaka", connection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbbox_plaka.Items.Add(reader["plaka"].ToString());
            }
            connection.Close();
        }

        private void picturebox_sorgu_Click(object sender, EventArgs e)
        {
            connection.Open();
            gecmistablo.Clear();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM gecmis WHERE plaka='" + cmbbox_plaka.SelectedItem.ToString()+ "'", connection );
            adapter.Fill(gecmistablo);
            dataGridView1.DataSource = gecmistablo;
            connection.Close();


          
        }

        private void btn_çıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_plaka_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

