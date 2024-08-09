using Evaluation.APIs;
using Evaluation.APIs.Common;
using Evaluation.APIs.Dtos;
using Evaluation.APIs.Errors;
using Evaluation.APIs.Extensions;
using Evaluation.Infrastructure;
using Evaluation.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Evaluation.APIs;

public abstract class RequestsServiceBase : IRequestsService
{
    protected readonly EvaluationDbContext _context;

    public RequestsServiceBase(EvaluationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Request
    /// </summary>
    public async Task<Request> CreateRequest(RequestCreateInput createDto)
    {
        var request = new RequestDbModel
        {
            AdresseDeLEntreprise = createDto.AdresseDeLEntreprise,
            CreatedAt = createDto.CreatedAt,
            DNominationCommerciale = createDto.DNominationCommerciale,
            DateEtHeureDeModificationFinale = createDto.DateEtHeureDeModificationFinale,
            DateEtHeureDePremierEnregistrement = createDto.DateEtHeureDePremierEnregistrement,
            EmailDeLOpRateur = createDto.EmailDeLOpRateur,
            IdDuFichierJoint = createDto.IdDuFichierJoint,
            IdDuModificateurFinal = createDto.IdDuModificateurFinal,
            IdDuPremierEnregistrant = createDto.IdDuPremierEnregistrant,
            MarqueDeLArticle = createDto.MarqueDeLArticle,
            NAlerte = createDto.NAlerte,
            NDeTlPhonePortableDeLOpRateur = createDto.NDeTlPhonePortableDeLOpRateur,
            NFaxDeLOpRateur = createDto.NFaxDeLOpRateur,
            NTlPhoneDeLOpRateur = createDto.NTlPhoneDeLOpRateur,
            NiuDeLEntreprise = createDto.NiuDeLEntreprise,
            NomDeLEntreprise = createDto.NomDeLEntreprise,
            Remarque = createDto.Remarque,
            SuppressionOn = createDto.SuppressionOn,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            request.Id = createDto.Id;
        }

        _context.Requests.Add(request);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<RequestDbModel>(request.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Request
    /// </summary>
    public async Task DeleteRequest(RequestWhereUniqueInput uniqueId)
    {
        var request = await _context.Requests.FindAsync(uniqueId.Id);
        if (request == null)
        {
            throw new NotFoundException();
        }

        _context.Requests.Remove(request);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Requests
    /// </summary>
    public async Task<List<Request>> Requests(RequestFindManyArgs findManyArgs)
    {
        var requests = await _context
            .Requests.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return requests.ConvertAll(request => request.ToDto());
    }

    /// <summary>
    /// Meta data about Request records
    /// </summary>
    public async Task<MetadataDto> RequestsMeta(RequestFindManyArgs findManyArgs)
    {
        var count = await _context.Requests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Request
    /// </summary>
    public async Task<Request> Request(RequestWhereUniqueInput uniqueId)
    {
        var requests = await this.Requests(
            new RequestFindManyArgs { Where = new RequestWhereInput { Id = uniqueId.Id } }
        );
        var request = requests.FirstOrDefault();
        if (request == null)
        {
            throw new NotFoundException();
        }

        return request;
    }

    /// <summary>
    /// Update one Request
    /// </summary>
    public async Task UpdateRequest(RequestWhereUniqueInput uniqueId, RequestUpdateInput updateDto)
    {
        var request = updateDto.ToModel(uniqueId);

        _context.Entry(request).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Requests.Any(e => e.Id == request.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }
}
