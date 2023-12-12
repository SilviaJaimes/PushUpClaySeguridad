using API.Dtos;
using AutoMapper;
using Dominio.Entities;

namespace API.profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Rol,RolDto>().ReverseMap();
        CreateMap<Usuario,UsuarioDto>().ReverseMap();
        CreateMap<CategoriaPersona, CategoriaPersonaDto>().ReverseMap();
        CreateMap<Ciudad,CiudadDto>().ReverseMap();
        CreateMap<ContactoPersona,ContactoPersonaDto>().ReverseMap();
        CreateMap<Contrato, ContratoDto>().ReverseMap();
        CreateMap<Departamento,DepartamentoDto>().ReverseMap();
        CreateMap<DireccionPersona,DireccionPersonaDto>().ReverseMap();
        CreateMap<Estado, EstadoDto>().ReverseMap();
        CreateMap<Pais,PaisDto>().ReverseMap();
        CreateMap<Persona,PersonaDto>().ReverseMap();
        CreateMap<Programacion,ProgramacionDto>().ReverseMap();
        CreateMap<TipoContacto, TipoContactoDto>().ReverseMap();
        CreateMap<TipoDireccion,TipoDireccionDto>().ReverseMap();
        CreateMap<TipoPersona,TipoPersonaDto>().ReverseMap();
        CreateMap<Turno, TurnoDto>().ReverseMap();
    }
}