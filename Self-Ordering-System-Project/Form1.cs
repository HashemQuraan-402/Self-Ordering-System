using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Self_Ordering_System_Project
{
    public partial class frmWelcomingScreen : Form
    {
        
        public frmWelcomingScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form orederTypeScreenForm = new frmOrderTypeScreen();
            orederTypeScreenForm.Show();
            this.Hide();
        }

        private void frmWelcomingScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
