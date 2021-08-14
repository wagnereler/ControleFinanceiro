using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mappings
{
    public class ExpenseMap : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.HasKey(expense => expense.ExpenseId);
            builder.Property(description => description.Description).IsRequired().HasMaxLength(50);
            builder.Property(value => value.Value).IsRequired();
            builder.Property(day => day.Day).IsRequired();
            builder.Property(year => year.Year).IsRequired();
            builder.HasOne(card => card.Card).WithMany(expase => expase.Expenses).HasForeignKey(expense => expense.ExpenseId).IsRequired();
            builder.HasOne(category => category.Category).WithMany(expense => expense.Expenses).HasForeignKey(category => category.Category).IsRequired();
            builder.HasOne(month => month.Month).WithMany(expense => expense.Expenses).HasForeignKey(month => month.Month).IsRequired();
            builder.HasOne(user => user.User).WithMany(expense => expense.Expenses).HasForeignKey(user => user.User).IsRequired();

            builder.ToTable("Expense");


        }
    }
}
