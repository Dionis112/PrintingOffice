using MediatR;
using System;

namespace Roaming.Application.Roaming.Documents.Queries.GetDocumentDetails
{
    public class GetDocumentDetailsQuery : IRequest<DocumentDetailsVm>
    {
        public Guid Id { get; set; }
    }
}
