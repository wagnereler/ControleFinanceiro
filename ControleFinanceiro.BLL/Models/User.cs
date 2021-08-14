using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    public class User : IdentityUser<string>
    {
        public string CPF { get; set; }
        public string Occupation { get; set; }
        public byte[] Photo { get; set; }
        public virtual ICollection<Card>Cards { get; set; }
        public virtual ICollection<Gain>Gains { get; set; }
        public virtual ICollection<Expense>Expenses { get; set; }
    }
}
