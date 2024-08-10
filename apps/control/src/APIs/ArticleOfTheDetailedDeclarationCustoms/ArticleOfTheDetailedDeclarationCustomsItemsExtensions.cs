using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ArticleOfTheDetailedDeclarationCustomsItemsExtensions
{
    public static ArticleOfTheDetailedDeclarationCustoms ToDto(
        this ArticleOfTheDetailedDeclarationCustomsDbModel model
    )
    {
        return new ArticleOfTheDetailedDeclarationCustoms
        {
            ApcCode = model.ApcCode,
            ArticleName = model.ArticleName,
            ArticleNumber = model.ArticleNumber,
            ArticlePackageUnitCode = model.ArticlePackageUnitCode,
            BrandName = model.BrandName,
            CountryOfOriginCode = model.CountryOfOriginCode,
            CreatedAt = model.CreatedAt,
            DateAndTimeOfFinalModification = model.DateAndTimeOfFinalModification,
            DateAndTimeOfFirstRegistration = model.DateAndTimeOfFirstRegistration,
            DeletionOn = model.DeletionOn,
            EndDateOfApcApproval = model.EndDateOfApcApproval,
            FinalModifierSId = model.FinalModifierSId,
            FirstRecorderSId = model.FirstRecorderSId,
            GrossWeightOfTheArticle = model.GrossWeightOfTheArticle,
            Id = model.Id,
            Key = model.Key,
            ManagementAndMonitoringClearanceExpiryPeriod =
                model.ManagementAndMonitoringClearanceExpiryPeriod,
            ManagementOfShCodeExtractCodes = model.ManagementOfShCodeExtractCodes,
            NetWeightOfTheArticle = model.NetWeightOfTheArticle,
            NewAndUsedProductCode = model.NewAndUsedProductCode,
            NumberOfArticlePackages = model.NumberOfArticlePackages,
            OilTankNumber = model.OilTankNumber,
            ParcelDescription = model.ParcelDescription,
            ParcelShippingMarkNumber = model.ParcelShippingMarkNumber,
            PartialClearanceTypeCode = model.PartialClearanceTypeCode,
            PreferentialCode = model.PreferentialCode,
            PreviousArticleNumber = model.PreviousArticleNumber,
            PreviousDetailedDeclarationDate = model.PreviousDetailedDeclarationDate,
            PreviousDetailedDeclarationNumber = model.PreviousDetailedDeclarationNumber,
            ProhibitedProductCode = model.ProhibitedProductCode,
            Quantity = model.Quantity,
            QuantityUnitCode = model.QuantityUnitCode,
            QuotaAuthorizationNumber = model.QuotaAuthorizationNumber,
            RectificationFrequency = model.RectificationFrequency,
            ReferenceNumber = model.ReferenceNumber,
            RequestRegimeNumber = model.RequestRegimeNumber,
            RtcDecisionAuthorizationNumber = model.RtcDecisionAuthorizationNumber,
            ShCode = model.ShCode,
            SpecificCodeForClassificationOfGoods = model.SpecificCodeForClassificationOfGoods,
            StartDateOfApcApproval = model.StartDateOfApcApproval,
            StatisticalValue = model.StatisticalValue,
            SuperiorArticleNumber = model.SuperiorArticleNumber,
            TaxationQuantity = model.TaxationQuantity,
            TaxationUnit = model.TaxationUnit,
            TransactionArticleName = model.TransactionArticleName,
            UpdatedAt = model.UpdatedAt,
            ValueAssessmentMethodCode = model.ValueAssessmentMethodCode,
            VehicleOn = model.VehicleOn,
            WarrantyExemptionAuthorizationNumber = model.WarrantyExemptionAuthorizationNumber
        };
    }

    public static ArticleOfTheDetailedDeclarationCustomsDbModel ToModel(
        this ArticleOfTheDetailedDeclarationCustomsUpdateInput updateDto,
        ArticleOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        var articleOfTheDetailedDeclarationCustoms =
            new ArticleOfTheDetailedDeclarationCustomsDbModel
            {
                Id = uniqueId.Id,
                ApcCode = updateDto.ApcCode,
                ArticleName = updateDto.ArticleName,
                ArticleNumber = updateDto.ArticleNumber,
                ArticlePackageUnitCode = updateDto.ArticlePackageUnitCode,
                BrandName = updateDto.BrandName,
                CountryOfOriginCode = updateDto.CountryOfOriginCode,
                DateAndTimeOfFinalModification = updateDto.DateAndTimeOfFinalModification,
                DateAndTimeOfFirstRegistration = updateDto.DateAndTimeOfFirstRegistration,
                DeletionOn = updateDto.DeletionOn,
                EndDateOfApcApproval = updateDto.EndDateOfApcApproval,
                FinalModifierSId = updateDto.FinalModifierSId,
                FirstRecorderSId = updateDto.FirstRecorderSId,
                GrossWeightOfTheArticle = updateDto.GrossWeightOfTheArticle,
                Key = updateDto.Key,
                ManagementAndMonitoringClearanceExpiryPeriod =
                    updateDto.ManagementAndMonitoringClearanceExpiryPeriod,
                ManagementOfShCodeExtractCodes = updateDto.ManagementOfShCodeExtractCodes,
                NetWeightOfTheArticle = updateDto.NetWeightOfTheArticle,
                NewAndUsedProductCode = updateDto.NewAndUsedProductCode,
                NumberOfArticlePackages = updateDto.NumberOfArticlePackages,
                OilTankNumber = updateDto.OilTankNumber,
                ParcelDescription = updateDto.ParcelDescription,
                ParcelShippingMarkNumber = updateDto.ParcelShippingMarkNumber,
                PartialClearanceTypeCode = updateDto.PartialClearanceTypeCode,
                PreferentialCode = updateDto.PreferentialCode,
                PreviousArticleNumber = updateDto.PreviousArticleNumber,
                PreviousDetailedDeclarationDate = updateDto.PreviousDetailedDeclarationDate,
                PreviousDetailedDeclarationNumber = updateDto.PreviousDetailedDeclarationNumber,
                ProhibitedProductCode = updateDto.ProhibitedProductCode,
                Quantity = updateDto.Quantity,
                QuantityUnitCode = updateDto.QuantityUnitCode,
                QuotaAuthorizationNumber = updateDto.QuotaAuthorizationNumber,
                RectificationFrequency = updateDto.RectificationFrequency,
                ReferenceNumber = updateDto.ReferenceNumber,
                RequestRegimeNumber = updateDto.RequestRegimeNumber,
                RtcDecisionAuthorizationNumber = updateDto.RtcDecisionAuthorizationNumber,
                ShCode = updateDto.ShCode,
                SpecificCodeForClassificationOfGoods =
                    updateDto.SpecificCodeForClassificationOfGoods,
                StartDateOfApcApproval = updateDto.StartDateOfApcApproval,
                StatisticalValue = updateDto.StatisticalValue,
                SuperiorArticleNumber = updateDto.SuperiorArticleNumber,
                TaxationQuantity = updateDto.TaxationQuantity,
                TaxationUnit = updateDto.TaxationUnit,
                TransactionArticleName = updateDto.TransactionArticleName,
                ValueAssessmentMethodCode = updateDto.ValueAssessmentMethodCode,
                VehicleOn = updateDto.VehicleOn,
                WarrantyExemptionAuthorizationNumber =
                    updateDto.WarrantyExemptionAuthorizationNumber
            };

        if (updateDto.CreatedAt != null) articleOfTheDetailedDeclarationCustoms.CreatedAt = updateDto.CreatedAt.Value;
        if (updateDto.UpdatedAt != null) articleOfTheDetailedDeclarationCustoms.UpdatedAt = updateDto.UpdatedAt.Value;

        return articleOfTheDetailedDeclarationCustoms;
    }
}
