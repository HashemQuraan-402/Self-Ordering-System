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
    public partial class frmCartScreen : Form
    {
        public frmCartScreen()
        {
            InitializeComponent();
        }

        private void frmCartScreen_Load(object sender, EventArgs e)
        {
            fillTheCart();
        }
        private void fillTheCart() {

            flowLayoutPanel1.Controls.Clear();

            if (GlobalList.items.Count == 0)
            {
                Panel emptyPanel = new Panel();
                emptyPanel.Width = flowLayoutPanel1.Width - 5;
                emptyPanel.Height = flowLayoutPanel1.Height - 5;
                Label emptyLabel = new Label();
                emptyLabel.Text = "You didn't order yet";
                emptyLabel.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                emptyLabel.ForeColor = Color.Gray;
                emptyLabel.AutoSize = false;
                emptyLabel.Dock = DockStyle.Fill;
                emptyLabel.TextAlign = ContentAlignment.MiddleCenter;
                //emptyLabel.Location = new Point((emptyPanel.Width - emptyLabel.PreferredWidth) / 2, (emptyPanel.Height - emptyLabel.PreferredHeight) / 2);
                emptyPanel.Controls.Add(emptyLabel);
                flowLayoutPanel1.Controls.Add(emptyPanel);
            }
            else
            {
                
                foreach (Item item in GlobalList.items)
                {
                    //Panel for groping the item elements
                    Panel itemPanel = new Panel();
                    itemPanel.Width = flowLayoutPanel1.Width - 10;
                    itemPanel.Height = 100;
                    itemPanel.BorderStyle = BorderStyle.FixedSingle;
                    flowLayoutPanel1.Controls.Add(itemPanel);
                    // picture of the item
                    PictureBox itemPicture = new PictureBox();
                    itemPicture.Width = itemPanel.Width / 4;
                    itemPicture.Height = itemPanel.Height - 2;
                    itemPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    itemPicture.Image = item.ItemImage;
                    itemPanel.Controls.Add(itemPicture);
                    //label for item name
                    Label lblName = new Label();
                    lblName.Font = new Font("Segoe UI",9);
                    lblName.Location = new Point(itemPicture.Location.X + itemPicture.Width + 20,5);
                    lblName.Text = item.Name;
                    lblName.AutoSize = true;
                    itemPanel.Controls.Add(lblName);
                    //label for item price
                    Label lblPrice = new Label();
                    lblPrice.Font = new Font("Segoe UI", 9);
                    lblPrice.Text = item.Price.ToString() + " JOD";
                    lblPrice.Location = new Point(lblName.Location.X, lblName.Location.Y + lblName.Height + 20);
                    lblPrice.AutoSize = true;
                    itemPanel.Controls.Add(lblPrice);
                    //NumaricUpDown for item quantity
                    //Label lblQuantity = new Label();
                    //lblQuantity.Text = item.Quantity.ToString();
                    //lblQuantity.Location = new Point(lblName.Location.X, lblName.Location.Y + lblPrice.Height + 20);
                    //lblQuantity.AutoSize = true;
                    //itemPanel.Controls.Add(lblQuantity);
                    NumericUpDown nudQuantity = new NumericUpDown();
                    nudQuantity.Minimum = 1;
                    nudQuantity.Maximum = 20;
                    nudQuantity.Value = item.Quantity;
                    nudQuantity.ReadOnly = true;
                    nudQuantity.Location = new Point(lblName.Location.X, lblPrice.Location.Y + lblPrice.Height + 20);
                    nudQuantity.Width = 40;
                    nudQuantity.Height = 20;
                    itemPanel.Controls.Add(nudQuantity);


                    // Button for remove an item
                    Button btnRemoveItem = new Button();
                    btnRemoveItem.Width = 60;
                    btnRemoveItem.Height = 30;
                    btnRemoveItem.Cursor = Cursors.Hand;
                    btnRemoveItem.Font = new Font("Segoe UI", 9);
                    btnRemoveItem.Location = new Point( itemPanel.Width - 10 - btnRemoveItem.Width, ((itemPanel.Height - btnRemoveItem.Height))/2);
                    btnRemoveItem.Text = "Remove";
                    btnRemoveItem.BackColor = Color.IndianRed;
                    btnRemoveItem.ForeColor = Color.White;
                    btnRemoveItem.Tag = item;
                    btnRemoveItem.Click += (s, e) =>
                    {
                        if (item.Quantity > 1)
                        {
                            item.Quantity--;
                            fillTheCart();
                        }
                        else
                        {
                            GlobalList.items.Remove(item);
                            fillTheCart();
                        }
                    };
                    itemPanel.Controls.Add(btnRemoveItem);
                    
                }
                double Total = 0;
                foreach (Item item in GlobalList.items) { 
                    Total += item.Price*item.Quantity;
                }
                //panel for total
                Panel totalPanel = new Panel();
                totalPanel.Width = flowLayoutPanel1.Width - 10;
                totalPanel.Height = 100;
                totalPanel.BorderStyle = BorderStyle.FixedSingle;
                flowLayoutPanel1.Controls.Add(totalPanel);
                //label for total
                Label lblTotal = new Label();
                lblTotal.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                lblTotal.AutoSize = true;
                lblTotal.Location = new Point(5,(totalPanel.Height-lblTotal.Height)/2);
                lblTotal.Text = "Total Price : " + Total + " JOD";
                totalPanel.Controls.Add(lblTotal);
                //label for order state
                Label lblstait = new Label();
                lblstait.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                lblstait.AutoSize = true;
                lblstait.Location = new Point(lblTotal.Width + 15, (totalPanel.Height - lblTotal.Height) / 2);
                lblstait.Text = "( " + GlobalList.orderState + " )";
                totalPanel.Controls.Add(lblstait);
                //button for pay
                Button btnPayment = new Button();
                btnPayment.Cursor = Cursors.Hand;
                btnPayment.Width = 60;
                btnPayment.Height = 30;
                btnPayment.BackColor = Color.LightGreen;
                btnPayment.ForeColor = Color.White;
                btnPayment.Font = new Font("Segoe UI",9);
                btnPayment.Location = new Point(totalPanel.Width - btnPayment.Width - 10,(totalPanel.Height- btnPayment.Height)/2);
                btnPayment.Text = "Pay";
                btnPayment.Click += (s, e) =>
                {
                    receiptFormMake();
                };
                totalPanel.Controls.Add(btnPayment);
            }
        }
        private void receiptFormMake() {
            //form for receipt
            Form frmReceipt = new Form();
            frmReceipt.Text = "Receipt";
            frmReceipt.Size = new Size(505, 765);
            
            frmReceipt.FormClosed += (s,e) => {
                //////////////////////////////////////////
                GlobalList.items.Clear();
                frmHomeScreen.CartForm.Show();
            };
            // flow layout panel for controls
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Width = frmReceipt.Width;
            flowLayoutPanel.Height = frmReceipt.Height;
            flowLayoutPanel.AutoScroll = true;
            frmReceipt.Controls.Add(flowLayoutPanel);

            //Label for Header
            Label lblReceipt = new Label();
            lblReceipt.Text = "Order Receipt";
            lblReceipt.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblReceipt.Width = flowLayoutPanel.Width - 20;
            lblReceipt.Height = 80;
            lblReceipt.AutoSize = false;
            lblReceipt.TextAlign = ContentAlignment.MiddleCenter;
            //lblReceipt.Location = new Point((flowLayoutPanel.Width - flowLayoutPanel.Width) / 2, 10);
            flowLayoutPanel.Controls.Add(lblReceipt);
            //label for order state
            Label lblstait = new Label();
            lblstait.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblstait.AutoSize = false;
            lblstait.Width = flowLayoutPanel.Width - 20;
            lblstait.Height = 30;
            lblstait.Margin = new Padding(0,0,0,20);
            lblstait.TextAlign = ContentAlignment.MiddleCenter;
            
            lblstait.Text = "( " + GlobalList.orderState + " )";
            flowLayoutPanel.Controls.Add(lblstait);
            //label for item
            double total = 0;
            foreach (Item item in GlobalList.items)
            {
                total += item.Price*item.Quantity;
                Label lblItemReceipt = new Label();
                lblItemReceipt.Width = flowLayoutPanel.Width - 20;
                lblItemReceipt.Height = 80;
                
                lblItemReceipt.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblItemReceipt.AutoSize = false;
                
                lblItemReceipt.Text = $"Item : {item.Name}\nQuantity : {item.Quantity}\nPrice : {item.Price}";
                //lblItemReceipt.TextAlign = ContentAlignment.MiddleLeft;
                lblItemReceipt.Margin = new Padding(20,0,0,0);
                flowLayoutPanel.Controls.Add(lblItemReceipt);
            }
            //label for Total
            Label lblTotal = new Label();
            lblTotal.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTotal.AutoSize = false;
            lblTotal.Width = flowLayoutPanel.Width - 20;
            lblTotal.Height = 30;
            lblTotal.Margin = new Padding(20, 0, 0, 0);

            lblTotal.Text = $"Total Price : {total} JOD";
            flowLayoutPanel.Controls.Add(lblTotal);
            //button for close
            Button btnCloseReceipt = new Button();
            btnCloseReceipt.Text = "Close";
            btnCloseReceipt.Font = new Font("Segoe UI", 9);
            btnCloseReceipt.BackColor = Color.White;
            btnCloseReceipt.Width = 160;
            btnCloseReceipt.Height = 60;
            btnCloseReceipt.Cursor = Cursors.Hand;
            btnCloseReceipt.Margin = new Padding((flowLayoutPanel.Width - btnCloseReceipt.Width) / 2,20,0,0);
            flowLayoutPanel.Controls.Add(btnCloseReceipt);
            btnCloseReceipt.Click += (s, e) => {
                
                
                frmReceipt.Close();
            };
            GlobalList.closeApp = false;
            frmReceipt.Show();
            this.Close();

        }
        private void btnCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the Cart Page", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            frmHomeScreen.PopularForm.Show();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            GlobalList.closeApp= false;
            frmHomeScreen.SettingsForm.Show();
            this.Close();
        }

        private void frmCartScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (GlobalList.closeApp)
            {
                frmOrderTypeScreen.HomeForm.Show();
            }
            GlobalList.closeApp = true;
        }
    }
}
