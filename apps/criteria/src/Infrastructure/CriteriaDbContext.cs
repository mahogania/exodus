using Criteria.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Criteria.Infrastructure;

public class CriteriaDbContext : IdentityDbContext<IdentityUser>
{
    public CriteriaDbContext(DbContextOptions<CriteriaDbContext> options)
        : base(options) { }

    public DbSet<ServiceQuotationCriterionDbModel> ServiceQuotationCriteria { get; set; }

    public DbSet<InspectorQuotationModeDbModel> InspectorQuotationModes { get; set; }

    public DbSet<InspectorQuotationStatDbModel> InspectorQuotationStats { get; set; }

    public DbSet<InspectorVerifierDesignationDbModel> InspectorVerifierDesignations { get; set; }

    public DbSet<AgentVisitDbModel> AgentVisits { get; set; }

    public DbSet<InspectorQuotationCriterionDbModel> InspectorQuotationCriteria { get; set; }

    public DbSet<InspectorRatingCriteriaDeclarationModelDbModel> InspectorRatingCriteriaDeclarationModels { get; set; }

    public DbSet<InspectorRatingCriteriaInspectorDbModel> InspectorRatingCriteriaInspectors { get; set; }
}
