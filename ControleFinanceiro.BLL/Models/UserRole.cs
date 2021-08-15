using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;


namespace ControleFinanceiro.BLL.Models
{
    public class UserRole : IdentityRole<string>
    {
        public string Description { get; set; }
    }
}
