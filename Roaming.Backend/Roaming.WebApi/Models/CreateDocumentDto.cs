using AutoMapper;
using Roaming.Application.Common.Mappings;
using Roaming.Application.Roaming.Documents.Commands.CreateDocument;
using System;
using System.Collections.Generic;

namespace Roaming.WebApi.Models
{
    public class CreateDocumentDto : IMapWith<CreateDocumentCommand>
    {
        public Guid SenderId { get; set; }
        public Guid RecipientId { get; set; }
        public string Type { get; set; }
        public List<CreateFileDto> Files { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateDocumentDto, CreateDocumentCommand>()
                .ForMember(noteCommand => noteCommand.Type,
                opt => opt.MapFrom(noteDto => noteDto.Type))
                .ForMember(noteCommand => noteCommand.SenderId,
                opt => opt.MapFrom(noteDto => noteDto.SenderId))
                .ForMember(noteCommand => noteCommand.RecipientId,
                opt => opt.MapFrom(noteDto => noteDto.RecipientId));
        }
    }
}
