using MediatR;
using System;

namespace Roaming.Application.Roaming.Partnerships.Commands.UpdatePartnership
{
    public class UpdatePartnershipCommand : IRequest
    {
        public int Id { get; set; }
        public Guid CounterpartyFirstId { get; set; }
        public Guid CounterpartySecondId { get; set; }
        public string Status { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
