using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL.Mappings;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL
{
    public class Context : IdentityDbContext<User, UserRole, string>
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Category> Cateogories { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Gain> Gains { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<TypeEnum> TypeEnums { get; set; }
        public DbSet<User> Users { get; set; }
        //inicia um contrutor passando como parâmestro as opções de contexto
        public Context(DbContextOptions<Context> options) : base(options) { }

        //para passar as configurações de tabelas é necessário sobrescrever a função
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CardMap());
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new ExpenseMap());
            builder.ApplyConfiguration(new GainMap());
            builder.ApplyConfiguration(new MonthMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new TypeMap());
            builder.ApplyConfiguration(new UserRoleMap());
        }

    }
}
