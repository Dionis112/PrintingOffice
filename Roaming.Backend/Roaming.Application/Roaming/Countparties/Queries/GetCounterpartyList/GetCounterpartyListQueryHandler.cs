using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Roaming.Application.Common.Exceptions;
using Roaming.Application.Interfaces;
using Roaming.Domain;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Countparties.Queries.GetCounterpartyList
{
    public class GetCounterpartyListQueryHandler : IRequestHandler<GetCounterpartyListQuery, CounterpartyListVm>
    {
        private readonly IRoamingDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetCounterpartyListQueryHandler(IRoamingDbContext dbContext, IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);


        public async Task<CounterpartyListVm> Handle(GetCounterpartyListQuery request, CancellationToken cancellationToken)
        {
            var employeeId = request.UserId;

            Counterparty counterparty = await _dbContext.Counterparties.SingleOrDefaultAsync(s => s.UserId == employeeId);

            if (counterparty == null)
            {
                throw new NotFoundException(nameof(Counterparty), request.UserId);
            }

            var counterpartyQuery = await _dbContext.Counterparties
                    .Where(w => w.UserId == counterparty.UserId)
                    .ProjectTo<CounterpartyLookupDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

            return new CounterpartyListVm { Counterparties = counterpartyQuery };
        }
    }
}
