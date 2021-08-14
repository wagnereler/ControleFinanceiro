using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    public class Month
    {
        public int MonthId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Gain> Gains { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
