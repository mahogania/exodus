using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fret.Infrastructure;

public class FretDbContext : IdentityDbContext<IdentityUser>
{
    public FretDbContext(DbContextOptions<FretDbContext> options)
        : base(options) { }
}
