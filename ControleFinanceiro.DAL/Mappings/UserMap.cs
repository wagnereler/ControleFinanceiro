using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(user => user.Id).ValueGeneratedOnAdd();
            builder.Property(cpf => cpf.CPF).IsRequired().HasMaxLength(11);
            builder.HasIndex(cpf => cpf.CPF).IsUnique();
            builder.Property(occupation => occupation.Occupation).IsRequired().HasMaxLength(30);
            //relacionamento n x 1
            builder.HasMany(card => card.Cards).WithOne(user => user.User).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(expense => expense.Expenses).WithOne(user => user.User).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(gain => gain.Gains).WithOne(user => user.User).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("User");

        }
    }
}
