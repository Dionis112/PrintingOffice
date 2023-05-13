using MediatR;
using Roaming.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roaming.Application.Countparties.Commands.CreateCounterparty
{
    public class CreateCounterpartyCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public ICollection<Partnership> Partnerships { get; set; }

        public CreateCounterpartyCommand()
        {
            Partnerships = new List<Partnership>();
        }

    }
}
