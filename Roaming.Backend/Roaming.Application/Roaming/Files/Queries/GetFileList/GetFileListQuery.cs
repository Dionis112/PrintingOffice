using MediatR;
using System;

namespace Roaming.Application.Roaming.Files.Queries.GetFileList
{
    public class GetFileListQuery : IRequest<FileListVm>
    {
        public Guid DocumentId { get; set; }
    }
}
