using MediatR;
using Microsoft.EntityFrameworkCore;
using Roaming.Application.Common.Exceptions;
using Roaming.Application.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Partnerships.Commands.UpdatePartnership
{
    public class UpdatePartnershipCommandHandler : IRequest<UpdatePartnershipCommand>
    {
        private readonly IRoamingDbContext _dbContext;

        public UpdatePartnershipCommandHandler(IRoamingDbContext dbContext) => _dbContext = dbContext;

        public async Task<Unit> Handle(UpdatePartnershipCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Partnerships.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Partnerships), request.Id);
            }

            entity.UpdateDate = DateTime.Now;
            entity.CounterpartyFirstId = request.CounterpartyFirstId;
            entity.CounterpartyFirstId = request.CounterpartySecondId;
            entity.Status = request.Status;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
