using MediatR;
using System;

namespace Roaming.Application.Roaming.Files.Commands.UpdateFile
{
    public class UpdateFileCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public string Type { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
