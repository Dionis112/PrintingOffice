using MediatR;
using Roaming.Application.Interfaces;
using Roaming.Domain;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Roaming.Application.Roaming.Documents.Commands.CreateDocument
{
    public class CreateDocumentCommandHandler : IRequestHandler<CreateDocumentCommand, Guid>
    {
        private readonly IRoamingDbContext _dbContext;

        public CreateDocumentCommandHandler(IRoamingDbContext dbContext) => _dbContext = dbContext;

        public async Task<Guid> Handle(CreateDocumentCommand request, CancellationToken cancellationToken)
        {
            var document = new Document
            {
                Id = request.Id,
                RecipientId = request.RecipientId,
                SenderId = request.SenderId,
                Type = request.Type,
            };

            await _dbContext.Documents.AddAsync(document, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return document.Id;
        }
    }
}
