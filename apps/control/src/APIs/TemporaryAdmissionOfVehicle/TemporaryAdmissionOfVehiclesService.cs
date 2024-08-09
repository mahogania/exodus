using Clre.Infrastructure;

namespace Clre.APIs;

public class TemporaryAdmissionOfVehiclesService : TemporaryAdmissionOfVehiclesServiceBase
{
    public TemporaryAdmissionOfVehiclesService(ClreDbContext context)
        : base(context) { }
}
