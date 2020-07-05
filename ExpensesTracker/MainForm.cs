using ExpensesTracker.Members;
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
        MembersList memberList;
        public Member ActiveMember { get; set; }
        ContentForm contentForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            memberList = DatabaseConnection.InitializingMembers();
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
            int index = memberList.FindIndex(x => x.Profile.Contains(textBoxUserName.Text));
            string message = "Wrong password and/or user name\n Please try again.";
            if(index >= 0)
            {
                if ((ActiveMember = memberList[index]).Password == textBoxPassword.Text)
                {
                    contentForm = new ContentForm();
                    contentForm.MainForm = this;
                    this.Hide();
                    contentForm.Show();

                    textBoxPassword.PasswordChar = '\0';
                    textBoxPassword.Text = "Password";

                    textBoxUserName.Text = "User name";
                }
                else
                {
                    MessageBox.Show(message, "Error dectected in input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxPassword.PasswordChar = '\0';
                    textBoxPassword.Text = "Password";

                    textBoxUserName.Text = "User name";
                }
            }
            else
            {
                MessageBox.Show(message, "Error dectected in input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxPassword.PasswordChar = '\0';
                textBoxPassword.Text = "Password";

                textBoxUserName.Text = "User name";
            }
        }
    }
}
