using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuaforf
{
    public partial class KayitOlForm : Form
    {
        public KayitOlForm()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (email == "" || sifre == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            string connectionString = "Data Source=DESKTOP-P2A5VKK\\SQLEXPRESS;Initial Catalog=KuaforDB;Integrated Security=True;";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    //Aynı e-posta daha önce kayıtlı mı
                    string kontrolQuery = "SELECT COUNT(*) FROM Kullanici WHERE Email = @email";
                    SqlCommand kontrolCmd = new SqlCommand(kontrolQuery, baglanti);
                    kontrolCmd.Parameters.AddWithValue("@email", email);
                    int varMi = (int)kontrolCmd.ExecuteScalar();

                    if (varMi > 0)
                    {
                        MessageBox.Show("Bu e-posta zaten kayıtlı!");
                        return;
                    }

                    //Kayıt işlemi
                    string insertQuery = "INSERT INTO Kullanici (Email, Sifre) VALUES (@email, @sifre)";
                    SqlCommand cmd = new SqlCommand(insertQuery, baglanti);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı. Giriş yapabilirsiniz.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

    }
}