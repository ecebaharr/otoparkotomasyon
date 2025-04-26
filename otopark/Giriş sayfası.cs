using CircularProgressBar;
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
    public partial class Giriş_sayfası : Form
    {
        public Giriş_sayfası()
        {
            InitializeComponent();
            
            circularProgressBar1.Value = 0;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {

            circularProgressBar1.Value += 4;
            circularProgressBar1.Text = circularProgressBar1.Value.ToString() + "%";

            if (circularProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                Otopark_anasayfa otopark = new Otopark_anasayfa();
                otopark.Show();
            }
          

        }


        private void Giriş_sayfası_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }




    }
    
    }
