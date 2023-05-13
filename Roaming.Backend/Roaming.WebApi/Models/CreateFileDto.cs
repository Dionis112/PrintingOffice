using AutoMapper;
using Roaming.Application.Common.Mappings;
using Roaming.Application.Roaming.Files.Commands.CreateFile;

namespace Roaming.WebApi.Models
{
    public class CreateFileDto : IMapWith<CreateFileCommand>
    {
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public byte[] Sign { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateFileDto, CreateFileCommand>()
                .ForMember(fileCommand => fileCommand.Name,
                opt => opt.MapFrom(fileDto => fileDto.Name))
                .ForMember(fileCommand => fileCommand.Data,
                opt => opt.MapFrom(fileDto => fileDto.Data))
                .ForMember(fileCommand => fileCommand.Sign,
                opt => opt.MapFrom(fileDto => fileDto.Sign));
        }
    }
}
