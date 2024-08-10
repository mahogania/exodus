using Control.Infrastructure;

namespace Control.APIs;

public class TemporaryAdmissionOfVehiclesService : TemporaryAdmissionOfVehiclesServiceBase
{
    public TemporaryAdmissionOfVehiclesService(ControlDbContext context)
        : base(context)
    {
    }
}
