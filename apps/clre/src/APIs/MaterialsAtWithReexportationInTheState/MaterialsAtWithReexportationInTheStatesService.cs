using Clre.Infrastructure;

namespace Clre.APIs;

public class MaterialsAtWithReexportationInTheStatesService
    : MaterialsAtWithReexportationInTheStatesServiceBase
{
    public MaterialsAtWithReexportationInTheStatesService(ClreDbContext context)
        : base(context) { }
}
