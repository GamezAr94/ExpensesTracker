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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
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
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.buttonReceipt);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(65, 450);
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
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ExpensesTracker.Properties.Resources.receiptIcon1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Receipts";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::ExpensesTracker.Properties.Resources.receiptIcon1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(10, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 52);
            this.button2.TabIndex = 0;
            this.button2.Text = "Receipts";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::ExpensesTracker.Properties.Resources.receiptIcon1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(10, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 52);
            this.button3.TabIndex = 0;
            this.button3.Text = "Receipts";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::ExpensesTracker.Properties.Resources.receiptIcon1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(10, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 52);
            this.button4.TabIndex = 0;
            this.button4.Text = "Receipts";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(755, -8);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(24, 30);
            this.buttonMinimize.TabIndex = 8;
            this.buttonMinimize.Text = "_";
            this.buttonMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // ContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMinimize);
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMinimize;
    }
}