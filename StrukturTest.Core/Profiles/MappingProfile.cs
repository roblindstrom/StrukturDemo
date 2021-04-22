
using AutoMapper;
using StrukturTest.Core.Features.ModelName.Commands.CreateModel;
using StrukturTest.Domain.Models;

namespace StrukturTest.Core.Profiles
{
    public class MappingProfile : Profile
    {
        //Här är automapper configuration:

        //CreateMap<FrånModel, TillModel>();
        // Så en riktig hade sett ut såhär:

        public MappingProfile()
        {
            // Från Model, till CreateModelResponse
            CreateMap<Model, CreateModelResponse>();

        }
        

    }
}
