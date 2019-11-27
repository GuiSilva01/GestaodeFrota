using System;
using System.Collections.Generic;
using System.Text;
using GestaodeFrota.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestaodeFrota.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Abastecimento> Abastecimento { get; set; }
        public DbSet<Automovel> Automovel { get; set; }
        public DbSet<Locacao> Locacao { get; set; }
        public DbSet<Manutencao> Manutencao { get; set; }
        public DbSet<Motorista> Motorista { get; set; }
        public DbSet<Multa> Multa { get; set; }
        public DbSet<Oficina> Oficina { get; set; }
        public DbSet<Posto> Posto { get; set; }
        public DbSet<Seguro> Seguro { get; set; }
        public DbSet<Viagem> Viagem { get; set; }
        public DbSet<Apolice> Apolice { get; set; }
    }
}
