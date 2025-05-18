using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kuaforf
{

    public partial class AdminPanelForm : Form
    {
        string connectionString = "Data Source=DESKTOP-P2A5VKK\\SQLEXPRESS;Initial Catalog=KuaforDB;Integrated Security=True;";

        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            PersonelleriYukle();
            KullanicilariYukle();
        }

        private void PersonelleriYukle()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT PersonelID, Ad, Soyad FROM Personel", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPersoneller.DataSource = dt;
                dgvPersoneller.Columns["PersonelID"].HeaderText = "Personel ID";
                dgvPersoneller.Columns["Ad"].HeaderText = "Ad";
                dgvPersoneller.Columns["Soyad"].HeaderText = "Soyad";
            }
        }

        private void KullanicilariYukle()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT ID, Email FROM Kullanici", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKullanicilar.DataSource = dt;
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            string ad = txtPersonelAd.Text.Trim();
            string soyad = txtPersonelSoyad.Text.Trim();

            if (ad == "" || soyad == "")
            {
                MessageBox.Show("Lütfen ad ve soyad giriniz.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Personel (Ad, Soyad) VALUES (@ad, @soyad)", conn);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Personel eklendi.");
            txtPersonelAd.Clear();
            txtPersonelSoyad.Clear();
            PersonelleriYukle();
        }


        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek kullanıcıyı seçin.");
                return;
            }

            int kullaniciID = Convert.ToInt32(dgvKullanicilar.SelectedRows[0].Cells["ID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Kullanici WHERE ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", kullaniciID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kullanıcı silindi.");
            KullanicilariYukle();
        }


        private void btnPersonelSil_Click_1(object sender, EventArgs e)
        {
            if (dgvPersoneller.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek personeli seçin.");
                return;
            }

            int personelID = Convert.ToInt32(dgvPersoneller.SelectedRows[0].Cells["PersonelID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Personel WHERE PersonelID = @id", conn);
                cmd.Parameters.AddWithValue("@id", personelID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Personel silindi.");
            PersonelleriYukle();
        }
    }
}