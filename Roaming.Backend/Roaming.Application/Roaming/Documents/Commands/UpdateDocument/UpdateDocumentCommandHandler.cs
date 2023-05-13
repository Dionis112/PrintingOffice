using MediatR;
using Microsoft.EntityFrameworkCore;
using Roaming.Application.Common.Exceptions;
using Roaming.Application.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Documents.Commands.UpdateDocument
{
    public class UpdateDocumentCommandHandler : IRequest<UpdateDocumentCommand>
    {
        private readonly IRoamingDbContext _dbContext;

        public UpdateDocumentCommandHandler(IRoamingDbContext dbContext) => _dbContext = dbContext;

        public async Task<Unit> Handle(UpdateDocumentCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Documents.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (entity == null || entity.Id != request.Id)
            {
                throw new NotFoundException(nameof(Documents), request.Id);
            }

            entity.SenderId = request.SenderId;
            entity.RecipientId = request.RecipientId;
            entity.Status = request.Status;
            entity.UpdatedDate = DateTime.Now;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
