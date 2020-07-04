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
        UserControl Active { get; set; }
        public ContentForm()
        {
            InitializeComponent();
        }
        //initializing the form with the landing page in front and the panelSelectItem whit visible equals to false
        private void ContentForm_Load(object sender, EventArgs e)
        {
            panelSelectedItem.Visible = false;
            startPageUserContent.Visible = true;
            Active = startPageUserContent;
            addBillUserControl.Visible = false;
            receiptsUserContent.Visible = false;
        }

        //the button will minimize the program
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //the button will close the aplication
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Logo behavior
        //the logo will change of color when the mouse is hovering it
        private void pictureBoxMenuLogo_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMenuLogo.BackColor = Color.FromArgb(230, 10, 40);
        }
        //the logo will return to its color when the mouse leaves it
        private void pictureBoxMenuLogo_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMenuLogo.BackColor = Color.FromArgb(210, 10, 40);
        }
        //the logo will change the size of the left panel when clicked
        private void pictureBoxMenuLogo_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelMenu.Width >= 185)
            {
                panelMenu.Width = 65;
            }
            else
            {
                panelMenu.Width = 185;
            }
        }
        #endregion Logo

        #region Menu Buttons behavior
        //the button will make visible the UserControl stored in the Active property and it will toggle the old object to visible false
        private void buttonAddReceipt_Click(object sender, EventArgs e)
        {
            if(panelSelectedItem.Visible == true && panelSelectedItem.Top == buttonAddReceipt.Top)
            {
                panelSelectedItem.Visible = false;
                Active.Visible = false;
                Active = startPageUserContent;
                Active.Visible = true;
            }
            else
            {
                Active.Visible = false;
                Active = receiptsUserContent;
                Active.Visible = true;
                panelSelectedItem.Top = buttonAddReceipt.Top;
                panelSelectedItem.Visible = true;
            }
        }
        //the button will make visible the UserControl stored in the Active property and it will toggle the old object to visible false
        private void buttonBills_Click(object sender, EventArgs e)
        {
            if (panelSelectedItem.Visible == true && panelSelectedItem.Top == buttonBills.Top)
            {
                panelSelectedItem.Visible = false;
                Active.Visible = false;
                Active = startPageUserContent;
                Active.Visible = true;
            }
            else
            {
                Active.Visible = false;
                Active = addBillUserControl;
                Active.Visible = true;
                startPageUserContent.Visible = false;
                panelSelectedItem.Top = buttonBills.Top;
                panelSelectedItem.Visible = true;
            }
        }
        //the button will make visible the UserControl stored in the Active property and it will toggle the old object to visible false
        private void buttonExpenses_Click(object sender, EventArgs e)
        {
            if (panelSelectedItem.Visible == true && panelSelectedItem.Top == buttonExpenses.Top)
            {
                panelSelectedItem.Visible = false;
                startPageUserContent.BringToFront();
            }
            else
            {
                panelSelectedItem.Top = buttonExpenses.Top;
                panelSelectedItem.Visible = true;
                //add its own user controler
            }
        }
        #endregion Menu buttons
    }
}
