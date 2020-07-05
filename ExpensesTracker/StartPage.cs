using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTracker
{
    public partial class StartPage : UserControl
    {
        public Label LabelNameUser { get; set; }
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            LabelNameUser = labelNameUser;
        }
    }
}
