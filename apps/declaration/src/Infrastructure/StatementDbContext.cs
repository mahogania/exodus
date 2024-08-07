using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Statement.Infrastructure.Models;

namespace Statement.Infrastructure;

public class StatementDbContext : IdentityDbContext<IdentityUser>
{
    public StatementDbContext(DbContextOptions<StatementDbContext> options)
        : base(options) { }

    public DbSet<AttachmentDbModel> Attachments { get; set; }

    public DbSet<CancellationDbModel> Cancellations { get; set; }

    public DbSet<ContainerDbModel> Containers { get; set; }

    public DbSet<OperatorDbModel> Operators { get; set; }
}
