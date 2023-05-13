using AutoMapper;
using Roaming.Application.Common.Mappings;
using Roaming.Domain;
using System;

namespace Roaming.Application.Roaming.Documents.Queries.GetDocumentDetails
{
    public class DocumentDetailsVm : IMapWith<Document>
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid RecipientId { get; set; }
        public string Status { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Document, DocumentDetailsVm>()
                .ForMember(docDto => docDto.Id,
                    opt => opt.MapFrom(doc => doc.Id))
                .ForMember(docDto => docDto.SenderId,
                    opt => opt.MapFrom(doc => doc.SenderId))
                .ForMember(docDto => docDto.RecipientId,
                    opt => opt.MapFrom(doc => doc.RecipientId))
                .ForMember(docDto => docDto.Status,
                    opt => opt.MapFrom(doc => doc.Status));
        }

    }
}
