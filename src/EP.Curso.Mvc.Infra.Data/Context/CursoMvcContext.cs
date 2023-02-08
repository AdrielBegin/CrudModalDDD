using EP.Curso.Mvc.Infra.Data.Mappings;
using EP.CursoMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.Curso.Mvc.Infra.Data.Context
{
    public class CursoMvcContext: DbContext
    {
        public DbSet<Cliente> Clientes{ get; set; }
        public DbSet<Endereco> Enderecos{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            //modelBuilder.HasDefaultSchema("Sistema1");

            modelBuilder.Configurations.Add(new ClienteMapping());
            modelBuilder.Configurations.Add(new EnderecoMapping());


            base.OnModelCreating(modelBuilder);
        }

    }
}
