using DPM205XXX_QLHS.Models;
using Infrastructure.Entities;
using AutoMapper;
namespace DPM205XXX_QLHS
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<HocSinh, HocSinhViewModel>();
            CreateMap<HocSinhViewModel, HocSinh>();
        }
    }
}
