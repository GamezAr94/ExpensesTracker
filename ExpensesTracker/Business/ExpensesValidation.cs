using ExpensesTracker.Common.Expenses;
using ExpensesTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Business
{
    class ExpensesValidation
    {
        private static readonly List<string> errors;
        public static string MessageError
        {
            get
            {
                string message = "";
                foreach(string line in errors)
                {
                    message += line + "\r\n";
                }
                return message;
            }
        }
        static ExpensesValidation()
        {
            errors = new List<string>();
        }
        public static int AddExpenses(Expenses purchase)
        {
            if (Validator(purchase))
            {
                return PurchaseRepository.AddExpenses(UppercaseFirst(purchase));
            }
            return -1;
        }
        static Expenses UppercaseFirst(Expenses purchase)
        {
            if (!string.IsNullOrWhiteSpace(purchase.Information))
            {
                purchase.Information = char.ToUpper(purchase.Information[0]) + purchase.Information.Substring(1);
                purchase.Information = purchase.Information.TrimStart(' ');
            }
            if (!string.IsNullOrWhiteSpace(purchase.Notes))
            {
                purchase.Notes = char.ToUpper(purchase.Notes[0]) + purchase.Notes.Substring(1);
                purchase.Notes = purchase.Notes.Replace('\n', ' ');
                purchase.Notes = purchase.Notes.TrimStart(' ');
            }
            else
            {
                purchase.Notes = "";
            }
            return purchase;
        }
        private static bool Validator(Expenses purchase)
        {
            errors.Clear();
            if(purchase.Amount <= 0)
            {
                errors.Add("Amount cannot be less or equal than zero.");
            }
            if (string.IsNullOrEmpty(purchase.Category)){
                errors.Add("You must select a category for this field.");
            }
            if (string.IsNullOrWhiteSpace(purchase.Information))
            {
                errors.Add("You need to add more data to the information section.");
            }
            if (string.IsNullOrWhiteSpace(purchase.Type))
            {
                errors.Add("CONTACT THE SUPPORT TO FIX THIS PROBLEM.");
            }
            if(purchase.Date.Year < 2000)
            {
                errors.Add("Date must be grather than the year 2000.");
            }
            if (purchase.Date > DateTime.Today)
            {
                errors.Add("You must specify a date before todays date.");
            }
            return !(errors.Count > 0);
        }
    }
}
