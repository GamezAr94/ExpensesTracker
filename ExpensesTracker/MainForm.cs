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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonLogin.FlatStyle = FlatStyle.Flat;
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '\u25CF';
            textBoxPassword.Text = string.Empty;
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == string.Empty)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.Text = "Password";
            }
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == string.Empty)
            {
                textBoxUserName.Text = "User name";
            }

        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            textBoxUserName.SelectAll();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUserName_Click(object sender, EventArgs e)
        {
            textBoxUserName.SelectAll();
        }
    }
}
