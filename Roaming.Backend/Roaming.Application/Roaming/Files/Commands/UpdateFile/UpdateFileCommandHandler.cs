using MediatR;
using Microsoft.EntityFrameworkCore;
using Roaming.Application.Common.Exceptions;
using Roaming.Application.Interfaces;
using Roaming.Application.Roaming.Files.Commands.UpdateFile;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Files.UpdateFile
{
    public class UpdateFileCommandHandler : IRequest<UpdateFileCommand>
    {
        private readonly IRoamingDbContext _dbContext;

        public UpdateFileCommandHandler(IRoamingDbContext dbContext) => _dbContext = dbContext;

        public async Task<Unit> Handle(UpdateFileCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Files.FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Files), request.Id);
            }

            entity.UpdateDate = DateTime.Now;
            entity.Name = request.Name;
            entity.Data = request.Data;
            entity.Type = request.Type;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
