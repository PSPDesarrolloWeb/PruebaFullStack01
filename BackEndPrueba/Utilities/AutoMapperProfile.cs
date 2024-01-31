using AutoMapper;
using BackEndPrueba.DTOs;
using BackEndPrueba.Models;
using System.Globalization;

namespace BackEndPrueba.Utilities
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Departamento
            CreateMap<Departamento, DepartamentoDTO>().ReverseMap();
            #endregion

            #region User
            CreateMap<User, UserDTO>()
                .ForMember(destino =>
                destino.NombreDepartamento,
                opt => opt.MapFrom(origen => origen.IdDepartamentoUsNavigation.NombreDep)
                )
                .ForMember(destino =>
                destino.NombreCargo,
                opt => opt.MapFrom(origen => origen.IdCargoUsNavigation.NombreCg)
                );
            CreateMap<UserDTO, User>()
                .ForMember(destino =>
                destino.IdDepartamentoUsNavigation,
                opt => opt.Ignore())
                .ForMember(destino =>
                destino.IdCargoUsNavigation,
                opt => opt.Ignore()
                );
            #endregion
        }
    }
}
