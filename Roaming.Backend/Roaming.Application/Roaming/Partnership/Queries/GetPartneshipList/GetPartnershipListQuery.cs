using MediatR;
using System;

namespace Roaming.Application.Roaming.Partnerships.Queries.GetPartnershipList
{
    public class GetPartnershipListQuery : IRequest<PartnershipListVm>
    {
        public Guid UserId { get; set; }
    }
}
