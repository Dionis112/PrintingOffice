using MediatR;
using System;

namespace Roaming.Application.Roaming.Documents.Commands.UpdateDocument
{
    public class UpdateDocumentCommand : IRequest
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid RecipientId { get; set; }
        public string Status { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
