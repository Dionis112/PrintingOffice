using MediatR;
using Roaming.Application.Interfaces;
using Roaming.Domain;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Countparties.Commands.CreateCounterparty
{
    public class CreateCounterpartyCommandHandler : IRequestHandler<CreateCounterpartyCommand, Guid>
    {
        private readonly IRoamingDbContext _dbContext;

        public CreateCounterpartyCommandHandler(IRoamingDbContext dbContext) => _dbContext = dbContext;

        public async Task<Guid> Handle(CreateCounterpartyCommand request, CancellationToken cancellationToken)
        {
            var counterparty = new Counterparty
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId,
                CreationDate = DateTime.Now,
            };

            await _dbContext.Counterparties.AddAsync(counterparty, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return counterparty.Id;
        }
    }
}
