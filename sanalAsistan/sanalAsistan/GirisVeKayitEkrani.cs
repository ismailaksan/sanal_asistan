using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace sanalAsistan
{
    
    public partial class GirisVeKayitEkrani : Form
    {
        public static int aktifKullaniciId;
        
        String connectionString = "server=localhost;user=root;password=root;database=asistan_db;";
        public GirisVeKayitEkrani()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Kayit_Click(object sender, EventArgs e)
        {
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO kullanici(ad, email, parola) VALUES (@ad, @email, @parola)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ad", textadsoyad.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", textemail.Text.Trim().ToLower());
                    cmd.Parameters.AddWithValue("@parola", textparola.Text.Trim());

                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                        MessageBox.Show("Bu kullanıcı zaten kayıtlı!", "Böyle bir kullanıcı var", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
            }
        }

        private void parola_TextChanged(object sender, EventArgs e)
        {

        }

        private void GirisVeKayitEkrani_Load(object sender, EventArgs e)
        {
            textparola.UseSystemPasswordChar = true;
        }
        public bool KullaniciGirisKontrolu(string email, string parola)
        {
            bool giris = false;
            string query = "SELECT id FROM kullanici WHERE email = @email AND parola = @parola";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@parola", parola);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        giris = true;
                        aktifKullaniciId = Convert.ToInt32(result);
                       
                    }
                }
            }

            return giris;
        }



        private void Giris_Click(object sender, EventArgs e)
        {
            string email = textemail.Text.Trim().ToLower();
            string parola = textparola.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(parola))
            {
                MessageBox.Show("Lütfen geçerli değerler girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KullaniciGirisKontrolu(email, parola))
            {
                listelerandevu form1 = new listelerandevu();
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("E-posta veya parola yanlış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
