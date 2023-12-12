using Dominio.Entities;

namespace API.Dtos;

public class PersonaDto : BaseEntity
{
    public string IdPersona { get; set; }
    public string Nombre { get; set; }
    public DateOnly FechaRegistro { get; set; }
    public int IdTipoPersonaFk { get; set; }
    public TipoPersonaDto TipoPersona { get; set; }
    public int IdCategoriaPersonaFk { get; set; }
    public CategoriaPersonaDto CategoriaPersona { get; set; }
    public int IdCiudadFk { get; set; }
    public CiudadDto Ciudad { get; set; }
}