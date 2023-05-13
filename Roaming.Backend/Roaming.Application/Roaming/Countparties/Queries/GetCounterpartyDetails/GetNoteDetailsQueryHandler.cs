using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Roaming.Application.Common.Exceptions;
using Roaming.Application.Interfaces;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Countparties.Queries.GetCounterpartyDetails
{
    public class GetCounterpartyDetailsQueryHandler : IRequestHandler<GetCounterpartyDetailsQuery, CounterpartyDetailsVm>
    {

        private readonly IRoamingDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetCounterpartyDetailsQueryHandler(IRoamingDbContext dbContext, IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);


        public async Task<CounterpartyDetailsVm> Handle(GetCounterpartyDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext
                                    .Counterparties
                                    .SingleOrDefaultAsync(s =>
                                    s.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Document), request.Id);
            }

            return _mapper.Map<CounterpartyDetailsVm>(entity);
        }
    }
}

