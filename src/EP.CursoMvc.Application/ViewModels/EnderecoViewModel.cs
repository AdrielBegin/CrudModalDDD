﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Application.ViewModels
{
    public class EnderecoViewModel
    {
        public EnderecoViewModel() 
        {
            Id = Guid.NewGuid();
        }

        [Key] 
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo logradouro")]
        [MaxLength(100, ErrorMessage =" Máximo 100 caracteres")]
        [MinLength(2, ErrorMessage ="Minimo 2 caracteres")]
        public string Logradouro{ get; set; }

        [Required(ErrorMessage ="Preencha o campo Numero")]
        [MaxLength(100, ErrorMessage ="Máximo 100 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        public string Numero { get; set; }

        [MaxLength(150, ErrorMessage ="Máximo 150 caracteres")]
        [MinLength(2, ErrorMessage ="Mínimo 2 caracteres")]        
        public string Complemento { get; set;}

        [Required(ErrorMessage = "Preencha o campo Bairro")]
        [MaxLength(100, ErrorMessage = " Máximo 100 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Preencha o campo CEP")]
        [MaxLength(8, ErrorMessage = " Máximo 8 caracteres")]
        [MinLength(8, ErrorMessage = "Minimo 8 caracteres")]      
        public string CEP { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cidade")]
        [MaxLength(100, ErrorMessage = " Máximo 100 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Preencha o campo Estado")]
        [MaxLength(100, ErrorMessage = " Máximo 100 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        public string Estado { get; set; }
        [ScaffoldColumn(false)]
        public Guid CidadeId { get; set; }







    }
}