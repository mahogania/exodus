using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ImportCarnetRequestsServiceBase : IImportCarnetRequestsService
{
    protected readonly ControlDbContext _context;

    public ImportCarnetRequestsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Import Carnet Request
    /// </summary>
    public async Task<ImportCarnetRequest> CreateImportCarnetRequest(
        ImportCarnetRequestCreateInput createDto
    )
    {
        var importCarnetRequest = new ImportCarnetRequestDbModel
        {
            CarnetNumber = createDto.CarnetNumber,
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            ManagementNumberOfCarnet = createDto.ManagementNumberOfCarnet,
            ReferenceNo = createDto.ReferenceNo,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            importCarnetRequest.Id = createDto.Id;
        }
        if (createDto.CarnetRequest != null)
        {
            importCarnetRequest.CarnetRequest = await _context
                .CarnetRequests.Where(carnetRequest =>
                    createDto.CarnetRequest.Id == carnetRequest.Id
                )
                .FirstOrDefaultAsync();
        }

        if (createDto.ImportCarnetControl != null)
        {
            importCarnetRequest.ImportCarnetControl = await _context
                .ImportCarnetControls.Where(importCarnetControl =>
                    createDto.ImportCarnetControl.Id == importCarnetControl.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.ImportCarnetRequests.Add(importCarnetRequest);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ImportCarnetRequestDbModel>(importCarnetRequest.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Import Carnet Request
    /// </summary>
    public async Task DeleteImportCarnetRequest(ImportCarnetRequestWhereUniqueInput uniqueId)
    {
        var importCarnetRequest = await _context.ImportCarnetRequests.FindAsync(uniqueId.Id);
        if (importCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        _context.ImportCarnetRequests.Remove(importCarnetRequest);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Import Carnet Requests
    /// </summary>
    public async Task<List<ImportCarnetRequest>> ImportCarnetRequests(
        ImportCarnetRequestFindManyArgs findManyArgs
    )
    {
        var importCarnetRequests = await _context
            .ImportCarnetRequests.Include(x => x.CarnetRequest)
            .Include(x => x.ImportCarnetControl)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return importCarnetRequests.ConvertAll(importCarnetRequest => importCarnetRequest.ToDto());
    }

    /// <summary>
    /// Meta data about Import Carnet Request records
    /// </summary>
    public async Task<MetadataDto> ImportCarnetRequestsMeta(
        ImportCarnetRequestFindManyArgs findManyArgs
    )
    {
        var count = await _context.ImportCarnetRequests.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Import Carnet Request
    /// </summary>
    public async Task<ImportCarnetRequest> ImportCarnetRequest(
        ImportCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var importCarnetRequests = await this.ImportCarnetRequests(
            new ImportCarnetRequestFindManyArgs
            {
                Where = new ImportCarnetRequestWhereInput { Id = uniqueId.Id }
            }
        );
        var importCarnetRequest = importCarnetRequests.FirstOrDefault();
        if (importCarnetRequest == null)
        {
            throw new NotFoundException();
        }

        return importCarnetRequest;
    }

    /// <summary>
    /// Update one Import Carnet Request
    /// </summary>
    public async Task UpdateImportCarnetRequest(
        ImportCarnetRequestWhereUniqueInput uniqueId,
        ImportCarnetRequestUpdateInput updateDto
    )
    {
        var importCarnetRequest = updateDto.ToModel(uniqueId);

        _context.Entry(importCarnetRequest).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ImportCarnetRequests.Any(e => e.Id == importCarnetRequest.Id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }

    /// <summary>
    /// Get a Carnet Request record for Import Carnet Request
    /// </summary>
    public async Task<CarnetRequest> GetCarnetRequest(ImportCarnetRequestWhereUniqueInput uniqueId)
    {
        var importCarnetRequest = await _context
            .ImportCarnetRequests.Where(importCarnetRequest =>
                importCarnetRequest.Id == uniqueId.Id
            )
            .Include(importCarnetRequest => importCarnetRequest.CarnetRequest)
            .FirstOrDefaultAsync();
        if (importCarnetRequest == null)
        {
            throw new NotFoundException();
        }
        return importCarnetRequest.CarnetRequest.ToDto();
    }

    /// <summary>
    /// Get a Import Carnet Control record for Import Carnet Request
    /// </summary>
    public async Task<ImportCarnetControl> GetImportCarnetControl(
        ImportCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var importCarnetRequest = await _context
            .ImportCarnetRequests.Where(importCarnetRequest =>
                importCarnetRequest.Id == uniqueId.Id
            )
            .Include(importCarnetRequest => importCarnetRequest.ImportCarnetControl)
            .FirstOrDefaultAsync();
        if (importCarnetRequest == null)
        {
            throw new NotFoundException();
        }
        return importCarnetRequest.ImportCarnetControl.ToDto();
    }
}
