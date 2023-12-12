using Dominio.Entities;

namespace API.Dtos;

public class ContactoPersonaDto : BaseEntity
{
    public string Descripcion { get; set; }
    public int IdPersonaFk { get; set; }
    public PersonaDto Persona { get; set; }
    public int IdTipoContactoFk { get; set; }
    public TipoContactoDto TipoContacto { get; set; }
}