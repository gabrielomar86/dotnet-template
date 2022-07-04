using AutoMapper;
using GuayaswestSample.core.dto;
using GuayaswestSample.core.entities;

namespace GuayaswestSample.core.extensiones
{
    public class GuayaswestSampleMappingProfile : Profile
    {
        public GuayaswestSampleMappingProfile()
        {
            CreateMap<GuayaswestSampleEntity, GuayaswestSampleDto>();
        }
    }
}
