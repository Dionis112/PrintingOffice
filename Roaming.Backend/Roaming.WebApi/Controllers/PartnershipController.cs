using AutoMapper;
using Microsoft.AspNetCore.Components;

namespace Roaming.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class PartnershipController : BaseController
    {
        private readonly IMapper _mapper;

        public PartnershipController(IMapper mapper) => _mapper = mapper;
    }
}
