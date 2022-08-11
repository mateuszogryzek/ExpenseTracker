using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Data
{
    public class Expense
    {
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Date { get; set; }

    }
}
