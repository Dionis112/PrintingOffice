using MediatR;
using System;
using System.Collections.Generic;
using Roaming.Domain;

namespace Roaming.Application.Roaming.Countparties.Commands.CreateCounterparty
{
    public class CreateCounterpartyCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public List<Partnership> Partnerships { get; set; }

    }
}
