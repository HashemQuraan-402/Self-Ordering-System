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
    public partial class frmOrderTypeScreen : Form
    {

        private static frmHomeScreen homeForm;
        public static frmHomeScreen HomeForm
        {
            get {
                if (homeForm == null || homeForm.IsDisposed) { 
                    homeForm = new frmHomeScreen();
                }
                return homeForm;
            }
        }

        public frmOrderTypeScreen()
        {
            InitializeComponent();
        }

        private void frmOrderTypeScreen_Load(object sender, EventArgs e)
        {

        }


        private void click(object sender,EventArgs e)
        {
                Button btn = (Button)sender;
            if (btn.Tag.ToString() == "Take In")
            {
                GlobalList.orderState = "Take In";
            }
            else {
                GlobalList.orderState = "Take Out";
            }
                GlobalList.closeApp = false;
                Form form = HomeForm;
                form.Show();
                this.Close();
            
        }

        private void frmOrderTypeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (GlobalList.closeApp) {
                Application.Exit();
                
            }
            GlobalList.closeApp = true;
        
        }
    }
}
