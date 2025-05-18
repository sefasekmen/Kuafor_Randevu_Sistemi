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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace kuaforf
{
    public partial class RandevuAlForm : Form
    {
        private string kullaniciEmail;

        public RandevuAlForm(string email)
        {
            InitializeComponent();
            kullaniciEmail = email;
        }

        private void RandevuAlForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-P2A5VKK\\SQLEXPRESS;Initial Catalog=KuaforDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT PersonelID, Ad, Soyad FROM Personel";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                // Personel bilgilerini cmbPersonel'e ekledim
                while (reader.Read())
                {
                    string personelAdSoyad = reader["Ad"].ToString() + " " + reader["Soyad"].ToString();
                    cmbPersonel.Items.Add(new PersonelItem(personelAdSoyad, Convert.ToInt32(reader["PersonelID"])));
                }

                reader.Close();
            }

            // Saat ve işlem seçeneklerini ekledim
            cmbSaat.Items.AddRange(new string[]
            {
        "09:00", "10:00", "11:00", "12:00",
        "13:00", "14:00", "15:00", "16:00", "17:00"
            });

            cmbIslem.Items.AddRange(new string[]
            {
        "Saç Kesimi", "Boya", "Fön", "Sakal Tıraşı"
            });

            // cmbPersonel için DisplayMember ve ValueMember ayarları
            cmbPersonel.DisplayMember = "Text";
            cmbPersonel.ValueMember = "Value";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Tarih ve saat bilgilerini alıyoruz
            string tarih = dtpTarih.Value.ToString("yyyy-MM-dd");
            string saat = cmbSaat.SelectedItem?.ToString();
            string islem = cmbIslem.SelectedItem?.ToString();
            string personelID = ((dynamic)cmbPersonel.SelectedItem).Value.ToString();

            if (saat == null || islem == null)
            {
                MessageBox.Show("Lütfen saat ve işlem seçiniz.");
                return;
            }

            string connectionString = "Data Source=DESKTOP-P2A5VKK\\SQLEXPRESS;Initial Catalog=KuaforDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Parametreli sorguyu güncelleyelim
                string kontrolQuery = "SELECT COUNT(*) FROM Randevular WHERE Tarih = @tarih AND Saat = @saat";
                SqlCommand kontrolCmd = new SqlCommand(kontrolQuery, conn);

                // Parametreleri doğru şekilde ekliyoruz
                kontrolCmd.Parameters.AddWithValue("@tarih", DateTime.Parse(tarih)); // DateTime olarak parametre ekliyoruz
                kontrolCmd.Parameters.AddWithValue("@saat", saat);

                // Sorgu sonucunu alıyoruz
                int sayi = (int)kontrolCmd.ExecuteScalar();

                if (sayi > 0)
                {
                    MessageBox.Show("Bu saat için zaten bir randevu alınmış. Lütfen başka bir saat seçin.");
                    return;
                }

                // Randevuyu ekleme işlemi
                string ekleQuery = "INSERT INTO Randevular (Tarih, Saat, Islem, PersonelID, Email) VALUES (@tarih, @saat, @islem, @personelID, @email)";
                SqlCommand ekleCmd = new SqlCommand(ekleQuery, conn);
                ekleCmd.Parameters.AddWithValue("@tarih", DateTime.Parse(tarih));
                ekleCmd.Parameters.AddWithValue("@saat", saat);
                ekleCmd.Parameters.AddWithValue("@islem", islem);
                ekleCmd.Parameters.AddWithValue("@personelID", personelID);
                ekleCmd.Parameters.AddWithValue("@email", kullaniciEmail);
                ekleCmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Randevu başarıyla kaydedildi!");
            }
        }

    }

    // PersonelItem sınıfını RandevuAlForm sınıfından SONRA ekleyin:
    public class PersonelItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public PersonelItem(string text, int value)
        {
            Text = text;
            Value = value;
        }
    }

}

