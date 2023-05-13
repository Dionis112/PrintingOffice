using MediatR;
using System;

namespace Roaming.Application.Roaming.Countparties.Queries.GetCounterpartyDetails
{
    public class GetCounterpartyDetailsQuery : IRequest<CounterpartyDetailsVm>
    {
        public Guid Id { get; set; }
    }
}
