using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Roaming.Application.Common.Exceptions;
using Roaming.Application.Interfaces;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Files.Queries.GetFileDetails
{
    public class GetFileDetailsQueryHandler : IRequestHandler<GetFileDetailsQuery, FileDetailsVm>
    {

        private readonly IRoamingDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetFileDetailsQueryHandler(IRoamingDbContext dbContext, IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);


        public async Task<FileDetailsVm> Handle(GetFileDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext
                                    .Files
                                    .SingleOrDefaultAsync(s =>
                                    s.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Document), request.Id);
            }

            return _mapper.Map<FileDetailsVm>(entity);
        }
    }
}

