using Collection.APIs;

namespace Collection;

public static class ServiceCollectionExtensions
{
    /// <summary>
    ///     Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IAccountingsService, AccountingsService>();
        services.AddScoped<IAdjustmentsService, AdjustmentsService>();
        services.AddScoped<IAppealsService, AppealsService>();
        services.AddScoped<IArticlesService, ArticlesService>();
        services.AddScoped<IAuctionReportsService, AuctionReportsService>();
        services.AddScoped<IBondReleasesService, BondReleasesService>();
        services.AddScoped<ICausesService, CausesService>();
        services.AddScoped<ICautionsService, CautionsService>();
        services.AddScoped<ICertificatesService, CertificatesService>();
        services.AddScoped<IClaimedFinesService, ClaimedFinesService>();
        services.AddScoped<ICodesService, CodesService>();
        services.AddScoped<ICollectionsService, CollectionsService>();
        services.AddScoped<ICreditsService, CreditsService>();
        services.AddScoped<IDelaysService, DelaysService>();
        services.AddScoped<IDepositsService, DepositsService>();
        services.AddScoped<IDetailsService, DetailsService>();
        services.AddScoped<IDistributionsService, DistributionsService>();
        services.AddScoped<IFinesService, FinesService>();
        services.AddScoped<IFineCancellationRequestsService, FineCancellationRequestsService>();
        services.AddScoped<IFineCausesService, FineCausesService>();
        services.AddScoped<IFineRequestsService, FineRequestsService>();
        services.AddScoped<IFineRequestHistoriesService, FineRequestHistoriesService>();
        services.AddScoped<IFormalNoticesService, FormalNoticesService>();
        services.AddScoped<IIssuancesService, IssuancesService>();
        services.AddScoped<IManagementsService, ManagementsService>();
        services.AddScoped<
            IManagementOfAccountingAccountsByPaymentNoticeTypesService,
            ManagementOfAccountingAccountsByPaymentNoticeTypesService
        >();
        services.AddScoped<IManageRecklessBiddersService, ManageRecklessBiddersService>();
        services.AddScoped<INoticesService, NoticesService>();
        services.AddScoped<INoticeCancellationsService, NoticeCancellationsService>();
        services.AddScoped<INoticeOfDefaultsService, NoticeOfDefaultsService>();
        services.AddScoped<INoticeStaggeringsService, NoticeStaggeringsService>();
        services.AddScoped<INoticeTypesService, NoticeTypesService>();
        services.AddScoped<IOfficialReportsService, OfficialReportsService>();
        services.AddScoped<IOrdersService, OrdersService>();
        services.AddScoped<IOthersService, OthersService>();
        services.AddScoped<IPaymentsService, PaymentsService>();
        services.AddScoped<IProceduresService, ProceduresService>();
        services.AddScoped<IReceiptsService, ReceiptsService>();
        services.AddScoped<IReceptionsService, ReceptionsService>();
        services.AddScoped<IRefundRequestsService, RefundRequestsService>();
        services.AddScoped<IReimbursementsService, ReimbursementsService>();
        services.AddScoped<IRemovalOrdersService, RemovalOrdersService>();
        services.AddScoped<ISecuritiesService, SecuritiesService>();
        services.AddScoped<IVariousRequestsService, VariousRequestsService>();
    }
}
