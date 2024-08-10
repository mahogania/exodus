using Collection.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Collection.Infrastructure;

public class CollectionDbContext : IdentityDbContext<IdentityUser>
{
    public CollectionDbContext(DbContextOptions<CollectionDbContext> options)
        : base(options)
    {
    }

    public DbSet<DetailDbModel> Details { get; set; }

    public DbSet<OthersDbModel> OthersItems { get; set; }

    public DbSet<AccountingDbModel> Accountings { get; set; }

    public DbSet<FineCancellationRequestDbModel> FineCancellationRequests { get; set; }

    public DbSet<BondReleaseDbModel> BondReleases { get; set; }

    public DbSet<ManagementDbModel> Managements { get; set; }

    public DbSet<NoticeDbModel> Notices { get; set; }

    public DbSet<NoticeStaggeringDbModel> NoticeStaggerings { get; set; }

    public DbSet<FineDbModel> Fines { get; set; }

    public DbSet<FineRequestHistoryDbModel> FineRequestHistories { get; set; }

    public DbSet<CauseDbModel> Causes { get; set; }

    public DbSet<ReceiptDbModel> Receipts { get; set; }

    public DbSet<OrderDbModel> Orders { get; set; }

    public DbSet<CertificateDbModel> Certificates { get; set; }

    public DbSet<DistributionDbModel> Distributions { get; set; }

    public DbSet<NoticeCancellationDbModel> NoticeCancellations { get; set; }

    public DbSet<PaymentDbModel> Payments { get; set; }

    public DbSet<ReceptionDbModel> Receptions { get; set; }

    public DbSet<ManagementOfAccountingAccountsByPaymentNoticeTypeDbModel>
        ManagementOfAccountingAccountsByPaymentNoticeTypes { get; set; }

    public DbSet<CreditDbModel> Credits { get; set; }

    public DbSet<ManageRecklessBidderDbModel> ManageRecklessBidders { get; set; }

    public DbSet<ArticleDbModel> Articles { get; set; }

    public DbSet<VariousRequestDbModel> VariousRequests { get; set; }

    public DbSet<DepositDbModel> Deposits { get; set; }

    public DbSet<IssuanceDbModel> Issuances { get; set; }

    public DbSet<CollectionDbModel> Collections { get; set; }

    public DbSet<CodeDbModel> Codes { get; set; }

    public DbSet<ReimbursementDbModel> Reimbursements { get; set; }

    public DbSet<FormalNoticeDbModel> FormalNotices { get; set; }

    public DbSet<NoticeTypeDbModel> NoticeTypes { get; set; }

    public DbSet<FineRequestDbModel> FineRequests { get; set; }

    public DbSet<AdjustmentDbModel> Adjustments { get; set; }

    public DbSet<ClaimedFineDbModel> ClaimedFines { get; set; }

    public DbSet<OfficialReportDbModel> OfficialReports { get; set; }

    public DbSet<NoticeOfDefaultDbModel> NoticeOfDefaults { get; set; }

    public DbSet<SecurityDbModel> Securities { get; set; }

    public DbSet<AuctionReportDbModel> AuctionReports { get; set; }

    public DbSet<CautionDbModel> Cautions { get; set; }

    public DbSet<ProcedureDbModel> Procedures { get; set; }

    public DbSet<RemovalOrderDbModel> RemovalOrders { get; set; }

    public DbSet<RefundRequestDbModel> RefundRequests { get; set; }

    public DbSet<FineCauseDbModel> FineCauses { get; set; }

    public DbSet<AppealDbModel> Appeals { get; set; }

    public DbSet<DelayDbModel> Delays { get; set; }
}
