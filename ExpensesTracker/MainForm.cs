using ExpensesTracker.Business;
using ExpensesTracker.Common.Members;
using ExpensesTracker.Data;
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
            Application.Exit();
        }

        private void textBoxUserName_Click(object sender, EventArgs e)
        {
            textBoxUserName.SelectAll();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Member activeMember = MemberValidation.LoginMember(textBoxUserName.Text, textBoxPassword.Text);
            if(activeMember != null)
            {
                MemberViewModel.ActiveMember = activeMember;
                ContentForm contentForm = new ContentForm() { MainForm = this };
                this.Hide();
                contentForm.Show();

                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.Text = "Password";

                textBoxUserName.Text = "User name";
            }
            else
            {
                if (MemberValidation.ErrorMessage == "")
                {
                    MessageBox.Show("User Name or Password incorrect", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(MemberValidation.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
