using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Intro : Form
    {
        int i = 0;
        public Intro()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (i <= progressBar1.Maximum)
            {
                progressBar1.Value = i;
                UpdateProgressLabel();
                i++;
            }
            else
            {
                timer1.Stop();
                Hideinfo();
                ShowLogin();
            }
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            timer1.Interval = 30;
            timer1.Start();
        }
        private void Hideinfo()
        {
            this.Hide();
        }

        private void ShowLogin()
        {
            Login ShowLogin = new Login();
            ShowLogin.Show();
        }
        private void UpdateProgressLabel()
        {
            progressLabel.Text = $"Loading:{i}%";
        }
    }
}
