using Dominio.Entities;

namespace API.Dtos;

public class ProgramacionDto : BaseEntity
{
    public int IdContratoFk { get; set; }
    public ContratoDto Contrato { get; set; }
    public int IdTurnoFk { get; set; }
    public TurnoDto Turno { get; set; }
    public int IdEmpleadoFk { get; set; }
    public PersonaDto Empleado { get; set; }  
}