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

namespace Roaming.Application.Roaming.Documents.Queries.GetDocumentList
{
    public class GetDocumentListQueryHandler : IRequestHandler<GetDocumentListQuery, DocumentListVm>
    {
        private readonly IRoamingDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetDocumentListQueryHandler(IRoamingDbContext dbContext, IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);


        public async Task<DocumentListVm> Handle(GetDocumentListQuery request, CancellationToken cancellationToken)
        {
            var employeeId = request.UserId;

            Counterparty counterparty = await _dbContext.Counterparties.SingleOrDefaultAsync(s => s.UserId == employeeId);

            if (counterparty == null)
            {
                throw new NotFoundException(nameof(Counterparty), request.UserId);
            }

            var documentQuery = await _dbContext.Documents
                    .Where(w => w.SenderId == counterparty.Id || w.RecipientId == counterparty.Id)
                    .ProjectTo<DocumentLookupDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

            return new DocumentListVm { Documents = documentQuery };
        }
    }
}
