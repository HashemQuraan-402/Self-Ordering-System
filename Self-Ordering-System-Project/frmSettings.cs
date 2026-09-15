using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace Self_Ordering_System_Project
{
    public partial class frmSettings : Form
    {
        private readonly WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
        private bool isPlaying;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool showFirstLanguage = comboBox1.SelectedIndex == 0;

            label1.Visible = showFirstLanguage;
            label2.Visible = showFirstLanguage;
            label3.Visible = showFirstLanguage;
            label4.Visible = showFirstLanguage;
            label5.Visible = !showFirstLanguage;
            label6.Visible = !showFirstLanguage;
            label7.Visible = !showFirstLanguage;
            label8.Visible = !showFirstLanguage;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            frmOrderTypeScreen.HomeForm.BackColor = colorDialog1.Color;
            BackColor = colorDialog1.Color;
            frmHomeScreen.PopularForm.BackColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                mediaPlayer.controls.stop();
                isPlaying = false;
                return;
            }

            string musicPath = Path.Combine(Application.StartupPath, "Resources", "ukulele.mp3");

            if (!File.Exists(musicPath))
            {
                MessageBox.Show(
                    "The background-audio file could not be found.",
                    "Audio File Missing",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // "Ukulele" by Benjamin Tissot (Bensound). See README.md for the asset notice.
            mediaPlayer.URL = musicPath;
            mediaPlayer.controls.play();
            isPlaying = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/hashem.quraan");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/7a_qu/?hl=en");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@hashemquraan3933");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/hashem-quraan-b561453ab");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "You are in the Settings Page",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            GlobalList.closeApp = false;
            frmOrderTypeScreen.HomeForm.Show();
            Close();
        }

        private void btnPopular_Click(object sender, EventArgs e)
        {
            GlobalList.closeApp = false;
            frmHomeScreen.PopularForm.Show();
            Close();
        }

        private void frmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (GlobalList.closeApp)
            {
                frmOrderTypeScreen.HomeForm.Show();
            }

            GlobalList.closeApp = true;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            GlobalList.closeApp = false;
            frmHomeScreen.CartForm.Show();
            Close();
        }
    }
}
