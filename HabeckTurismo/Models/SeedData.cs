using HabeckTurismo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabeckTurismo.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)  //Essa classe adiciona valores padrão à tabela região
        {
            using (var context = new AgenciaDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AgenciaDbContext>>()))
            {
                if (context.Regiao.Any())
                {
                    return;   // Já temm dados na tabela Região
                }
                context.Regiao.AddRange(
                    new Regiao { NomeReg = "Norte" },
                    new Regiao { NomeReg = "Nordeste" },
                    new Regiao { NomeReg = "Sul" },
                    new Regiao { NomeReg = "Sudeste" },
                    new Regiao { NomeReg = "Centro-Oeste" },
                    new Regiao { NomeReg = "Internacional" }
                );
                context.SaveChanges();
            }
        }
    }
}
