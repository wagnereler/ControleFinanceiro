using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mappings
{
    public class TypeMap : IEntityTypeConfiguration<TypeEnum>
    {
        public void Configure(EntityTypeBuilder<TypeEnum> builder)
        {
            //chave primaria
            builder.HasKey(pk => pk.TypeId);
            //demais campos
            builder.Property(name => name.Name).IsRequired().HasMaxLength(60);
            //relacionamento 1 x N
            builder.HasMany(type => type.Categories).WithOne(type => type.Type);

            //popular tabela
            builder.HasData(
                new TypeEnum
                {
                    TypeId = 1,
                    Name = "Despesa"
                },

                 new TypeEnum
                 {
                     TypeId = 2,
                     Name = "Ganho"
                 }
                );
            //nome da tabela
            builder.ToTable("Type");
        }
    }
}
