using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(pk => pk.CategoryId);
            builder.Property(name => name.Name).IsRequired().HasMaxLength(50);
            builder.Property(icon => icon.Icon).IsRequired().HasMaxLength(15);
            builder.HasOne(type => type.Type).WithMany(category => category.Categories).HasForeignKey(type => type.TypeId).IsRequired();
            builder.HasMany(gain => gain.Gains).WithOne(category => category.Category);
            //builder.HasMany(expense => expense.Expenses).WithOne(category => category.Category);

            builder.ToTable("Category");

        }
    }

}
