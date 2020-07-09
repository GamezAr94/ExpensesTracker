using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Common.Expenses
{
    class Expenses
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public string Type { get; set; }
    }
}
