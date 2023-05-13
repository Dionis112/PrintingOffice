using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Roaming.Application.Common.Exceptions;
using Roaming.Application.Interfaces;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Documents.Queries.GetDocumentDetails
{
    public class GetDocumentDetailsQueryHandler : IRequestHandler<GetDocumentDetailsQuery, DocumentDetailsVm>
    {

        private readonly IRoamingDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetDocumentDetailsQueryHandler(IRoamingDbContext dbContext, IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);


        public async Task<DocumentDetailsVm> Handle(GetDocumentDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext
                                    .Documents
                                    .SingleOrDefaultAsync(s =>
                                    s.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Document), request.Id);
            }

            return _mapper.Map<DocumentDetailsVm>(entity);
        }
    }
}

