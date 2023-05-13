using MediatR;
using System;

namespace Roaming.Application.Roaming.Countparties.Commands.DeleteCounterparty
{
    public class DeleteCounterpartyCommand : IRequest
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
    }
}
