using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sanalAsistan
{
    public partial class listelerandevu : Form
    {
        public listelerandevu()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick_1;
            timer1.Start();

            timerSaat.Interval = 1000;
            timerSaat.Tick += timerSaat_Tick;
            timerSaat.Start();

            foreach (Control nesne in this.Controls)
            {
                if (nesne is Button buton)
                {
                    buton.MouseEnter += ButonUzerineGelindi;
                    buton.MouseLeave += ButondanAyrilindi;
                }
            }




        }
        private void ButonUzerineGelindi(object sender, EventArgs e)
        {
            Button buton = sender as Button;
            if (buton != null)
            {
                buton.BackColor = Color.Lavender; 
                buton.ForeColor = Color.White;        
            }
        }

        private void ButondanAyrilindi(object sender, EventArgs e)
        {
            Button buton = sender as Button;
            if (buton != null)
            {
                buton.BackColor = SystemColors.Control; 
                buton.ForeColor = Color.Black;          
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void randevuButton_Click(object sender, EventArgs e)
        {
            randevuEkle randevuForm = new randevuEkle();
            randevuForm.Show();

        }

        private void randevuListele_Click(object sender, EventArgs e)
        {
            RandevuListele randevulisteleForm = new RandevuListele();
            randevulisteleForm.Show();

        }
        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void notDefterineGit_Click(object sender, EventArgs e)
        {
            NotlarForm NotlarFormum = new NotlarForm();
            NotlarFormum.Show();
        }

        private void anımsatıcıListele_Click(object sender, EventArgs e)
        {
            anımsatıcıcListele animsaticiListem= new anımsatıcıcListele();
            animsaticiListem.Show();
        }

        private void anımsaticiEkle_Click(object sender, EventArgs e)
        {
            animsatici animsaticiListem = new animsatici();
            animsaticiListem.Show();
        }

  

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int kullaniciId = GirisVeKayitEkrani.aktifKullaniciId;

            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=root;database=asistan_db;"))
            {
                conn.Open();


                string query = @"SELECT baslik, tarih 
                         FROM hatirlatici 
                         WHERE kullanici_id = @kullanici_id 
                         AND DATE(tarih) = DATE_ADD(CURDATE(), INTERVAL 1 DAY)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kullanici_id", kullaniciId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string baslik = reader.GetString("baslik");
                        DateTime tarih = reader.GetDateTime("tarih");

                        MessageBox.Show($"Yarın için bir hatırlatıcı var:\n\nBaşlık: {baslik}\nTarih: {tarih}", "Anımsatıcı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timerSaat_Tick(object sender, EventArgs e)
        {
            labelSaat.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void labelSaat_Click(object sender, EventArgs e)
        {

        }
    }
}
