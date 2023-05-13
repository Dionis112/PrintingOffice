using MediatR;
using System;

namespace Roaming.Application.Roaming.Documents.Queries.GetDocumentList
{
    public class GetDocumentListQuery : IRequest<DocumentListVm>
    {
        public Guid UserId { get; set; }
    }
}
