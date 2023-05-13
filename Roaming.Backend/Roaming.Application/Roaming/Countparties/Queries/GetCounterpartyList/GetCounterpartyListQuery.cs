using MediatR;
using System;

namespace Roaming.Application.Roaming.Countparties.Queries.GetCounterpartyList
{
    public class GetCounterpartyListQuery : IRequest<CounterpartyListVm>
    {
        public Guid UserId { get; set; }
    }
}
