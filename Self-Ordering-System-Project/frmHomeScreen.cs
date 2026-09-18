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
    public partial class frmHomeScreen : Form
    {

        private static Form popularForm;
        public static Form PopularForm {
            get {
                if (popularForm == null || popularForm.IsDisposed) { 
                    popularForm = new frmPopular();
                }
                return popularForm;
            } 
        }

        private static Form settingsForm;
        public static Form SettingsForm
        {
            get
            {
                if (settingsForm == null || settingsForm.IsDisposed)
                {
                    settingsForm = new frmSettings();
                }
                return settingsForm;
            }
        }

        private static frmCartScreen cartForm;

        public static frmCartScreen CartForm
        {
            get
            {
                if(cartForm == null || cartForm.IsDisposed){
                    cartForm = new frmCartScreen();
                }
                return cartForm;
            }
        }

        public frmHomeScreen()
        {
            InitializeComponent();
            
        }
        

        

        private void frmHomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (GlobalList.closeApp)
            {
                Application.Exit();
            }
            GlobalList.closeApp = true;
            
        }

        private void frmHomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void topPanel_click(object sender, EventArgs e) { 
            bool flag = false;
            Button button = (Button)sender;
            ImageList imageList = null;
            if (button.Name == "btnBurgers") {
                imageList = imageList1;
                flag = true;
            } else if (button.Name == "btnChickens") {
                imageList = imageList2;
                flag = true;
            }
            else if (button.Name == "btnBreakFast")
            {
                imageList = imageList3;
                    flag = true;
            }
            else if (button.Name == "btnFrieses")
            {
                imageList = imageList4;
                    flag = true;
            }
            else if (button.Name == "btnDrinks")
            {
                imageList = imageList5;
                flag = true;
            }
            else if (button.Name == "btnDesserts")
            {
                imageList = imageList6;
                flag = true;
            }
            else if (button.Name == "btnKids")
            {
                imageList = imageList7;
                    flag = true;
            }
            else if (button.Name == "btnPromotions")
            {
                imageList = null;
                flag = false;
                flowLayoutPanel2.BackgroundImage = Properties.Resources.DiscountPromotion;
                flowLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (flag) { 
                flowLayoutPanel1.BackgroundImage = null;
            }
            btnB1.ImageList = imageList;
            btnB1.ImageIndex = 0;
            btnB1.Visible = flag;
            btnB2.ImageList = imageList;
            btnB2.ImageIndex = 1;
            btnB2.Visible = flag;
            btnB3.ImageList = imageList;
            btnB3.ImageIndex = 2;
            btnB3.Visible = flag;
            btnB4.ImageList = imageList;
            btnB4.ImageIndex = 3;
            btnB4.Visible = flag;
            btnB5.ImageList = imageList;
            btnB5.ImageIndex = 4;
            btnB5.Visible = flag;
            btnB6.ImageList = imageList;
            btnB6.ImageIndex = 5;
            btnB6.Visible = flag;
            

        }

        private void btnBurgers_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPopular_Click(object sender, EventArgs e)
        {
            Form popular = PopularForm;
            popular.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the Home Page", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form settings = SettingsForm;
            settings.Show();
            this.Hide();
        }

        private double calc_price(int imgList,int imgIndex,ref string name) {
            double price = 0;
            switch (imgList)
            {
                case 1:
                    switch (imgIndex)
                    {
                        case 0: name = "Clasic Cheese Burger"; price = 5;break;
                        case 1: name = "Bacon Cheese Burger"; price = 7; break;
                        case 2: name = "Mashroom Swiss Burger"; price = 10; break;
                        case 3: name = "BBQ Oniun Ring Burger"; price = 15; break;
                        case 4: name = "Spicy Jalapeno Burger"; price = 20; break;
                        case 5: name = "Veggie Black Bean Burger"; price = 25; break;

                    }
                    break;
                case 2:
                    switch (imgIndex)
                    {
                        case 0: name = "Golden Roasted Chicken"; price = 30; break;
                        case 1: name = "Ceamy Chicken Curry"; price = 25; break;
                        case 2: name = "Grilled Chicken Salad"; price = 15; break;
                        case 3: name = "Home Style Chicken Soup"; price = 15; break;
                        case 4: name = "Spicy Chicken Wings"; price = 10; break;
                        case 5: name = "Street Style Chicken Tacos"; price = 8; break;

                    }
                    break;
                case 3:
                    switch (imgIndex)
                    {
                        case 0: name = "Fluffy Buttermilk Pancakes"; price = 9; break;
                        case 1: name = "Classic Eggs Benedict"; price = 6; break;
                        case 2: name = "Avocado & Egg Toast"; price = 8; break;
                        case 3: name = "Hearty Fruit & Nut Oatmeal"; price = 12; break;
                        case 4: name = "Veggie & Cheese Omelette"; price = 10; break;
                        case 5: name = "Classic French Toast"; price = 5; break;

                    }
                    break;
                case 4:
                    switch (imgIndex)
                    {
                        case 0: name = "Clasic French Fries"; price = 2; break;
                        case 1: name = "Seasoned Curly Fries"; price = 7; break;
                        case 2: name = "Sweet Potato Fries"; price = 3; break;
                        case 3: name = "Crispy waffle Fries"; price = 5; break;
                        case 4: name = "Thick Cut Steak Fries"; price = 4; break;
                        case 5: name = "Fully Loaded Fries"; price = 6; break;

                    }
                    break;
                case 5:
                    switch (imgIndex)
                    {
                        case 0: name = "Refreshing Mint Lemonade"; price = 3; break;
                        case 1: name = "Traditional Turkish Coffee"; price = 2; break;
                        case 2: name = "Chilled Hibiscus Tea"; price = 4; break;
                        case 3: name = "Classic Vimto Cordial (dont Buy it)"; price = 999; break;
                        case 4: name = "Frothy Salted Ayran"; price = 5; break;
                        case 5: name = "Fresh Pomegranate Juice"; price = 10; break;

                    }
                    break;
                case 6:
                    switch (imgIndex)
                    {
                        case 0: name = "Molten Chocolate Lava Cake"; price = 5; break;
                        case 1: name = "Classic Italian Tiramisu"; price = 5; break;
                        case 2: name = "New York Style CheeseCake"; price = 6; break;
                        case 3: name = "Assorted Paisian Macarons"; price = 1; break;
                        case 4: name = "Warm HomeMade Apple Pie"; price = 8; break;
                        case 5: name = "Classic Vanilla Creme Bruee"; price = 4; break;

                    }
                    break;
                case 7:
                    switch (imgIndex)
                    {
                        case 0: name = "Chicken Nuggets & Smiles"; price = 5; break;
                        case 1: name = "Mini Burger Sliders & Apples"; price = 6; break;
                        case 2: name = "Creany Mac & Cheese Cup"; price = 2; break;
                        case 3: name = "Grilled CHeese & Tomato Soup"; price = 8; break;
                        case 4: name = "PB&J Fun Shapes"; price = 3; break;
                        case 5: name = "Mini spaghetti & MeatBalls"; price = 10; break;

                    }
                    break;
            }
            return price;
        }

        private void btns_click(object sender, EventArgs e) {

            Button button = (Button)sender;

            int imagelistNumber;
            int.TryParse(button.ImageList.Tag.ToString(), out imagelistNumber);
            string name = "";
            double p = calc_price(imagelistNumber, button.ImageIndex, ref name);


            if (MessageBox.Show($"Do You Want to buy : {name}\n The Price : {p}","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK) {

                for (int i = 0; i < GlobalList.items.Count; i++)
                {
                    if (name == GlobalList.items[i].Name)
                    {
                        GlobalList.items[i].Quantity++;
                        return;
                    }
                }

                Item item = new Item();
                item.Price = p;
                item.Name = name;
                item.ItemImage = button.Image;
                item.Quantity = 1;
                GlobalList.items.Add(item);
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            Form cart = CartForm;
            cart.Show();
            this.Hide();
        }
    }
}
