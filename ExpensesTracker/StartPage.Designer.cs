namespace ExpensesTracker
{
    partial class StartPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSalute = new System.Windows.Forms.Label();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.pictureBoxGearConfig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGearConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSalute
            // 
            this.labelSalute.AutoSize = true;
            this.labelSalute.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalute.Location = new System.Drawing.Point(31, 22);
            this.labelSalute.Name = "labelSalute";
            this.labelSalute.Size = new System.Drawing.Size(172, 26);
            this.labelSalute.TabIndex = 0;
            this.labelSalute.Text = "Welcolme back ";
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameUser.Location = new System.Drawing.Point(192, 22);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(77, 26);
            this.labelNameUser.TabIndex = 0;
            this.labelNameUser.Text = "Arturo";
            // 
            // pictureBoxGearConfig
            // 
            this.pictureBoxGearConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGearConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGearConfig.Image = global::ExpensesTracker.Properties.Resources.gearIcon;
            this.pictureBoxGearConfig.Location = new System.Drawing.Point(569, 399);
            this.pictureBoxGearConfig.Name = "pictureBoxGearConfig";
            this.pictureBoxGearConfig.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxGearConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGearConfig.TabIndex = 1;
            this.pictureBoxGearConfig.TabStop = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxGearConfig);
            this.Controls.Add(this.labelNameUser);
            this.Controls.Add(this.labelSalute);
            this.Name = "StartPage";
            this.Size = new System.Drawing.Size(620, 451);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGearConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSalute;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.PictureBox pictureBoxGearConfig;
    }
}
