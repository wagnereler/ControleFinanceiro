using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mappings
{
    class CardMap : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(card => card.CardId);
            builder.Property(name => name.Name).IsRequired().HasMaxLength(20);
            builder.HasIndex(name => name.Name).IsUnique();
            builder.Property(flag => flag.Flag).IsRequired().HasMaxLength(20);
            builder.Property(number => number.Number).IsRequired().HasMaxLength(20);
            builder.HasIndex(number => number.Number).IsUnique();
            builder.Property(limit => limit.Limit).IsRequired().HasMaxLength(10);
            builder.HasOne(user => user.User).WithMany(card => card.Cards).HasForeignKey(user => user.UserId).IsRequired().OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(expense => expense.Expenses);

            builder.ToTable("Card");

        }
    }
}
