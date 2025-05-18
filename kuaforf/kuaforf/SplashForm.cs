using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuaforf
{
    public partial class SplashForm : Form
    {
        Timer timer;
        double opacityIncrement = 0.05; // Opaklığı artırma hızı
        bool fadingIn = true;

        public SplashForm()
        {
            InitializeComponent();
            this.Opacity = 0; // Başlangıçta görünmez
            this.StartPosition = FormStartPosition.CenterScreen;

            timer = new Timer();
            timer.Interval = 100; // 50 ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (fadingIn)
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += opacityIncrement; // Yavaş yavaş görünür yap
                }
                else
                {
                    fadingIn = false; // Şimdi kaybolmaya başla
                }
            }
            else
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= opacityIncrement; // Yavaş yavaş kaybol
                }
                else
                {
                    timer.Stop();
                    this.Hide();

                    // Splash bitti, giriş formunu aç
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
        }
    }

}
