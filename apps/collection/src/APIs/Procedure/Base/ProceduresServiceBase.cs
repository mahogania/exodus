using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Collection.APIs.Extensions;
using Collection.Infrastructure;
using Collection.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Collection.APIs;

public abstract class ProceduresServiceBase : IProceduresService
{
    protected readonly CollectionDbContext _context;

    public ProceduresServiceBase(CollectionDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one PROCEDURE
    /// </summary>
    public async Task<Procedure> CreateProcedure(ProcedureCreateInput createDto)
    {
        var procedure = new ProcedureDbModel
        {
            AttachedFileId = createDto.AttachedFileId,
            CreatedAt = createDto.CreatedAt,
            DeletionFlag = createDto.DeletionFlag,
            EtcYOrN = createDto.EtcYOrN,
            FinalModificationDateAndTime = createDto.FinalModificationDateAndTime,
            FinalModifierId = createDto.FinalModifierId,
            FirstRegistrantId = createDto.FirstRegistrantId,
            FirstRegistrationDateAndTime = createDto.FirstRegistrationDateAndTime,
            HandoverDate = createDto.HandoverDate,
            HandoverNoteNumber = createDto.HandoverNoteNumber,
            IncomingReceiverId = createDto.IncomingReceiverId,
            OfficeCode = createDto.OfficeCode,
            OtherContents = createDto.OtherContents,
            OutgoingReceiverId = createDto.OutgoingReceiverId,
            PhysicalInventoryOfEquipmentAndFurnitureYOrN =
                createDto.PhysicalInventoryOfEquipmentAndFurnitureYOrN,
            ServiceCode = createDto.ServiceCode,
            StateOfCashYOrN = createDto.StateOfCashYOrN,
            StateOfExpenseCertificatesStoppedYOrN = createDto.StateOfExpenseCertificatesStoppedYOrN,
            StateOfReceiptsStoppedYOrN = createDto.StateOfReceiptsStoppedYOrN,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            procedure.Id = createDto.Id;
        }

        _context.Procedures.Add(procedure);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ProcedureDbModel>(procedure.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one PROCEDURE
    /// </summary>
    public async Task DeleteProcedure(ProcedureWhereUniqueInput uniqueId)
    {
        var procedure = await _context.Procedures.FindAsync(uniqueId.Id);
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        _context.Procedures.Remove(procedure);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many PROCEDURES
    /// </summary>
    public async Task<List<Procedure>> Procedures(ProcedureFindManyArgs findManyArgs)
    {
        var procedures = await _context
            .Procedures.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return procedures.ConvertAll(procedure => procedure.ToDto());
    }

    /// <summary>
    /// Meta data about PROCEDURE records
    /// </summary>
    public async Task<MetadataDto> ProceduresMeta(ProcedureFindManyArgs findManyArgs)
    {
        var count = await _context.Procedures.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one PROCEDURE
    /// </summary>
    public async Task<Procedure> Procedure(ProcedureWhereUniqueInput uniqueId)
    {
        var procedures = await this.Procedures(
            new ProcedureFindManyArgs { Where = new ProcedureWhereInput { Id = uniqueId.Id } }
        );
        var procedure = procedures.FirstOrDefault();
        if (procedure == null)
        {
            throw new NotFoundException();
        }

        return procedure;
    }

    /// <summary>
    /// Update one PROCEDURE
    /// </summary>
    public async Task UpdateProcedure(
        ProcedureWhereUniqueInput uniqueId,
        ProcedureUpdateInput updateDto
    )
    {
        var procedure = updateDto.ToModel(uniqueId);

        _context.Entry(procedure).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Procedures.Any(e => e.Id == procedure.Id))
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
