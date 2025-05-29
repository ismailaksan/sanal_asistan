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
    public partial class anımsatıcıcListele : Form
    {
        public anımsatıcıcListele()
        {
            InitializeComponent();
        }

        private void anımsatıcıcListele_Load(object sender, EventArgs e)
        {
            int kullaniciId = GirisVeKayitEkrani.aktifKullaniciId;
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=root;database=asistan_db;"))
            {
                conn.Open();
                string query = "SELECT id, baslik, aciklama, tarih FROM hatirlatici WHERE kullanici_id = @kullanici_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kullanici_id", kullaniciId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvAnimsaticilar.DataSource = dt;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvAnimsaticilar.SelectedRows.Count > 0)
            {
                int secilenId = Convert.ToInt32(dgvAnimsaticilar.SelectedRows[0].Cells["id"].Value);

                using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=root;database=asistan_db;"))
                {
                    conn.Open();
                    string query = "DELETE FROM hatirlatici WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", secilenId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Anımsatıcı silindi.");
                anımsatıcıcListele_Load(null, null);
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçin.");
            }
        }
    }
}
