using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class ImportCarnetControlsServiceBase : IImportCarnetControlsService
{
    protected readonly ControlDbContext _context;

    public ImportCarnetControlsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Import Carnet Control
    /// </summary>
    public async Task<ImportCarnetControl> CreateImportCarnetControl(
        ImportCarnetControlCreateInput createDto
    )
    {
        var importCarnetControl = new ImportCarnetControlDbModel
        {
            AttachmentFileId = createDto.AttachmentFileId,
            AuthorizationDate = createDto.AuthorizationDate,
            CarnetNumber = createDto.CarnetNumber,
            CarnetTypeCode = createDto.CarnetTypeCode,
            CreatedAt = createDto.CreatedAt,
            DeletedOn = createDto.DeletedOn,
            FirstRecordDateAndTime = createDto.FirstRecordDateAndTime,
            FirstRecorderId = createDto.FirstRecorderId,
            LastModificationDateAndTime = createDto.LastModificationDateAndTime,
            LastModifierId = createDto.LastModifierId,
            ManagementNumberOfCarnet = createDto.ManagementNumberOfCarnet,
            OtherContents = createDto.OtherContents,
            ProcessingStatusCode = createDto.ProcessingStatusCode,
            ReExportationDate = createDto.ReExportationDate,
            ReferenceNo = createDto.ReferenceNo,
            TemporarilyImportedArticles = createDto.TemporarilyImportedArticles,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            importCarnetControl.Id = createDto.Id;
        }

        _context.ImportCarnetControls.Add(importCarnetControl);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<ImportCarnetControlDbModel>(importCarnetControl.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Import Carnet Control
    /// </summary>
    public async Task DeleteImportCarnetControl(ImportCarnetControlWhereUniqueInput uniqueId)
    {
        var importCarnetControl = await _context.ImportCarnetControls.FindAsync(uniqueId.Id);
        if (importCarnetControl == null)
        {
            throw new NotFoundException();
        }

        _context.ImportCarnetControls.Remove(importCarnetControl);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Import Carnet Controls
    /// </summary>
    public async Task<List<ImportCarnetControl>> ImportCarnetControls(
        ImportCarnetControlFindManyArgs findManyArgs
    )
    {
        var importCarnetControls = await _context
            .ImportCarnetControls.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return importCarnetControls.ConvertAll(importCarnetControl => importCarnetControl.ToDto());
    }

    /// <summary>
    /// Meta data about Import Carnet Control records
    /// </summary>
    public async Task<MetadataDto> ImportCarnetControlsMeta(
        ImportCarnetControlFindManyArgs findManyArgs
    )
    {
        var count = await _context.ImportCarnetControls.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Import Carnet Control
    /// </summary>
    public async Task<ImportCarnetControl> ImportCarnetControl(
        ImportCarnetControlWhereUniqueInput uniqueId
    )
    {
        var importCarnetControls = await this.ImportCarnetControls(
            new ImportCarnetControlFindManyArgs
            {
                Where = new ImportCarnetControlWhereInput { Id = uniqueId.Id }
            }
        );
        var importCarnetControl = importCarnetControls.FirstOrDefault();
        if (importCarnetControl == null)
        {
            throw new NotFoundException();
        }

        return importCarnetControl;
    }

    /// <summary>
    /// Update one Import Carnet Control
    /// </summary>
    public async Task UpdateImportCarnetControl(
        ImportCarnetControlWhereUniqueInput uniqueId,
        ImportCarnetControlUpdateInput updateDto
    )
    {
        var importCarnetControl = updateDto.ToModel(uniqueId);

        _context.Entry(importCarnetControl).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.ImportCarnetControls.Any(e => e.Id == importCarnetControl.Id))
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
