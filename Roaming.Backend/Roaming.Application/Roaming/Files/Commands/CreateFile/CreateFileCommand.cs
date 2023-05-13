using MediatR;

namespace Roaming.Application.Roaming.Files.Commands.CreateFile
{
    public class CreateFileCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public byte[] Sign { get; set; }
        public string Type { get; set; }
    }
}
