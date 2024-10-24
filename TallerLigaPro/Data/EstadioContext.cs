using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerLigaPro.Models;

    public class EstadioContext : DbContext
    {
        public EstadioContext (DbContextOptions<EstadioContext> options)
            : base(options)
        {
        }

        public DbSet<TallerLigaPro.Models.Estadio> Estadio { get; set; } = default!;
    }
