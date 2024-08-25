using Code.Infrastructure;

namespace Code.APIs;

public class PaysPreferentielsService : PaysPreferentielsServiceBase
{
    public PaysPreferentielsService(CodeDbContext context)
        : base(context) { }
}
