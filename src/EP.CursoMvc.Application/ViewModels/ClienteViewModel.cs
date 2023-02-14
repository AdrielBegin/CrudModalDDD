using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Application.ViewModels
{
    public class ClienteViewModel
    {
       public ClienteViewModel() 
        {
            Id = Guid.NewGuid();
            
        }
        
        [Key]
        public Guid Id { get; set; }
     
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Maximo 150 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Maximo 100 caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(11, ErrorMessage = "Maxiom 11 caracteres")]
        [DisplayName("CPF")]
        public string CPF{ get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data com o formato inválido")]
        
        public DateTime DateNascimento { get; set; }

        [ScaffoldColumn(false)]        
        public DateTime DataCadastro { get; set;}
        
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        
        [ScaffoldColumn(false)]
        public bool Excluido { get; set; }

    }
}
