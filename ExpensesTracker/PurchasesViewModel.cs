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
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public PurchasesViewModel()
        {
            this.Purchases = PurchaseRepository.GetExpenses();
            this.Purchase = new Expenses();
        }
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
