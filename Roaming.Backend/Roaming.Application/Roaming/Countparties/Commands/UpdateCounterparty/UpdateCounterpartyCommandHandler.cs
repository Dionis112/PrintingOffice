using MediatR;
using Microsoft.EntityFrameworkCore;
using Roaming.Application.Common.Exceptions;
using Roaming.Application.Interfaces;
using Roaming.Domain;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Countparties.Commands.UpdateCounterparty
{
    public class UpdateCounterpartyCommandHandler : IRequest<UpdateCounterpartyCommand>
    {
        private readonly IRoamingDbContext _dbContext;

        public UpdateCounterpartyCommandHandler(IRoamingDbContext dbContext) => _dbContext = dbContext;

        public async Task<Unit> Handle(UpdateCounterpartyCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Counterparties.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (entity == null || entity.Id != request.Id)
            {
                throw new NotFoundException(nameof(Counterparty), request.Id);
            }

            entity.UpdateDate = DateTime.Now;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
