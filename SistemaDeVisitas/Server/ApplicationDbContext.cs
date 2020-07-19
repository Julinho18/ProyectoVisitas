using Microsoft.EntityFrameworkCore;
using SistemaDeVisitas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeVisitas.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<GeneroPelicula>().HasKey(x => new { x.GeneroId, x.PeliculaId });
            //modelBuilder.Entity<PeliculaActor>().HasKey(x => new { x.PeliculaId, x.PersonaId });

            //var personas = new List<Persona>();
            //for (int i = 5; i < 100; i++)
            //{
            //    personas.Add(new Persona() { Id = i, Nombre = $"Persona {i}", 
            //        FechaNacimiento = DateTime.Today });
            //}

            //modelBuilder.Entity<Persona>().HasData(personas);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<CargoLaboral> CargosLaborales { get; set; }
        public DbSet<Instituto> Institutos { get; set; }
        public DbSet<Oficina> Oficinas { get; set; }
        public DbSet<Trabajador> Trabajadores { get; set; }
        public DbSet<Visitante> Visitantes { get; set; }
        public DbSet<Visita> Visitas{ get; set; }
    }
}
