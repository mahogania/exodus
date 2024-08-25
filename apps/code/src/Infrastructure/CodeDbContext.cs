using Code.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Code.Infrastructure;

public class CodeDbContext : IdentityDbContext<IdentityUser>
{
    public CodeDbContext(DbContextOptions<CodeDbContext> options)
        : base(options) { }

    public DbSet<TarifGeneralDbModel> TarifGenerals { get; set; }

    public DbSet<PeriodeTarifNormalGeneralDbModel> PeriodeTarifNormalGenerals { get; set; }

    public DbSet<PeriodeTarifSpecialGeneralDbModel> PeriodeTarifSpecialGenerals { get; set; }

    public DbSet<PaysPreferentielDbModel> PaysPreferentiels { get; set; }

    public DbSet<ArticlePaysPartenaireConventionDouaniereDbModel> ArticlePaysPartenaireConventionDouanieres { get; set; }

    public DbSet<ArticleTarifDbModel> ArticleTarifs { get; set; }

    public DbSet<ArticlePeriodeApplicationTarifNormalDbModel> ArticlePeriodeApplicationTarifNormals { get; set; }

    public DbSet<ArticlePeriodeApplicationTarifSpecialDbModel> ArticlePeriodeApplicationTarifSpecials { get; set; }

    public DbSet<ArticlePaysBeneficiaireAntiDumpingDbModel> ArticlePaysBeneficiaireAntiDumpings { get; set; }

    public DbSet<PrixUnitaireDeclarationDetailDbModel> PrixUnitaireDeclarationDetails { get; set; }

    public DbSet<ShAnalyseCollectionEntrepriseDbModel> ShAnalyseCollectionEntreprises { get; set; }

    public DbSet<ShAnalyseCollectionTemporaireDbModel> ShAnalyseCollectionTemporaires { get; set; }

    public DbSet<ValeurBoursiereDbModel> ValeurBoursieres { get; set; }

    public DbSet<ShAnalyseEvolutionPrixCollectionDbModel> ShAnalyseEvolutionPrixCollections { get; set; }

    public DbSet<ShAnalysePrixUnitaireDbModel> ShAnalysePrixUnitaires { get; set; }

    public DbSet<ComparaisonShEntrePaysDbModel> ComparaisonShEntrePaysItems { get; set; }

    public DbSet<ShAnalyseCollectionTemporaire2DbModel> ShAnalyseCollectionTemporaire2s { get; set; }

    public DbSet<ShAnalyseCollectionDbModel> ShAnalyseCollections { get; set; }

    public DbSet<ShProfilDbModel> ShProfils { get; set; }

    public DbSet<ShAnalyseCollectionTemporaire3DbModel> ShAnalyseCollectionTemporaire3s { get; set; }
}
