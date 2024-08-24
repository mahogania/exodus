using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Control.APIs.Extensions;
using Control.Infrastructure;
using Control.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Control.APIs;

public abstract class JointDocumentsServiceBase : IJointDocumentsService
{
    protected readonly ControlDbContext _context;

    public JointDocumentsServiceBase(ControlDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Create one Joint Document
    /// </summary>
    public async Task<JointDocument> CreateJointDocument(JointDocumentCreateInput createDto)
    {
        var jointDocument = new JointDocumentDbModel
        {
            CreatedAt = createDto.CreatedAt,
            UpdatedAt = createDto.UpdatedAt
        };

        if (createDto.Id != null)
        {
            jointDocument.Id = createDto.Id;
        }
        if (createDto.CommonDetailedDeclaration != null)
        {
            jointDocument.CommonDetailedDeclaration = await _context
                .CommonDetailedDeclarations.Where(commonDetailedDeclaration =>
                    createDto.CommonDetailedDeclaration.Id == commonDetailedDeclaration.Id
                )
                .FirstOrDefaultAsync();
        }

        _context.JointDocuments.Add(jointDocument);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<JointDocumentDbModel>(jointDocument.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }

    /// <summary>
    /// Delete one Joint Document
    /// </summary>
    public async Task DeleteJointDocument(JointDocumentWhereUniqueInput uniqueId)
    {
        var jointDocument = await _context.JointDocuments.FindAsync(uniqueId.Id);
        if (jointDocument == null)
        {
            throw new NotFoundException();
        }

        _context.JointDocuments.Remove(jointDocument);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Find many Joint Documents
    /// </summary>
    public async Task<List<JointDocument>> JointDocuments(JointDocumentFindManyArgs findManyArgs)
    {
        var jointDocuments = await _context
            .JointDocuments.Include(x => x.CommonDetailedDeclaration)
            .ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();
        return jointDocuments.ConvertAll(jointDocument => jointDocument.ToDto());
    }

    /// <summary>
    /// Meta data about Joint Document records
    /// </summary>
    public async Task<MetadataDto> JointDocumentsMeta(JointDocumentFindManyArgs findManyArgs)
    {
        var count = await _context.JointDocuments.ApplyWhere(findManyArgs.Where).CountAsync();

        return new MetadataDto { Count = count };
    }

    /// <summary>
    /// Get one Joint Document
    /// </summary>
    public async Task<JointDocument> JointDocument(JointDocumentWhereUniqueInput uniqueId)
    {
        var jointDocuments = await this.JointDocuments(
            new JointDocumentFindManyArgs
            {
                Where = new JointDocumentWhereInput { Id = uniqueId.Id }
            }
        );
        var jointDocument = jointDocuments.FirstOrDefault();
        if (jointDocument == null)
        {
            throw new NotFoundException();
        }

        return jointDocument;
    }

    /// <summary>
    /// Update one Joint Document
    /// </summary>
    public async Task UpdateJointDocument(
        JointDocumentWhereUniqueInput uniqueId,
        JointDocumentUpdateInput updateDto
    )
    {
        var jointDocument = updateDto.ToModel(uniqueId);

        _context.Entry(jointDocument).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.JointDocuments.Any(e => e.Id == jointDocument.Id))
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
    /// Get a COMMON DETAILED DECLARATION record for JOINT DOCUMENT OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    public async Task<CommonDetailedDeclaration> GetCommonDetailedDeclaration(
        JointDocumentWhereUniqueInput uniqueId
    )
    {
        var jointDocument = await _context
            .JointDocuments.Where(jointDocument => jointDocument.Id == uniqueId.Id)
            .Include(jointDocument => jointDocument.CommonDetailedDeclaration)
            .FirstOrDefaultAsync();
        if (jointDocument == null)
        {
            throw new NotFoundException();
        }
        return jointDocument.CommonDetailedDeclaration.ToDto();
    }
}
