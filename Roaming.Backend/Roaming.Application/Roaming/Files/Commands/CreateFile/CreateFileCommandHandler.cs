using MediatR;
using Roaming.Application.Interfaces;
using Roaming.Domain;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Files.Commands.CreateFile
{
    public class CreateFileCommandHandler : IRequestHandler<CreateFileCommand, int>
    {
        private readonly IRoamingDbContext _dbContext;

        public CreateFileCommandHandler(IRoamingDbContext dbContext) => _dbContext = dbContext;

        public async Task<int> Handle(CreateFileCommand request, CancellationToken cancellationToken)
        {
            var file = new File
            {
                Name = request.Name,
                CreationDate = DateTime.Now,
                Data = request.Data,
                Sign = request.Sign,
                Type = request.Type,
            };

            await _dbContext.Files.AddAsync(file, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return file.Id;
        }
    }
}
