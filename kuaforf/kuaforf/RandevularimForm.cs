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
    public partial class RandevularimForm : Form
    {
        private string kullaniciEmail;

        public RandevularimForm(string email)
        {
            InitializeComponent();
            kullaniciEmail = email;
        }

        private void RandevularimForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-P2A5VKK\\SQLEXPRESS;Initial Catalog=KuaforDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Tarih, Saat, Islem FROM Randevular WHERE Email = @Email";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Email", kullaniciEmail);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRandevular.DataSource = dt;
            }

            dgvRandevular.Columns["Id"].Visible = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvRandevular.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz randevuyu seçin.");
                return;
            }

            int secilenId = Convert.ToInt32(dgvRandevular.SelectedRows[0].Cells["Id"].Value);

            string connectionString = "Data Source=DESKTOP-P2A5VKK\\SQLEXPRESS;Initial Catalog=KuaforDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Randevular WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", secilenId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Randevu silindi.");
            RandevularimForm_Load(null, null);
        }

    }
}
