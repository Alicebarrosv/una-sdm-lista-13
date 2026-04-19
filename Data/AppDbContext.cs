using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmericanAirlinesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AmericanAirlinesApi.Data
{
    public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Aeronave> Aeronaves => Set<Aeronave>();
    public DbSet<Reserva> Reservas => Set<Reserva>();
    public DbSet<Tripulante> Tripulantes => Set<Tripulante>();
    public DbSet<Voo> Voos => Set<Voo>();
}
}


