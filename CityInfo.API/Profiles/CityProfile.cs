using AutoMapper;
using CityInfo.API.Model;

namespace CityInfo.API.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<Entities.City, Model.CityWithoutPointsOfInterestDto>();
            CreateMap<Entities.City, Model.CityDto>();
        }
    }
}
