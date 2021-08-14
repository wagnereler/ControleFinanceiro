using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mappings
{
    public class MonthMap : IEntityTypeConfiguration<Month>
    {
        public void Configure(EntityTypeBuilder<Month> builder)
        {
            builder.HasKey(month => month.MonthId);
            builder.Property(name => name.Name).IsRequired().HasMaxLength(20);
            builder.HasIndex(name => name.Name).IsUnique();
            //relacionamento N x 1
            builder.HasMany(expense => expense.Expenses).WithOne(month => month.Month);
            builder.HasMany(gain => gain.Gains).WithOne(month => month.Month);

            builder.HasData(
                new Month
                {
                    MonthId = 1,
                    Name = "Janeiro"
                },
                new Month
                {
                    MonthId = 2,
                    Name = "Fevereiro"
                },
                new Month
                {
                    MonthId = 3,
                    Name = "Março"
                },
                new Month
                {
                    MonthId = 4,
                    Name = "Abril"
                },
                new Month
                {
                    MonthId = 5,
                    Name = "Maio"
                },
                new Month
                {
                    MonthId = 6,
                    Name = "Junho"
                },
                new Month
                {
                    MonthId = 7,
                    Name = "Julho"
                },
                new Month
                {
                    MonthId = 8,
                    Name = "Agosto"
                },
                new Month
                {
                    MonthId = 9,
                    Name = "Setembro"
                },
                new Month
                {
                    MonthId = 10,
                    Name = "Outubro"
                },
                new Month
                {
                    MonthId = 11,
                    Name = "Novembro"
                },
                new Month
                {
                    MonthId = 12,
                    Name = "Dezembro"
                }
                );

            builder.ToTable("Month");

        }
    }
}
