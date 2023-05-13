using MediatR;

namespace Roaming.Application.Roaming.Partnerships.Commands.DeletePartnership
{
    public class DeletePartnershipCommand : IRequest
    {
        public int Id { get; set; }
    }
}
