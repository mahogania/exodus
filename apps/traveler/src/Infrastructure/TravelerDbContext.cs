using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Traveler.Infrastructure.Models;

namespace Traveler.Infrastructure;

public class TravelerDbContext : IdentityDbContext<IdentityUser>
{
    public TravelerDbContext(DbContextOptions<TravelerDbContext> options)
        : base(options) { }

    public DbSet<GeneralTravelerInformationTpdDbModel> GeneralTravelerInformationTpds { get; set; }

    public DbSet<TpdEntryAndExitHistoryDbModel> TpdEntryAndExitHistories { get; set; }

    public DbSet<TpdControlDbModel> TpdControls { get; set; }

    public DbSet<TpdVehicleDbModel> TpdVehicles { get; set; }

    public DbSet<ExitVoucherDbModel> ExitVouchers { get; set; }

    public DbSet<AccompaniedBaggageEntryAndExitDbModel> AccompaniedBaggageEntryAndExits { get; set; }

    public DbSet<AppealDbModel> Appeals { get; set; }

    public DbSet<TravelersArticlesEntryExitDbModel> TravelersArticlesEntryExits { get; set; }

    public DbSet<InspectorRatingModificationHistoryDbModel> InspectorRatingModificationHistories { get; set; }

    public DbSet<BaggageControlArticleDbModel> BaggageControlArticles { get; set; }

    public DbSet<ImportDeclarationDbModel> ImportDeclarations { get; set; }

    public DbSet<GeneralBondNoteDbModel> GeneralBondNotes { get; set; }

    public DbSet<TravelerSearchHistoryDbModel> TravelerSearchHistories { get; set; }
}
