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
using ExpensesTracker.Common.Expenses;
using ExpensesTracker.Business;
using MySql.Data.MySqlClient;

namespace ExpensesTracker
{
    public partial class Receipts : UserControl
    {
        private PurchasesViewModel purchasesVM;
        public Receipts()
        {
            InitializeComponent();
        }


        //default constructor will initialize a purchaseViewModel object and sets the Date property to todays date
        //it will call the format for the datePickers, set the bindings and set the data grid view
        private void Receipts_Load(object sender, EventArgs e)
        {
            purchasesVM = new PurchasesViewModel();
            purchasesVM.Purchase.Date = DateTime.Today;
            FormatDayPickers();
            setBindings();
            setupDataGridView();
            labelMessage.Text = string.Empty;
        }


        //it will create the bindings to all the form data
        private void setBindings()
        {
            textBoxAmount.DataBindings.Add("Text", purchasesVM, "Purchase.Amount", 
                                    true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePickerDay.DataBindings.Add("Value", purchasesVM, "Purchase.Date",
                                    true,DataSourceUpdateMode.OnPropertyChanged);
            dateTimePickerMonth.DataBindings.Add("Value", purchasesVM, "Purchase.Date", 
                                    true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePickerYear.DataBindings.Add("Value", purchasesVM, "Purchase.Date", 
                                    true, DataSourceUpdateMode.OnPropertyChanged);
            comboBoxCategory.DataBindings.Add("Text", purchasesVM, "Purchase.Category");
            textBoxInformation.DataBindings.Add("Text", purchasesVM, "Purchase.Information",
                                    true, DataSourceUpdateMode.OnPropertyChanged);
            textBoxNotes.DataBindings.Add("Text", purchasesVM, "Purchase.Notes",
                                    true, DataSourceUpdateMode.OnPropertyChanged);

            dataGridViewReceiptsInfo.AutoGenerateColumns = false;
            dataGridViewReceiptsInfo.DataSource = purchasesVM.Purchases;
        }


        //it will create the view of the data grid
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


        //Try to add the data from the fields with cash type, if it has rows affected it will reset the comboBox, the error provider and it will create a new Expenses with the current date
        //if not it will shows an error provider depends of the error
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int rowsAffected;
                purchasesVM.Purchase.Type = "Cash";
                rowsAffected = ExpensesValidation.AddExpenses(purchasesVM.GetDisplayPurchase());
                if (rowsAffected > 0)
                {
                    refreshListBox();

                    //reset the values in the form an create an empty purchase
                    comboBoxCategory.SelectedIndex = -1;
                    purchasesVM.SetDisplayPurchase(new Expenses() { Date = DateTime.Today });
                    errorProvider1.SetError(buttonAdd, string.Empty);
                    labelMessage.Text = string.Empty;
                }
                else
                {
                    if (rowsAffected == 0)
                    {
                        //MessageBox.Show("No DB changes were made\n\nPlease revise if the data is correct or if the data provided is not duplicated with an existing field\n\nIf you want to add duplicated data please specify in the Notes section and try again.", "Zero Affected Rows", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        errorProvider1.SetError(buttonAdd, "No DB changes were made\n\nPlease revise if the data is correct or if the data provided is not duplicated with an existing field\n\nIf you want to add duplicated data please specify it in the Notes section and try again.");
                        labelMessage.Text = "Probable repetition of data\nPlease check your entry if is not repeated\nif you want to repeat this entry\nplease provide details on Notes section";
                    }
                    else
                    {
                        //MessageBox.Show(ExpensesValidation.MessageError, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.SetError(buttonAdd, ExpensesValidation.MessageError);
                        labelMessage.Text = ExpensesValidation.MessageError;
                    }
                }
                dateTimePickerDay.Select();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\nPlease save this message and contact with technical support.", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPlease save this message and contact with technical support.", "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region TextBoxAmount selectAll() the content when focus or click
        private void textBoxAmount_Enter(object sender, EventArgs e)
        {
            textBoxAmount.Select();
            textBoxAmount.SelectAll();
        }
        private void textBoxAmount_Click(object sender, EventArgs e)
        {
            textBoxAmount.Select();
            textBoxAmount.SelectAll();
        }
        #endregion TextBoxAmount


        //refresh the listBox
        private void refreshListBox()
        {
            purchasesVM.Purchases = PurchaseRepository.GetExpenses();
            dataGridViewReceiptsInfo.DataSource = purchasesVM.Purchases;
        }


        //revises if the category combo box has some option selected if not displays an errorProvider
        private void comboBoxCategory_Leave(object sender, EventArgs e)
        {
            try
            {
                purchasesVM.Purchase.Category = comboBoxCategory.SelectedItem.ToString();
                errorProvider1.SetError(comboBoxCategory, string.Empty);
            }catch(Exception ex)
            {
                errorProvider1.SetError(comboBoxCategory, "Must select a category before to continue");
            }
        }

        private void dataGridViewReceiptsInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Creating a new DialogBox
            EditReciptDialog edit = new EditReciptDialog();
            edit.PurchaseVM = this.purchasesVM;

            //saving the index of the row to acces to the Expenses list and get the info of that purchase and store on the PurchassVM
            //also set the category manually to avoid bugs
            int index = Math.Max(0, dataGridViewReceiptsInfo.CurrentRow.Index);
            Expenses purchase = purchasesVM.Purchases[index];
            purchasesVM.SetDisplayPurchase(purchase);

            purchasesVM.Purchase.Category = purchasesVM.Purchases[index].Category;

            //stores the response of the user
            DialogResult result = edit.ShowDialog();

            if (result == DialogResult.OK)
            {
                Expenses expens = purchasesVM.GetDisplayPurchase();
                DeletingForm(expens);
            }
            if (result == DialogResult.Yes)
            {
                Expenses expens = purchasesVM.GetDisplayPurchase();
                EditingForm(expens);
                dataGridViewReceiptsInfo.Rows[index].Selected = true;
                dataGridViewReceiptsInfo.FirstDisplayedScrollingRowIndex = dataGridViewReceiptsInfo.SelectedRows[0].Index;
            }


            edit.Dispose();
        }

        //Method to edit a record from the data grid
        private void EditingForm(Expenses purchase)
        {
            try
            {
                int rowsAffected;
                rowsAffected = ExpensesValidation.EditRecord(purchase);
                if (rowsAffected > 0)
                {
                    errorProvider1.SetError(buttonAdd, string.Empty);
                    labelMessage.Text = string.Empty;
                    refreshListBox();
                }
                else
                {
                    if (rowsAffected == 0)
                    {
                        errorProvider1.SetError(buttonAdd, "No DB changes were made\n\nPlease revise if the data is correct or if the data provided is not duplicated with an existing field\n\nIf you want to add duplicated data please specify it in the Notes section and try again.");
                        labelMessage.Text = "No DB changes were made\nPlease revise if the data is not repeated";
                    }
                    else
                    {
                        errorProvider1.SetError(buttonAdd, ExpensesValidation.MessageError);
                        labelMessage.Text = ExpensesValidation.MessageError;
                    }

                }
                //creates a new empty object to set the form for a new record, changuing manually the combobox 
                purchasesVM.SetDisplayPurchase(new Expenses() { Date = DateTime.Today });
                comboBoxCategory.SelectedIndex = -1;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method to delete a record from the datagrid
        private void DeletingForm(Expenses purchase)
        {
            try
            {
                int rowsAffected;
                rowsAffected = ExpensesValidation.DeleteExpenses(purchase);
                if (rowsAffected <= 0)
                {
                    MessageBox.Show("No changes were made");
                    labelMessage.Text = "Entry not deleted";
                }
                else
                {
                    labelMessage.Text = string.Empty;
                    refreshListBox();
                }
                //creates a new empty object to set the form for a new record, changuing manually the combobox 
                purchasesVM.SetDisplayPurchase(new Expenses() { Date = DateTime.Today });
                comboBoxCategory.SelectedIndex = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
