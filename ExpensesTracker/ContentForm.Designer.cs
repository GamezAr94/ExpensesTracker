namespace ExpensesTracker
{
    partial class ContentForm
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
            this.panelTopBorder = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSelectedItem = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBoxMenuLogo = new System.Windows.Forms.PictureBox();
            this.buttonReceipt = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopBorder
            // 
            this.panelTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.panelTopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBorder.Location = new System.Drawing.Point(65, 0);
            this.panelTopBorder.Name = "panelTopBorder";
            this.panelTopBorder.Size = new System.Drawing.Size(735, 5);
            this.panelTopBorder.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.pictureBoxMenuLogo);
            this.panelMenu.Controls.Add(this.panelSelectedItem);
            this.panelMenu.Controls.Add(this.buttonReceipt);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(65, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSelectedItem
            // 
            this.panelSelectedItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(155)))), ((int)(((byte)(209)))));
            this.panelSelectedItem.Location = new System.Drawing.Point(0, 94);
            this.panelSelectedItem.Name = "panelSelectedItem";
            this.panelSelectedItem.Size = new System.Drawing.Size(10, 52);
            this.panelSelectedItem.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(779, -4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 26);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxMenuLogo
            // 
            this.pictureBoxMenuLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.pictureBoxMenuLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMenuLogo.Image = global::ExpensesTracker.Properties.Resources.menuLogo;
            this.pictureBoxMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMenuLogo.Name = "pictureBoxMenuLogo";
            this.pictureBoxMenuLogo.Size = new System.Drawing.Size(185, 52);
            this.pictureBoxMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenuLogo.TabIndex = 9;
            this.pictureBoxMenuLogo.TabStop = false;
            this.pictureBoxMenuLogo.Click += new System.EventHandler(this.pictureBoxMenuLogo_Click);
            this.pictureBoxMenuLogo.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBoxMenuLogo.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // buttonReceipt
            // 
            this.buttonReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.buttonReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReceipt.FlatAppearance.BorderSize = 0;
            this.buttonReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReceipt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceipt.ForeColor = System.Drawing.Color.White;
            this.buttonReceipt.Image = global::ExpensesTracker.Properties.Resources.receiptIcon1;
            this.buttonReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReceipt.Location = new System.Drawing.Point(10, 94);
            this.buttonReceipt.Name = "buttonReceipt";
            this.buttonReceipt.Size = new System.Drawing.Size(175, 52);
            this.buttonReceipt.TabIndex = 0;
            this.buttonReceipt.Text = "Receipts";
            this.buttonReceipt.UseVisualStyleBackColor = false;
            // 
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelTopBorder);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContentForm";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTopBorder;
        private System.Windows.Forms.Button buttonReceipt;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelSelectedItem;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBoxMenuLogo;
    }
}