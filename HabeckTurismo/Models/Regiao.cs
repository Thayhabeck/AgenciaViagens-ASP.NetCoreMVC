using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HabeckTurismo.Models
{
    public class Regiao
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string NomeReg { get; set; }


    }
}
