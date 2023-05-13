using MediatR;

namespace Roaming.Application.Roaming.Files.Commands.DeleteFile
{
    public class DeleteFileCommand : IRequest
    {
        public int Id { get; set; }
    }
}
