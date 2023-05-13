using AutoMapper;
using Roaming.Application.Common.Mappings;
using Roaming.Application.Roaming.Documents.Commands.UpdateDocument;
using System;

namespace Roaming.WebApi.Models
{
    public class UpdateDocumentDto : IMapWith<UpdateDocumentCommand>
    {
        public Guid Id { get; set; }
        public string Type { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateDocumentDto, UpdateDocumentCommand>()
                .ForMember(noteCommand => noteCommand.Id,
                opt => opt.MapFrom(noteDto => noteDto.Id))
                .ForMember(noteCommand => noteCommand.Status,
                opt => opt.MapFrom(noteDto => noteDto.Type));
        }
    }
}
