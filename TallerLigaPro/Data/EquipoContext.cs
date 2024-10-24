using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerLigaPro.Models;

    public class EquipoContext : DbContext
    {
        public EquipoContext (DbContextOptions<EquipoContext> options)
            : base(options)
        {
        }

        public DbSet<TallerLigaPro.Models.Equipo> Equipo { get; set; } = default!;
    }
