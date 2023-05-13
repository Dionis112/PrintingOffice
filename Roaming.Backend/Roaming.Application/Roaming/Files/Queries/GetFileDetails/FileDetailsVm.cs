using AutoMapper;
using Roaming.Application.Common.Mappings;
using Roaming.Domain;
using System;

namespace Roaming.Application.Roaming.Files.Queries.GetFileDetails
{
    public class FileDetailsVm : IMapWith<File>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public string Type { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<File, FileDetailsVm>()
                .ForMember(docDto => docDto.Id,
                    opt => opt.MapFrom(doc => doc.Id))
                .ForMember(docDto => docDto.Name,
                    opt => opt.MapFrom(doc => doc.Name))
                .ForMember(docDto => docDto.Data,
                    opt => opt.MapFrom(doc => doc.Data))
                .ForMember(docDto => docDto.Type,
                    opt => opt.MapFrom(doc => doc.Type))
                .ForMember(docDto => docDto.CreationDate,
                    opt => opt.MapFrom(doc => doc.CreationDate))
                .ForMember(docDto => docDto.UpdateDate,
                    opt => opt.MapFrom(doc => doc.UpdateDate));
        }

    }
}
