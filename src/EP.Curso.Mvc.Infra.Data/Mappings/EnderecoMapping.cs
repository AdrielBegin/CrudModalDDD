using EP.CursoMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.Curso.Mvc.Infra.Data.Mappings
{
    public  class EnderecoMapping : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMapping() 
        {
            HasKey(e => e.Id);

            Property( e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(50);
            
            Property( e => e.Numero)
                .IsRequired() 
                .HasMaxLength(20);

            Property( e => e.Bairro)
                .IsRequired()
                .HasMaxLength(50);

            Property( e => e.CEP)
                .IsRequired()
                .HasMaxLength (8)
                .IsFixedLength();

            Property( e => e.Complemento)                
                .HasMaxLength(100);
            //HasOptional
            HasRequired(c => c.Cliente)
                .WithMany(c => c.Endereco)
                .HasForeignKey(e => e.ClienteId);

            ToTable("Endereco");
        }

    }
}
