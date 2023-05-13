using AutoMapper;
using Microsoft.AspNetCore.Components;

namespace Roaming.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class FileController : BaseController
    {
        private readonly IMapper _mapper;

        public FileController(IMapper mapper) => _mapper = mapper;
    }
}
