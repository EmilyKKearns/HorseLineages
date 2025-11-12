using AutoMapper;
using Domain;

namespace Application.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Horse, Horse>();
        CreateMap<Race, Race>();
        CreateMap<HorseSnapshot, HorseSnapshot>();
    }
}