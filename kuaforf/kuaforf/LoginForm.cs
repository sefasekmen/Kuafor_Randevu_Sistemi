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

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=DESKTOP-P2A5VKK\\SQLEXPRESS;Initial Catalog=KuaforDB;Integrated Security=True;";

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            SqlConnection baglanti = new SqlConnection(connectionString);
            try
            {
                baglanti.Open();
                string query = "SELECT COUNT(*) FROM Kullanici WHERE Email = @email AND Sifre = @sifre";
                SqlCommand cmd = new SqlCommand(query, baglanti);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                int sonuc = (int)cmd.ExecuteScalar();

                if (sonuc > 0)
                {
                    if (email == "admin" && sifre == "1234")
                    {
                        AdminPanelForm adminForm = new AdminPanelForm();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MainForm mainForm = new MainForm(txtEmail.Text);
                        mainForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("E-posta veya şifre hatalı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOlForm kayitForm = new KayitOlForm();
            kayitForm.ShowDialog();
        }
    }

}