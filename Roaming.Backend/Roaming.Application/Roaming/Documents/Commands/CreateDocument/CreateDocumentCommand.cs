using MediatR;
using System;

namespace Roaming.Application.Roaming.Documents.Commands.CreateDocument
{
    public class CreateDocumentCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid RecipientId { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
