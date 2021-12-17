using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HabeckTurismo.Models
{
    public class Destino
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public double PrecoDiaria { get; set; }

        [Required]
        public string Url { get; set; }

        [Required]
        public int RegiaoId { get; set; }
        public Regiao Regiao { get; set; }
    }
}
