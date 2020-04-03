using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Com_ASP.CORE_MVC.Models
{
    public class Cliente
    {
        public int id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatorio! ")]
        [MaxLength(50, ErrorMessage = "Campo deve ter no maximo 50 caracteres!")]
        public string nome { get; set; }

        [Required(ErrorMessage = "O campo e-mail é obrigatorio! ")]
        public string email { get; set; }

        [Required(ErrorMessage = "O campo telefone é obrigatorio! ")]
        public int telefone { get; set; }
    }
}
