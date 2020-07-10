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
    public partial class EditReciptDialog : Form
    {
        public PurchasesViewModel PurchaseVM { get; set; }
        public EditReciptDialog()
        {
            InitializeComponent();
        }

        private void EditReciptDialog_Load(object sender, EventArgs e)
        {
            FormatDayPickers();
            setBindings();
        }

        private void setBindings()
        {
            dateTimePickerDay.DataBindings.Add("Value", PurchaseVM, "Purchase.Date", true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePickerMonth.DataBindings.Add("Value", PurchaseVM, "Purchase.Date", true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePickerYear.DataBindings.Add("Value", PurchaseVM, "Purchase.Date", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxCategory.DataBindings.Add("Text", PurchaseVM, "Purchase.Category");
            textBoxAmount.DataBindings.Add("Text", PurchaseVM, "Purchase.Amount");
            textBoxInformation.DataBindings.Add("Text", PurchaseVM, "Purchase.Information");
            textBoxNotes.DataBindings.Add("Text", PurchaseVM, "Purchase.Notes");
        }

        //it will give proper format to the daypickers day, month and year
        private void FormatDayPickers()
        {
            dateTimePickerDay.Format = DateTimePickerFormat.Custom;
            dateTimePickerDay.CustomFormat = "dd";


            dateTimePickerMonth.Format = DateTimePickerFormat.Custom;
            dateTimePickerMonth.CustomFormat = "MMM";


            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
