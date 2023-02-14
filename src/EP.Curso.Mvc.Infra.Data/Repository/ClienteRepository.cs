using EP.CursoMvc.Domain.Interface;
using EP.CursoMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.Curso.Mvc.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public IEnumerable<Cliente> ObterAvitos()
        {
            return Buscar(c => c.Ativo);
        }

        public Cliente ObterPorCpf(string cpf)
        {
            return Buscar(c => c.CPF == cpf).FirstOrDefault();

        }

        public Cliente ObterPorEmail(string email)
        {            
            return Buscar(c => c.Email == email).FirstOrDefault();
        }

        public override Cliente ObterPorId(Guid id)
        {
            return Db.Clientes.AsNoTracking().Include("Endereco").First(c => c.Id == id);
        }

        public override void Remover(Guid id)
        {
            var cliente = ObterPorId(id);
            cliente.DefinirComoExcluido();

            Atualizar(cliente);

        }
    }
}
