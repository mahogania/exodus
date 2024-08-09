using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[ApiController()]
public class AccountingsController : AccountingsControllerBase
{
    public AccountingsController(IAccountingsService service)
        : base(service) { }
}
