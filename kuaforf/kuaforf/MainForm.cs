using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace kuaforf
{
    public partial class MainForm : Form
    {
        private string kullaniciEmail;

        public MainForm(string email)
        {
            InitializeComponent();
            kullaniciEmail = email;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            RandevuAlForm randevuForm = new RandevuAlForm(kullaniciEmail);
            randevuForm.ShowDialog();
        }

        private void btnRandevularim_Click(object sender, EventArgs e)
        {
            RandevularimForm form = new RandevularimForm(kullaniciEmail);
            form.Show();
        }
    }

}
