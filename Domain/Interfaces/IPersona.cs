using Dominio.Entities;

namespace Dominio.Interfaces;

public interface IPersona : IGenericRepository<Persona>
{
    //Consulta 1
    Task<IEnumerable<Object>> EmpleadosEmpresaDeSeguridad();
    Task<(int totalRegistros, IEnumerable<Object> registros)> EmpleadosEmpresaDeSeguridadPaginated(int pageIndex, int pageSize, string search = null);

    //Consulta 2
    Task<IEnumerable<Object>> EmpleadosVigilantes();
    Task<(int totalRegistros, IEnumerable<Object> registros)> EmpleadosVigilantesPaginated(int pageIndex, int pageSize, string search = null);

    //Consulta 3
    Task<IEnumerable<Object>> NumerosContactosEmpleadosVigilantes();
    Task<(int totalRegistros, IEnumerable<Object> registros)> NumerosContactosEmpleadosVigilantesPaginated(int pageIndex, int pageSize, string search = null);

    //Consulta 4
    Task<IEnumerable<Object>> ClientesEnBucaramanga();
    Task<(int totalRegistros, IEnumerable<Object> registros)> ClientesEnBucaramangaPaginated(int pageIndex, int pageSize, string search = null);

    //Consulta 5
    Task<IEnumerable<Object>> EmpleadosEnGironYPiedecuesta();
    Task<(int totalRegistros, IEnumerable<Object> registros)> EmpleadosEnGironYPiedecuestaPaginated(int pageIndex, int pageSize, string search = null);

    //Conuslta 6
    Task<IEnumerable<Object>> ClientesConMasDe5Antiguedad();
    Task<(int totalRegistros, IEnumerable<Object> registros)> ClientesConMasDe5AntiguedadPaginated(int pageIndex, int pageSize, string search = null);
}