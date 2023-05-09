using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using v8.Models;

namespace v8.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Voiture>().
                HasData(
                new Voiture
                {
                    Id = 1,
                    Marque = "Audi",
                    Modele = "A3",
                    Finition = "Sline",
                    DateAchat = DateTime.Now,
                    Annee = 2010,
                    PrixAchat = 12000
                },
                new Voiture
                {
                    Id = 2,
                    Marque = "BMW",
                    Modele = "Serie 3",
                    Finition = "M",
                    DateAchat = DateTime.Now.AddDays(-3),
                    Annee = 2015,
                    PrixAchat = 18000
                });
            builder.Entity<Reparation>().HasData(
                new Reparation
                {
                    Id = 1,
                    DateDisponibilite = DateTime.Now,
                    Description = "Courroie distribution + embrayage",
                    VoitureId = 2,
                },
                new Reparation
                {
                    Id = 2,
                    DateDisponibilite = DateTime.Now.AddDays(2),
                    Description = "Remplacement turbo + Plaquette",
                    VoitureId = 1
                });
            builder.Entity<Intervention>().HasData(
                new Intervention
                {
                    Id = 1,
                    NomIntervention = "Plaquette",
                    PrixIntervention = 40
                },
                new Intervention
                {
                    Id = 2,
                    NomIntervention = "Courroie distribution",
                    PrixIntervention = 120
                },
                new Intervention
                {
                    Id = 3,
                    NomIntervention = "Turbo",
                    PrixIntervention = 250
                },
                new Intervention
                {
                    Id = 4,
                    NomIntervention = "Embrayage",
                    PrixIntervention = 220
                }
                );
            builder.Entity<ReparationIntervention>().HasData(
                new ReparationIntervention
                {
                    Id = 1,
                    InterventionId = 4,
                    ReparationId = 1
                },
                new ReparationIntervention
                {
                    Id = 2,
                    InterventionId = 2,
                    ReparationId = 1
                },
                new ReparationIntervention
                {
                    Id = 3,
                    InterventionId = 1,
                    ReparationId = 2
                },
                new ReparationIntervention
                {
                    Id = 4,
                    InterventionId = 3,
                    ReparationId = 2
                });
        }
        public DbSet<v8.Models.Voiture>? Voiture { get; set; } = default!;
        public DbSet<v8.Models.Reparation>? Reparation { get; set; } = default!;
        public DbSet<v8.Models.Intervention>? Intervention { get; set; } = default!;

        public DbSet<ReparationIntervention> ReparationInterventions { get; set; } = default!;
    }
}
