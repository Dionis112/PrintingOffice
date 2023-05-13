using AutoMapper;
using Roaming.Application.Common.Mappings;
using Roaming.Domain;
using System;

namespace Roaming.Application.Roaming.Countparties.Queries.GetCounterpartyDetails
{
    public class CounterpartyDetailsVm : IMapWith<Counterparty>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime CreationDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Counterparty, CounterpartyDetailsVm>()
                .ForMember(docDto => docDto.Id,
                    opt => opt.MapFrom(doc => doc.Id))
                .ForMember(docDto => docDto.UserId,
                    opt => opt.MapFrom(doc => doc.UserId))
                .ForMember(docDto => docDto.UpdateDate,
                    opt => opt.MapFrom(doc => doc.UpdateDate))
                .ForMember(docDto => docDto.CreationDate,
                    opt => opt.MapFrom(doc => doc.CreationDate));
        }

    }
}
