using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mappings
{
    class GainMap : IEntityTypeConfiguration<Gain>
    {
        public void Configure(EntityTypeBuilder<Gain> builder)
        {
            builder.HasKey(pk => pk.GainId);
            builder.Property(description => description.Description).IsRequired().HasMaxLength(60);
            builder.HasOne(category => category.Category).WithMany(gain => gain.Gains).HasForeignKey(category => category.CategoryId).IsRequired();
            builder.Property(value => value.Value).IsRequired();
            builder.Property(day => day.Day).IsRequired();
            builder.HasOne(month => month.Month).WithMany(gain => gain.Gains).HasForeignKey(month => month.MonthId).IsRequired();
            builder.HasOne(user => user.User).WithMany(gain => gain.Gains).HasForeignKey(user => user.UserId).IsRequired();

            builder.ToTable("Gain");

        }
    }
}
