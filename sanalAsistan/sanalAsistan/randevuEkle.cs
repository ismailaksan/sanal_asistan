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
    public partial class randevuEkle : Form
    {
        public randevuEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void randevuEkle_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void KaydetRandevu_Click(object sender, EventArgs e)
        {
            string baslik = textBaslik.Text;
            string aciklama= textAciklama.Text;
            DateTime tarih = dateTimePicker1.Value.Date;

            if (string.IsNullOrEmpty(baslik) || string.IsNullOrEmpty(aciklama)) {
                MessageBox.Show("Başlık veya açıklama boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=root;database=asistan_db;"))
            {
                conn.Open();
                string sql = "INSERT INTO randevu (kullanici_id, baslik, aciklama, tarih) VALUES (@kullanici_id, @baslik, @aciklama, @tarih)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kullanici_id", GirisVeKayitEkrani.aktifKullaniciId);
                cmd.Parameters.AddWithValue("@baslik", baslik);
                cmd.Parameters.AddWithValue("@aciklama", aciklama);
                cmd.Parameters.AddWithValue("@tarih", tarih);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Randevu başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
