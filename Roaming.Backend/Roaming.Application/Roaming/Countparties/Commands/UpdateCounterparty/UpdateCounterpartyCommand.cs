using MediatR;
using System;

namespace Roaming.Application.Roaming.Countparties.Commands.UpdateCounterparty
{
    public class UpdateCounterpartyCommand : IRequest
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
    }
}
