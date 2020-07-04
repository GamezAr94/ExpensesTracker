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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenuLogo = new System.Windows.Forms.PictureBox();
            this.panelSelectedItem = new System.Windows.Forms.Panel();
            this.buttonExpenses = new System.Windows.Forms.Button();
            this.buttonBills = new System.Windows.Forms.Button();
            this.buttonAddReceipt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.addBillUserControl = new ExpensesTracker.AddBill();
            this.startPageUserContent = new ExpensesTracker.StartPage();
            this.receiptsUserContent = new ExpensesTracker.Receipts();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuLogo)).BeginInit();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopBorder
            // 
            this.panelTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.panelTopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBorder.Location = new System.Drawing.Point(65, 0);
            this.panelTopBorder.Name = "panelTopBorder";
            this.panelTopBorder.Size = new System.Drawing.Size(763, 10);
            this.panelTopBorder.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.pictureBoxMenuLogo);
            this.panelMenu.Controls.Add(this.panelSelectedItem);
            this.panelMenu.Controls.Add(this.buttonExpenses);
            this.panelMenu.Controls.Add(this.buttonBills);
            this.panelMenu.Controls.Add(this.buttonAddReceipt);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(65, 484);
            this.panelMenu.TabIndex = 0;
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
            this.pictureBoxMenuLogo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMenuLogo_MouseClick);
            this.pictureBoxMenuLogo.MouseEnter += new System.EventHandler(this.pictureBoxMenuLogo_MouseEnter);
            this.pictureBoxMenuLogo.MouseLeave += new System.EventHandler(this.pictureBoxMenuLogo_MouseLeave);
            // 
            // panelSelectedItem
            // 
            this.panelSelectedItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(190)))), ((int)(((byte)(235)))));
            this.panelSelectedItem.Location = new System.Drawing.Point(0, 94);
            this.panelSelectedItem.Name = "panelSelectedItem";
            this.panelSelectedItem.Size = new System.Drawing.Size(10, 52);
            this.panelSelectedItem.TabIndex = 2;
            // 
            // buttonExpenses
            // 
            this.buttonExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.buttonExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExpenses.FlatAppearance.BorderSize = 0;
            this.buttonExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpenses.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExpenses.ForeColor = System.Drawing.Color.White;
            this.buttonExpenses.Image = global::ExpensesTracker.Properties.Resources.receiptIcon1;
            this.buttonExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExpenses.Location = new System.Drawing.Point(10, 210);
            this.buttonExpenses.Name = "buttonExpenses";
            this.buttonExpenses.Size = new System.Drawing.Size(197, 52);
            this.buttonExpenses.TabIndex = 0;
            this.buttonExpenses.TabStop = false;
            this.buttonExpenses.Text = "Expenses";
            this.buttonExpenses.UseVisualStyleBackColor = false;
            this.buttonExpenses.Click += new System.EventHandler(this.buttonExpenses_Click);
            // 
            // buttonBills
            // 
            this.buttonBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.buttonBills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBills.FlatAppearance.BorderSize = 0;
            this.buttonBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBills.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBills.ForeColor = System.Drawing.Color.White;
            this.buttonBills.Image = global::ExpensesTracker.Properties.Resources.billIcon;
            this.buttonBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBills.Location = new System.Drawing.Point(10, 152);
            this.buttonBills.Name = "buttonBills";
            this.buttonBills.Size = new System.Drawing.Size(197, 52);
            this.buttonBills.TabIndex = 0;
            this.buttonBills.TabStop = false;
            this.buttonBills.Text = " Add Bill";
            this.buttonBills.UseVisualStyleBackColor = false;
            this.buttonBills.Click += new System.EventHandler(this.buttonBills_Click);
            // 
            // buttonAddReceipt
            // 
            this.buttonAddReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.buttonAddReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddReceipt.FlatAppearance.BorderSize = 0;
            this.buttonAddReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddReceipt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddReceipt.ForeColor = System.Drawing.Color.White;
            this.buttonAddReceipt.Image = global::ExpensesTracker.Properties.Resources.addRecordIcon;
            this.buttonAddReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddReceipt.Location = new System.Drawing.Point(10, 94);
            this.buttonAddReceipt.Name = "buttonAddReceipt";
            this.buttonAddReceipt.Size = new System.Drawing.Size(197, 52);
            this.buttonAddReceipt.TabIndex = 0;
            this.buttonAddReceipt.TabStop = false;
            this.buttonAddReceipt.Text = "Add Record";
            this.buttonAddReceipt.UseVisualStyleBackColor = false;
            this.buttonAddReceipt.Click += new System.EventHandler(this.buttonAddReceipt_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(146, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 481);
            this.panel1.TabIndex = 9;
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
            this.buttonClose.TabStop = false;
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
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.Text = "_";
            this.buttonMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.addBillUserControl);
            this.panelContent.Controls.Add(this.startPageUserContent);
            this.panelContent.Controls.Add(this.receiptsUserContent);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContent.Location = new System.Drawing.Point(65, 28);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(763, 456);
            this.panelContent.TabIndex = 9;
            // 
            // addBillUserControl
            // 
            this.addBillUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBillUserControl.Location = new System.Drawing.Point(0, 0);
            this.addBillUserControl.Name = "addBillUserControl";
            this.addBillUserControl.Size = new System.Drawing.Size(763, 456);
            this.addBillUserControl.TabIndex = 2;
            // 
            // startPageUserContent
            // 
            this.startPageUserContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPageUserContent.Location = new System.Drawing.Point(0, 0);
            this.startPageUserContent.Name = "startPageUserContent";
            this.startPageUserContent.Size = new System.Drawing.Size(763, 456);
            this.startPageUserContent.TabIndex = 1;
            // 
            // receiptsUserContent
            // 
            this.receiptsUserContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptsUserContent.Location = new System.Drawing.Point(0, 0);
            this.receiptsUserContent.Name = "receiptsUserContent";
            this.receiptsUserContent.Size = new System.Drawing.Size(763, 456);
            this.receiptsUserContent.TabIndex = 0;
            // 
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(828, 484);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.panelTopBorder);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContentForm";
            this.Load += new System.EventHandler(this.ContentForm_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuLogo)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTopBorder;
        private System.Windows.Forms.Button buttonAddReceipt;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelSelectedItem;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBoxMenuLogo;
        private System.Windows.Forms.Button buttonExpenses;
        private System.Windows.Forms.Button buttonBills;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContent;
        private Receipts receiptsUserContent;
        private StartPage startPageUserContent;
        private AddBill addBillUserControl;
    }
}