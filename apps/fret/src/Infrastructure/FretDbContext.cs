using Fret.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fret.Infrastructure;

public class FretDbContext : IdentityDbContext<IdentityUser>
{
    public FretDbContext(DbContextOptions<FretDbContext> options)
        : base(options) { }

    public DbSet<ManifestDbModel> Manifests { get; set; }

    public DbSet<ContainerDbModel> Containers { get; set; }

    public DbSet<LineDbModel> Lines { get; set; }

    public DbSet<TrailerDbModel> Trailers { get; set; }

    public DbSet<VehicleDbModel> Vehicles { get; set; }

    public DbSet<TrainDbModel> Trains { get; set; }

    public DbSet<CommonDbModel> Commons { get; set; }
}
