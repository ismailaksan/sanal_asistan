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
    public partial class animsatici : Form
    {
        public animsatici()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int kullaniciId = GirisVeKayitEkrani.aktifKullaniciId;
            string baslik = txtBaslik.Text.Trim();
            string aciklama = txtAciklama.Text.Trim();
            DateTime tarih = dtpTarih.Value;

            if (string.IsNullOrEmpty(baslik))
            {
                MessageBox.Show("Başlık boş olamaz.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=root;database=asistan_db;"))
            {
                conn.Open();
                string query = "INSERT INTO hatirlatici (kullanici_id, baslik, aciklama, tarih) VALUES (@kullanici_id, @baslik, @aciklama, @tarih)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kullanici_id", kullaniciId);
                cmd.Parameters.AddWithValue("@baslik", baslik);
                cmd.Parameters.AddWithValue("@aciklama", aciklama);
                cmd.Parameters.AddWithValue("@tarih", tarih);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Anımsatıcı kaydedildi.");
            this.Close();
        }
    }
}
