using MediatR;

namespace Roaming.Application.Roaming.Files.Queries.GetFileDetails
{
    public class GetFileDetailsQuery : IRequest<FileDetailsVm>
    {
        public int Id { get; set; }
    }
}
