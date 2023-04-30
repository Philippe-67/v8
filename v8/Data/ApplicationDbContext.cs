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
        public DbSet<v8.Models.Voiture>? Voiture { get; set; }
        public DbSet<v8.Models.Reparation>? Reparation { get; set; }
        public DbSet<v8.Models.Intervention>? Intervention { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUserLogin<string>>().HasKey(l => new { l.LoginProvider, l.ProviderKey });
            // }
            // protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                builder.Entity<ReparationIntervention>()
                    .HasKey(ri => new { ri.ReparationId, ri.InterventionId });

                builder.Entity<ReparationIntervention>()
                    .HasOne(ri => ri.Reparation)
                    .WithMany(r => r.ReparationInterventions)
                    .HasForeignKey(ri => ri.ReparationId);

                builder.Entity<ReparationIntervention>()
                     .HasOne(ri => ri.Intervention)
                     .WithMany(i => i.ReparationInterventions)
                     .HasForeignKey(ri => ri.InterventionId);
            }
        }
        public DbSet<v8.Models.ReparationIntervention>? ReparationIntervention { get; set; }
    }
}
