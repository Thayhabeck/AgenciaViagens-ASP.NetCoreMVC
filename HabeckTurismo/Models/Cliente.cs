using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HabeckTurismo.Models
{
    public class Cliente
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string cpf { get; set; }
        [Required]
        public string endereco { get; set; }
    }
}
