﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTracker
{
    public partial class ContentForm : Form
    {
        public ContentForm()
        {
            InitializeComponent();
        }
        private void pictureBoxMenuLogo_Click(object sender, EventArgs e)
        {
            if(panelMenu.Width >= 185)
            {
                panelMenu.Width = 65;
            }
            else
            {
                panelMenu.Width = 185;
            }
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBoxMenuLogo_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMenuLogo.BackColor = Color.FromArgb(230, 10, 40);
        }
        private void pictureBoxMenuLogo_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMenuLogo.BackColor = Color.FromArgb(210, 10, 40);
        }
    }
}