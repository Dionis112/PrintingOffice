using MediatR;
using Microsoft.EntityFrameworkCore;
using Roaming.Application.Common.Exceptions;
using Roaming.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Countparties.Commands.DeleteCounterparty
{
    public class DeleteCounterpartyCommandHandler : IRequestHandler<DeleteCounterpartyCommand>
    {
        private readonly IRoamingDbContext _dbContext;

        public DeleteCounterpartyCommandHandler(IRoamingDbContext dbContext) => _dbContext = dbContext;

        public async Task<Unit> Handle(DeleteCounterpartyCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Counterparties.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (entity == null || entity.Id != request.Id)
            {
                throw new NotFoundException(nameof(Countparties), request.Id);
            }

            _dbContext.Counterparties.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
