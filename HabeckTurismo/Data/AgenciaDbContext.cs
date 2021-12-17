using HabeckTurismo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabeckTurismo.Data
{
    public class AgenciaDbContext : DbContext
    {
        public AgenciaDbContext()
        {
        }

        public AgenciaDbContext(DbContextOptions<AgenciaDbContext> opt) : base(opt)
        {

        }
       
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
        public DbSet<Regiao> Regiao { get; set; }
    }
}
