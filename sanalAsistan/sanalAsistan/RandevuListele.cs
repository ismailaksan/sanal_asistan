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
    public partial class RandevuListele : Form
    {
        public RandevuListele()
        {
            InitializeComponent();
        }

        private void RandevuListele_Load(object sender, EventArgs e)
        {
            int kullaniciId = GirisVeKayitEkrani.aktifKullaniciId;

            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=root;database=asistan_db;"))
            {
                conn.Open();
                string query = "SELECT id, tarih, aciklama FROM randevu WHERE kullanici_id = @kullanici_id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kullanici_id", kullaniciId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dataGridView1.Columns.Contains("id"))
                    {
                        dataGridView1.Columns["id"].Visible = false;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butonSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int seciliId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                DialogResult onay = MessageBox.Show("Bu randevuyu silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password=root;database=asistan_db;"))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM randevu WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@id", seciliId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Randevu silindi.");

                    // Listeyi güncelle
                    RandevuListele_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir randevu seçin.");
            }
        }
    }
}
