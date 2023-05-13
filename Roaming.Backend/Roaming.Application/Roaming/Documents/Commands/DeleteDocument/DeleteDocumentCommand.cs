using MediatR;
using System;

namespace Roaming.Application.Roaming.Documents.Commands.DeleteDocument
{
    public class DeleteDocumentCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
