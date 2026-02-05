namespace Self_Ordering_System_Project
{
    partial class frmOrderTypeScreen
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
            this.btnTakeOut = new System.Windows.Forms.Button();
            this.btnTakeIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTakeOut
            // 
            this.btnTakeOut.BackgroundImage = global::Self_Ordering_System_Project.Properties.Resources.images;
            this.btnTakeOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTakeOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeOut.Location = new System.Drawing.Point(0, 337);
            this.btnTakeOut.Name = "btnTakeOut";
            this.btnTakeOut.Size = new System.Drawing.Size(490, 319);
            this.btnTakeOut.TabIndex = 1;
            this.btnTakeOut.Tag = "Take Out";
            this.btnTakeOut.Text = "Take Out";
            this.btnTakeOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTakeOut.UseVisualStyleBackColor = true;
            this.btnTakeOut.Click += new System.EventHandler(this.click);
            // 
            // btnTakeIn
            // 
            this.btnTakeIn.BackgroundImage = global::Self_Ordering_System_Project.Properties.Resources.TakeIn;
            this.btnTakeIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTakeIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeIn.Location = new System.Drawing.Point(0, 0);
            this.btnTakeIn.Name = "btnTakeIn";
            this.btnTakeIn.Size = new System.Drawing.Size(490, 331);
            this.btnTakeIn.TabIndex = 0;
            this.btnTakeIn.Tag = "Take In";
            this.btnTakeIn.Text = "Take In";
            this.btnTakeIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTakeIn.UseVisualStyleBackColor = true;
            this.btnTakeIn.Click += new System.EventHandler(this.click);
            // 
            // frmOrderTypeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 657);
            this.Controls.Add(this.btnTakeOut);
            this.Controls.Add(this.btnTakeIn);
            this.Name = "frmOrderTypeScreen";
            this.Text = "OrderTypeScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOrderTypeScreen_FormClosed);
            this.Load += new System.EventHandler(this.frmOrderTypeScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTakeIn;
        
        private System.Windows.Forms.Button btnTakeOut;
    }
}