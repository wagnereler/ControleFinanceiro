using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public Card Card { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public double Value { get; set; }
        public int Day { get; set; }
        public int MonthId { get; set; }
        public Month Month { get; set; }
        public int Year { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

    }
}
