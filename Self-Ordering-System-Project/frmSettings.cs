using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Self_Ordering_System_Project
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
            }else if(comboBox1.SelectedIndex == 1) {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            
            if (colorDialog1.ShowDialog() == DialogResult.OK) { 
                frmOrderTypeScreen.HomeForm.BackColor = colorDialog1.Color;
                this.BackColor = colorDialog1.Color;
                frmHomeScreen.PopularForm.BackColor = colorDialog1.Color;
            }
        }
        bool isplaying = false;
        WindowsMediaPlayer mediaPlayer = new WindowsMediaPlayer();
        //SoundPlayer player =  new SoundPlayer(@"C:\Users\user\OneDrive\Desktop\ABO-HADHOD\C#-level1\windowFormsTraning\SelfOrederingProject\Images\ukulele.mp3");
        private void button1_Click(object sender, EventArgs e)
        {
            if (isplaying)
            {
                /*
                        Music by https://www.bensound.com/free-music-for-videos
                        License code: BU9CDW9TVXIT2PIR
                        Artist: : Benjamin Tissot
                 */
                // player.Stop();
                mediaPlayer.URL = @"C:\Users\user\OneDrive\Desktop\ABO-HADHOD\C#-level1\windowFormsTraning\SelfOrederingProject\Images\ukulele.mp3";
                mediaPlayer.controls.play();
                isplaying = false;
            }
            else { 
               // player.PlayLooping();
               mediaPlayer.controls.stop();
                isplaying = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.facebook.com/hashem.quraan");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.instagram.com/7a_qu/?hl=en");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.youtube.com/@hashemquraan3933");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.linkedin.com/in/hashem-quraan-1a858b396/");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the Settings Page", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            GlobalList.closeApp = false;
            frmOrderTypeScreen.HomeForm.Show();
            this.Close();
        }

        private void btnPopular_Click(object sender, EventArgs e)
        {
            GlobalList.closeApp = false;
            Form popular = frmHomeScreen.PopularForm;
            popular.Show();
            this.Close();
        }

        private void frmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(GlobalList.closeApp)
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
            Form cart = frmHomeScreen.CartForm;
            cart.Show();
            this.Close();
        }
    }
}
