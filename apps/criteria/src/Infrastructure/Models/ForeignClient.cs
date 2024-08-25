using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Criteria.Infrastructure.Models;

[Table("ForeignClients")]
public class ForeignClientDbModel
{
    [StringLength(1000)]
    public string? AddressOfForeignOperator { get; set; }

    [StringLength(1000)]
    public string? CityCodeOfForeignOperator { get; set; }

    [StringLength(1000)]
    public string? CompanyNameOfForeignOperator { get; set; }

    [StringLength(1000)]
    public string? CountryCodeOfForeignOperator { get; set; }

    [Required()]
    public DateTime CreatedAt { get; set; }

    public string? EmailOfForeignOperator { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [StringLength(1000)]
    public string? PhoneNumberOfForeignOperator { get; set; }

    [StringLength(1000)]
    public string? RepresentativeNameOfForeignOperator { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
