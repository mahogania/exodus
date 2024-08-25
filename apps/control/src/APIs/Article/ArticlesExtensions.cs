using Control.APIs.Dtos;
using Control.Infrastructure.Models;

namespace Control.APIs.Extensions;

public static class ArticlesExtensions
{
    public static Article ToDto(this ArticleDbModel model)
    {
        return new Article
        {
            ApcCode = model.ApcCode,
            ArticleAssessments = model.ArticleAssessments?.Select(x => x.Id).ToList(),
            ArticleName = model.ArticleName,
            ArticleNumber = model.ArticleNumber,
            ArticlePackageUnitCode = model.ArticlePackageUnitCode,
            BrandName = model.BrandName,
            CommonDetailedDeclaration = model.CommonDetailedDeclarationId,
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
            Model = model.Model?.Select(x => x.Id).ToList(),
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
            RawMaterials = model.RawMaterials?.Select(x => x.Id).ToList(),
            RectificationFrequency = model.RectificationFrequency,
            ReferenceNumber = model.ReferenceNumber,
            RequestRegimeNumber = model.RequestRegimeNumber,
            RtcDecisionAuthorizationNumber = model.RtcDecisionAuthorizationNumber,
            SampleRequests = model.SampleRequests?.Select(x => x.Id).ToList(),
            ShCode = model.ShCode,
            SpecificCodeForClassificationOfGoods = model.SpecificCodeForClassificationOfGoods,
            StartDateOfApcApproval = model.StartDateOfApcApproval,
            StatisticalValue = model.StatisticalValue,
            SuperiorArticleNumber = model.SuperiorArticleNumber,
            Tax = model.TaxId,
            TaxationQuantity = model.TaxationQuantity,
            TaxationUnit = model.TaxationUnit,
            TransactionArticleName = model.TransactionArticleName,
            UpdatedAt = model.UpdatedAt,
            ValueAssessmentMethodCode = model.ValueAssessmentMethodCode,
            Vehicle = model.VehicleId,
            VehicleOn = model.VehicleOn,
            WarrantyExemptionAuthorizationNumber = model.WarrantyExemptionAuthorizationNumber,
        };
    }

    public static ArticleDbModel ToModel(
        this ArticleUpdateInput updateDto,
        ArticleWhereUniqueInput uniqueId
    )
    {
        var article = new ArticleDbModel
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
            SpecificCodeForClassificationOfGoods = updateDto.SpecificCodeForClassificationOfGoods,
            StartDateOfApcApproval = updateDto.StartDateOfApcApproval,
            StatisticalValue = updateDto.StatisticalValue,
            SuperiorArticleNumber = updateDto.SuperiorArticleNumber,
            TaxationQuantity = updateDto.TaxationQuantity,
            TaxationUnit = updateDto.TaxationUnit,
            TransactionArticleName = updateDto.TransactionArticleName,
            ValueAssessmentMethodCode = updateDto.ValueAssessmentMethodCode,
            VehicleOn = updateDto.VehicleOn,
            WarrantyExemptionAuthorizationNumber = updateDto.WarrantyExemptionAuthorizationNumber
        };

        if (updateDto.CommonDetailedDeclaration != null)
        {
            article.CommonDetailedDeclarationId = updateDto.CommonDetailedDeclaration;
        }
        if (updateDto.CreatedAt != null)
        {
            article.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.Tax != null)
        {
            article.TaxId = updateDto.Tax;
        }
        if (updateDto.UpdatedAt != null)
        {
            article.UpdatedAt = updateDto.UpdatedAt.Value;
        }
        if (updateDto.Vehicle != null)
        {
            article.VehicleId = updateDto.Vehicle;
        }

        return article;
    }
}
