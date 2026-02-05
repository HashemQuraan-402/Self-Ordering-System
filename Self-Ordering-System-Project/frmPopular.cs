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
    public partial class frmPopular : Form
    {
        //private static frmSettings settingsFormFromPopular;
        //public static frmSettings SettingsFormFromPopular
        //{
        //    get {
        //        if (settingsFormFromPopular == null || settingsFormFromPopular.IsDisposed) { 
        //            settingsFormFromPopular = new frmSettings();
        //        }
        //        return settingsFormFromPopular;
        //    }
        //}


        public frmPopular()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            GlobalList.closeApp = false;
            Form cart = frmHomeScreen.CartForm;
            cart.Show();
            this.Close();
        }

        private void btnPopular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the Popular Page","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            GlobalList.closeApp = false;
            frmOrderTypeScreen.HomeForm.Show();
            this.Close();

        }

        private void frmPopular_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (GlobalList.closeApp)
            {
                frmOrderTypeScreen.HomeForm.Show();  
            }
            GlobalList.closeApp = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            GlobalList.closeApp = false;
            Form settings = frmHomeScreen.SettingsForm;
            settings.Show();
            this.Close();
        }
        private string selectName(double p) {
            string n ="";
            switch (p) {
                case 25: n = "Veggie Black Bean Burger";break;
                case 30: n = "Golden Roasted Chicken"; break;
                case 10: n = "Veggie & Cheese Omelette"; break;
                case 4: n = "Thick Cut Steak Fries"; break;
                case 2: n = "Traditional Turkish Coffee"; break;
                case 3: n = "PB&J Fun Shapes"; break;
                case 6: n = "New York Style CheeseCake"; break;
                case 5: n = "Classic Italian Tiramisu"; break;
            }
            return n;
        }
        private void btns_click(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            double price;
            double.TryParse(button.Tag.ToString(), out price);
            string name = selectName(price);
            


            if (MessageBox.Show($"Do You Want to buy : {name}\n The Price : {price}", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                for (int i = 0; i < GlobalList.items.Count; i++ ) {
                    if (name == GlobalList.items[i].Name) {
                        GlobalList.items[i].Quantity++;
                        return;
                    }
                }


                Item item = new Item();
                item.Price = price;
                item.Name = name;
                item.ItemImage = button.BackgroundImage;
                item.Quantity = 1;
                GlobalList.items.Add(item);
            }
        }

    }
    
    
}
