using Control.Infrastructure;

namespace Control.APIs;

public class MaterialsAtWithReexportationInTheStatesService
    : MaterialsAtWithReexportationInTheStatesServiceBase
{
    public MaterialsAtWithReexportationInTheStatesService(ControlDbContext context)
        : base(context) { }
}
