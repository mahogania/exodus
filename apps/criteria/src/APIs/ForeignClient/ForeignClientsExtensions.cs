using Criteria.APIs.Dtos;
using Criteria.Infrastructure.Models;

namespace Criteria.APIs.Extensions;

public static class ForeignClientsExtensions
{
    public static ForeignClient ToDto(this ForeignClientDbModel model)
    {
        return new ForeignClient
        {
            AddressOfForeignOperator = model.AddressOfForeignOperator,
            CityCodeOfForeignOperator = model.CityCodeOfForeignOperator,
            CompanyNameOfForeignOperator = model.CompanyNameOfForeignOperator,
            CountryCodeOfForeignOperator = model.CountryCodeOfForeignOperator,
            CreatedAt = model.CreatedAt,
            EmailOfForeignOperator = model.EmailOfForeignOperator,
            Id = model.Id,
            PhoneNumberOfForeignOperator = model.PhoneNumberOfForeignOperator,
            RepresentativeNameOfForeignOperator = model.RepresentativeNameOfForeignOperator,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static ForeignClientDbModel ToModel(
        this ForeignClientUpdateInput updateDto,
        ForeignClientWhereUniqueInput uniqueId
    )
    {
        var foreignClient = new ForeignClientDbModel
        {
            Id = uniqueId.Id,
            AddressOfForeignOperator = updateDto.AddressOfForeignOperator,
            CityCodeOfForeignOperator = updateDto.CityCodeOfForeignOperator,
            CompanyNameOfForeignOperator = updateDto.CompanyNameOfForeignOperator,
            CountryCodeOfForeignOperator = updateDto.CountryCodeOfForeignOperator,
            EmailOfForeignOperator = updateDto.EmailOfForeignOperator,
            PhoneNumberOfForeignOperator = updateDto.PhoneNumberOfForeignOperator,
            RepresentativeNameOfForeignOperator = updateDto.RepresentativeNameOfForeignOperator
        };

        if (updateDto.CreatedAt != null)
        {
            foreignClient.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            foreignClient.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return foreignClient;
    }
}
