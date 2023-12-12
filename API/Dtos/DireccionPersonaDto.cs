using Dominio.Entities;

namespace API.Dtos;

public class DireccionPersonaDto : BaseEntity
{
    public string Direccion { get; set; }
    public int IdPersonaFk { get; set; }
    public PersonaDto Persona { get; set; }
    public int IdTipoDireccionFk { get; set; }
    public TipoDireccionDto TipoDireccion { get; set; }
}