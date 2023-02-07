using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Domain.Models
{
    public class Cliente : Entity
    {        
        public string Email { get; set; }
        public string CPF{ get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set;}
        public bool Excluido { get; set;}
        
        public void DefinirComoExcluido() 
        { 
            Ativo = false;
            Excluido= true;
        }
        public void DefinirComoAtivo()
        {
            Ativo = true;
            Excluido = false;
        }
    }
}
