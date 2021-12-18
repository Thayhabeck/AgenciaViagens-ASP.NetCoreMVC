using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace HabeckTurismo.Models
{
    public class Viagem
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string DataIda { get; set; }
        [Required]
        public string DataVolta { get; set; }
        [Required]
        public int Diarias { get; set; }

        [Required]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        public int DestinoId { get; set; }
        public Destino Destino { get; set; }
    }
}
