using MediatR;
using System;

namespace Roaming.Application.Roaming.Partnerships.Commands.CreatePartnership
{
    public class CreatePartnershipCommand : IRequest<int>
    {
        public int Id { get; set; }
        public Guid CounterpartyFirstId { get; set; }
        public Guid CounterpartySecondId { get; set; }
        public string Status { get; set; }
        public DateTime CreatingDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
