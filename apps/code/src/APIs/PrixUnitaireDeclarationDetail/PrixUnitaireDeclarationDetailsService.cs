using Code.Infrastructure;

namespace Code.APIs;

public class PrixUnitaireDeclarationDetailsService : PrixUnitaireDeclarationDetailsServiceBase
{
    public PrixUnitaireDeclarationDetailsService(CodeDbContext context)
        : base(context) { }
}
