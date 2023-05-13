using MediatR;
using Microsoft.EntityFrameworkCore;
using Roaming.Application.Common.Exceptions;
using Roaming.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Partnerships.Commands.DeletePartnership
{
    public class DeletePartnershipCommandHandler : IRequestHandler<DeletePartnershipCommand>
    {
        private readonly IRoamingDbContext _dbContext;

        public DeletePartnershipCommandHandler(IRoamingDbContext dbContext) => _dbContext = dbContext;

        public async Task<Unit> Handle(DeletePartnershipCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Partnerships.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Partnerships), request.Id);
            }

            _dbContext.Partnerships.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
