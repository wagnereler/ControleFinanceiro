using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int TypeId { get; set; }
        public TypeEnum Type { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Gain> Gains { get; set; }
    }
}
