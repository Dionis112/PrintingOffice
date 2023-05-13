using MediatR;
using Roaming.Application.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;
using Roaming.Domain;

namespace Roaming.Application.Roaming.Partnerships.Commands.CreatePartnership
{
    public class CreatePartnershipCommandHandler : IRequestHandler<CreatePartnershipCommand, int>
    {
        private readonly IRoamingDbContext _dbContext;

        public CreatePartnershipCommandHandler(IRoamingDbContext dbContext) => _dbContext = dbContext;

        public async Task<int> Handle(CreatePartnershipCommand request, CancellationToken cancellationToken)
        {
            var partnership = new Partnership
            {
                CounterpartyFirstId = request.CounterpartyFirstId,
                CounterpartySecondId = request.CounterpartySecondId,
                Status = request.Status,
                CreationDate = DateTime.Now,
                UpdateDate = null,
            };

            await _dbContext.Partnerships.AddAsync(partnership, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return partnership.Id;
        }
    }
}
