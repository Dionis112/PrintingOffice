using MediatR;
using Microsoft.EntityFrameworkCore;
using Roaming.Application.Common.Exceptions;
using Roaming.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Documents.Commands.DeleteDocument
{
    public class DeleteDocumentCommandHandler : IRequestHandler<DeleteDocumentCommand>
    {
        private readonly IRoamingDbContext _dbContext;

        public DeleteDocumentCommandHandler(IRoamingDbContext dbContext) => _dbContext = dbContext;

        public async Task<Unit> Handle(DeleteDocumentCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Documents.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (entity == null || entity.Id != request.Id)
            {
                throw new NotFoundException(nameof(Documents), request.Id);
            }

            _dbContext.Documents.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
