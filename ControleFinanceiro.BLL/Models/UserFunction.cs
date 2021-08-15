using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;


namespace ControleFinanceiro.BLL.Models
{
    public class UserFunction : IdentityRole<string>
    {
        public string Description { get; set; }
    }
}
