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
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenuLogo = new System.Windows.Forms.PictureBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonBills = new System.Windows.Forms.Button();
            this.buttonReceipt = new System.Windows.Forms.Button();
            this.labelWelcomeUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopBorder
            // 
            this.panelTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.panelTopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBorder.Location = new System.Drawing.Point(65, 0);
            this.panelTopBorder.Name = "panelTopBorder";
            this.panelTopBorder.Size = new System.Drawing.Size(763, 5);
            this.panelTopBorder.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.pictureBoxMenuLogo);
            this.panelMenu.Controls.Add(this.panelSelectedItem);
            this.panelMenu.Controls.Add(this.buttonInfo);
            this.panelMenu.Controls.Add(this.buttonBills);
            this.panelMenu.Controls.Add(this.buttonReceipt);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(65, 484);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSelectedItem
            // 
            this.panelSelectedItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.panelSelectedItem.Location = new System.Drawing.Point(0, 94);
            this.panelSelectedItem.Name = "panelSelectedItem";
            this.panelSelectedItem.Size = new System.Drawing.Size(10, 52);
            this.panelSelectedItem.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(806, -4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 26);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(782, -8);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(24, 30);
            this.buttonMinimize.TabIndex = 8;
            this.buttonMinimize.Text = "_";
            this.buttonMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ExpensesTracker.Properties.Resources.logoutIcon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 449);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
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
            this.pictureBoxMenuLogo.MouseEnter += new System.EventHandler(this.pictureBoxMenuLogo_MouseEnter);
            this.pictureBoxMenuLogo.MouseLeave += new System.EventHandler(this.pictureBoxMenuLogo_MouseLeave);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Image = global::ExpensesTracker.Properties.Resources.receiptIcon1;
            this.buttonInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfo.Location = new System.Drawing.Point(10, 210);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(197, 52);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.Text = "Information";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonBills
            // 
            this.buttonBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.buttonBills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBills.FlatAppearance.BorderSize = 0;
            this.buttonBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBills.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBills.ForeColor = System.Drawing.Color.White;
            this.buttonBills.Image = global::ExpensesTracker.Properties.Resources.receiptIcon1;
            this.buttonBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBills.Location = new System.Drawing.Point(10, 152);
            this.buttonBills.Name = "buttonBills";
            this.buttonBills.Size = new System.Drawing.Size(197, 52);
            this.buttonBills.TabIndex = 0;
            this.buttonBills.Text = "Bills";
            this.buttonBills.UseVisualStyleBackColor = false;
            this.buttonBills.Click += new System.EventHandler(this.buttonBills_Click);
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
            this.buttonReceipt.Size = new System.Drawing.Size(197, 52);
            this.buttonReceipt.TabIndex = 0;
            this.buttonReceipt.Text = "Receipts";
            this.buttonReceipt.UseVisualStyleBackColor = false;
            this.buttonReceipt.Click += new System.EventHandler(this.buttonReceipt_Click);
            // 
            // labelWelcomeUser
            // 
            this.labelWelcomeUser.AutoSize = true;
            this.labelWelcomeUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeUser.Location = new System.Drawing.Point(71, 18);
            this.labelWelcomeUser.Name = "labelWelcomeUser";
            this.labelWelcomeUser.Size = new System.Drawing.Size(215, 24);
            this.labelWelcomeUser.TabIndex = 9;
            this.labelWelcomeUser.Text = "Welcome Back Arturo!";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(65, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 106);
            this.panel1.TabIndex = 10;
            // 
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(828, 484);
            this.Controls.Add(this.labelWelcomeUser);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelTopBorder);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContentForm";
            this.Load += new System.EventHandler(this.ContentForm_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTopBorder;
        private System.Windows.Forms.Button buttonReceipt;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelSelectedItem;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBoxMenuLogo;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonBills;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelWelcomeUser;
        private System.Windows.Forms.Panel panel1;
    }
}