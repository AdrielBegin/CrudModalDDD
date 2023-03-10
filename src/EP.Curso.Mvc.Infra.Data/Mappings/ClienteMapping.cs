using EP.CursoMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.Curso.Mvc.Infra.Data.Mappings
{
    // Fluente API
    public class ClienteMapping : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapping() 
        {
            HasKey(x => x.Id);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);
            
            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength (100);

            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_CPF") {IsUnique = true}));


            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.Ativo)
                .IsRequired();

            Property(c => c.Excluido)
                .IsRequired();

            ToTable("Clientes","Sistema1");


        }

    }
}
