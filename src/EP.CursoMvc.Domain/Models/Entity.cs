using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Domain.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            ValidationResult = new Dictionary<string, string>();
        }
        public Guid Id { get; set; }

        public IDictionary<string, string> ValidationResult { get; set; }

        public void AdicionarErroValidacao( string erro, string mensagem)
        {
            ValidationResult.Add(erro, mensagem);   
        }

        public void ZerarlistaErros() 
        {
            ValidationResult = new Dictionary<string, string>();
        }

        public abstract bool EhValido();
    }
}
 