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

namespace Roaming.Application.Roaming.Files.Queries.GetFileList
{
    public class GetFileListQueryHandler : IRequestHandler<GetFileListQuery, FileListVm>
    {
        private readonly IRoamingDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetFileListQueryHandler(IRoamingDbContext dbContext, IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);


        public async Task<FileListVm> Handle(GetFileListQuery request, CancellationToken cancellationToken)
        {
            var documentId = request.DocumentId;

            var document = await _dbContext.Documents.SingleOrDefaultAsync(s => s.Id == documentId);

            if (document == null)
            {
                throw new NotFoundException(nameof(Counterparty), request.DocumentId);
            }

            var fileQuery = await _dbContext.Files
                    .Where(w => w.DocumentId == request.DocumentId)
                    .ProjectTo<FileLookupDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);

            return new FileListVm { Files = fileQuery };
        }
    }
}
