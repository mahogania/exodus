using Evaluation.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Evaluation.Infrastructure;

public class EvaluationDbContext : IdentityDbContext<IdentityUser>
{
    public EvaluationDbContext(DbContextOptions<EvaluationDbContext> options)
        : base(options) { }

    public DbSet<CommonDbModel> Commons { get; set; }

    public DbSet<ItemDbModel> Items { get; set; }

    public DbSet<RequestDbModel> Requests { get; set; }

    public DbSet<ExpressDbModel> Expresses { get; set; }

    public DbSet<DetailDbModel> Details { get; set; }
}
