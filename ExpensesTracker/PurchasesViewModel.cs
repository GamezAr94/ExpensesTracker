using ExpensesTracker.Common.Expenses;
using ExpensesTracker.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker
{
    class PurchasesViewModel:INotifyPropertyChanged
    {
        #region setting the eventhandler
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion setting the eventhandler

        //default constructor initializing a new list with the repository of all the expenses and a new Purchase with an empty expenses object
        public PurchasesViewModel()
        {
            this.Purchases = PurchaseRepository.GetExpenses();
            this.Purchase = new Expenses();
        }
        #region setting the property for the purchase and the purchases list
        private Expenses purchase;
        public Expenses Purchase
        {
            get { return purchase; }
            set
            {
                purchase = value;
                OnPropertyChanged();
            }
        }
        public ExpensesList Purchases { get; set; }
        #endregion setting the property for the purchase and the purchases list
        public void SetDisplayPurchase(Expenses purchase)
        {
            this.Purchase = new Expenses
            {
                Id = purchase.Id,
                Date = purchase.Date,
                Amount = purchase.Amount,
                Category = purchase.Category,
                Information = purchase.Information,
                Notes = purchase.Notes,
                Type = purchase.Type
        };
        }
        public Expenses GetDisplayPurchase()
        {
            OnPropertyChanged("Purchase");
            return this.Purchase;
        }
    }
}
