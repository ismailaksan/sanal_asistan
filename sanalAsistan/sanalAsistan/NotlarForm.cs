using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sanalAsistan
{
    public partial class NotlarForm : Form
    {
        string connectionString = "server=localhost;user=root;password=root;database=asistan_db;";

        public NotlarForm()
        {
            InitializeComponent();
        }
        private void NotlariYukle()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sql = "SELECT id, baslik, icerik, tarih FROM notlar WHERE kullanici_id = @kId";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@kId", GirisVeKayitEkrani.aktifKullaniciId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvNotlar.DataSource = dt;
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string sql = "INSERT INTO notlar (kullanici_id, baslik, icerik) VALUES (@kId, @b, @i)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@kId", GirisVeKayitEkrani.aktifKullaniciId);
                cmd.Parameters.AddWithValue("@b", textBaslik.Text);
                cmd.Parameters.AddWithValue("@i", textIcerik.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Not eklendi!");
                NotlariYukle();
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvNotlar.SelectedRows.Count > 0)
            {
                int secilenId = Convert.ToInt32(dgvNotlar.SelectedRows[0].Cells["id"].Value);
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string sql = "DELETE FROM notlar WHERE id = @id AND kullanici_id = @kId";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", secilenId);
                    cmd.Parameters.AddWithValue("@kId", GirisVeKayitEkrani.aktifKullaniciId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Not silindi!");
                    NotlariYukle();
                }
            }
        }

        private void NotlarForm_Load(object sender, EventArgs e)
        {
            NotlariYukle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kullaniciId = GirisVeKayitEkrani.aktifKullaniciId;
            string dosyaYolu = "notlarim.txt";

            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=root;database=asistan_db;"))
            {
                conn.Open();
                string query = "SELECT baslik, icerik, tarih FROM notlar WHERE kullanici_id = @kullanici_id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kullanici_id", kullaniciId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        using (StreamWriter writer = new StreamWriter(dosyaYolu))
                        {
                            while (reader.Read())
                            {
                                string baslik = reader["baslik"].ToString();
                                string icerik = reader["icerik"].ToString();
                                DateTime tarih = Convert.ToDateTime(reader["tarih"]);

                                writer.WriteLine("Başlık: " + baslik);
                                writer.WriteLine("Tarih: " + tarih.ToString("dd.MM.yyyy HH:mm"));
                                writer.WriteLine("İçerik: " + icerik);
                                writer.WriteLine(new string('-', 40));
                            }
                        }
                    }
                }
            }

        }

        private void textBaslik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
