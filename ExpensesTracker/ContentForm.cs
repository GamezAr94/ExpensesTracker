using System;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMenuLogo.BackColor = Color.FromArgb(230, 10, 40);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMenuLogo.BackColor = Color.FromArgb(210, 10, 40);
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
    }
}
