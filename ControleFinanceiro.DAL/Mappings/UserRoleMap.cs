using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.DAL.Mappings
{
    class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            //implementa chave primária diretamente pelo Entity
            builder.Property(pk => pk.Id);
            builder.Property(description => description.Description);

            //gerar dados iniciais
            builder.HasData(
                new UserRole
                {
                    Id = Guid.NewGuid().ToString(), //gera um hash code
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR", //Compara valores
                    Description = "Administrador do sistema."
                },
                new UserRole
                {
                    Id = Guid.NewGuid().ToString(), //gera um hash code
                    Name = "Usuario",
                    NormalizedName = "USUARIO", //Compara valores
                    Description = "Usuário do sistema."
                }
                );
            builder.ToTable("UserFunction");
        }
    }
}
