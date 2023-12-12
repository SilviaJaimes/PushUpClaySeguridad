using Dominio.Entities;

namespace Dominio.Interfaces;

public interface IContrato : IGenericRepository<Contrato>
{
    //Consulta 7
    Task<IEnumerable<Object>> ContratosActivos();
    Task<(int totalRegistros, IEnumerable<Object> registros)> ContratosActivosPaginated(int pageIndex, int pageSize, string search = null);
}