namespace Self_Ordering_System_Project
{
    partial class frmCartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPopular = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::Self_Ordering_System_Project.Properties.Resources.Settings1;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(368, 645);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(109, 69);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPopular
            // 
            this.btnPopular.BackgroundImage = global::Self_Ordering_System_Project.Properties.Resources.Star;
            this.btnPopular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPopular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopular.Location = new System.Drawing.Point(249, 645);
            this.btnPopular.Name = "btnPopular";
            this.btnPopular.Size = new System.Drawing.Size(109, 69);
            this.btnPopular.TabIndex = 14;
            this.btnPopular.Text = "Popular";
            this.btnPopular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPopular.UseVisualStyleBackColor = true;
            this.btnPopular.Click += new System.EventHandler(this.btnPopular_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackgroundImage = global::Self_Ordering_System_Project.Properties.Resources.cart;
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Location = new System.Drawing.Point(130, 645);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(109, 69);
            this.btnCart.TabIndex = 13;
            this.btnCart.Text = "Cart";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::Self_Ordering_System_Project.Properties.Resources.Home2;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(11, 645);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(109, 69);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(488, 629);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // frmCartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 726);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnPopular);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnHome);
            this.Name = "frmCartScreen";
            this.Text = "Cart Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCartScreen_FormClosed);
            this.Load += new System.EventHandler(this.frmCartScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnPopular;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}