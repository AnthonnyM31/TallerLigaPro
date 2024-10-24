using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerLigaPro.Models;

public class JugadorContext : DbContext
{
    public JugadorContext(DbContextOptions<JugadorContext> options)
        : base(options)
    {
    }


    public DbSet<Jugador> Jugadores { get; set; } = default!;

    public DbSet<Equipo> Equipos { get; set; } = default!;
    public DbSet<Estadio> Estadio { get; set; } = default!;
}
