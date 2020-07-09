using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpensesTracker.Data;

namespace ExpensesTracker
{
    public partial class Receipts : UserControl
    {
        private PurchasesViewModel purchasesVM;
        public Receipts()
        {
            InitializeComponent();
        }

        private void Receipts_Load(object sender, EventArgs e)
        {
            purchasesVM = new PurchasesViewModel();
            FormatDayPickers();
            setBindings();
            setupDataGridView();
        }
        private void setBindings()
        {
            dataGridViewReceiptsInfo.AutoGenerateColumns = false;
            //dataGridViewReceiptsInfo.DataSource = purchasesVM.Purchases;
            dataGridViewReceiptsInfo.DataSource = PurchaseRepository.GetExpenses();
        }
        private void setupDataGridView()
        {
            dataGridViewReceiptsInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReceiptsInfo.MultiSelect = false;
            dataGridViewReceiptsInfo.AllowUserToAddRows = false;
            dataGridViewReceiptsInfo.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewReceiptsInfo.AllowUserToOrderColumns = false;
            dataGridViewReceiptsInfo.AllowUserToResizeRows = false;
            dataGridViewReceiptsInfo.AllowUserToResizeColumns = false;
            dataGridViewReceiptsInfo.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            
            DataGridViewTextBoxColumn date = new DataGridViewTextBoxColumn();
            date.Name = "date";
            date.DataPropertyName = "Date";
            date.HeaderText = "Date";
            date.Width = 110;
            date.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            date.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            date.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewReceiptsInfo.Columns.Add(date);

            DataGridViewTextBoxColumn amount = new DataGridViewTextBoxColumn();
            amount.Name = "amount";
            amount.DataPropertyName = "Amount";
            amount.HeaderText = "Amount";
            amount.Width = 110;
            amount.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            amount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            amount.DefaultCellStyle.Format = "N2";
            amount.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewReceiptsInfo.Columns.Add(amount);

            DataGridViewTextBoxColumn category = new DataGridViewTextBoxColumn();
            category.Name = "category";
            category.DataPropertyName = "Category";
            category.HeaderText = "Category";
            category.Width = 110;
            category.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            category.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            category.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewReceiptsInfo.Columns.Add(category);

            DataGridViewTextBoxColumn info = new DataGridViewTextBoxColumn();
            info.Name = "information";
            info.DataPropertyName = "Information";
            info.HeaderText = "Information";
            info.Width = 110;
            info.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            info.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            info.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewReceiptsInfo.Columns.Add(info);

            DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn();
            notes.Name = "notes";
            notes.DataPropertyName = "Notes";
            notes.HeaderText = "Notes";
            notes.Width = 110;
            notes.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            notes.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewReceiptsInfo.Columns.Add(notes);
        }

        private void FormatDayPickers()
        {
            dateTimePickerDay.Format = DateTimePickerFormat.Custom;
            dateTimePickerDay.CustomFormat = "dd";


            dateTimePickerMonth.Format = DateTimePickerFormat.Custom;
            dateTimePickerMonth.CustomFormat = "MM";


            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
        }
    }
}
