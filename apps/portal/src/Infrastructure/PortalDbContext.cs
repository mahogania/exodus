using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Portal.Infrastructure;

public class PortalDbContext : IdentityDbContext<IdentityUser>
{
    public PortalDbContext(DbContextOptions<PortalDbContext> options)
        : base(options) { }
}
