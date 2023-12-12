using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class PersonaRepository : GenericRepository<Persona>, IPersona
{
    private readonly ApiContext _context;

    public PersonaRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    //Consulta 1
    public async Task<IEnumerable<Object>> EmpleadosEmpresaDeSeguridad()
    {
        var empleados = await (
            from e in _context.Personas
            where e.TipoPersona.Descripcion == "Empleado" 
            select new
            {
                NombreEmpleado = e.Nombre,
                IdEmpleado = e.IdPersona
            }).ToListAsync();

        return empleados;
    }

    //Consulta 1 con paginación
    public async Task<(int totalRegistros, IEnumerable<Object> registros)> EmpleadosEmpresaDeSeguridadPaginated(int pageIndex, int pageSize, string search = null)
    {
        var query = from e in _context.Personas
                    where e.TipoPersona.Descripcion == "Empleado" 
                    select new
                    {
                        NombreEmpleado = e.Nombre,
                        IdEmpleado = e.IdPersona
                    };

        if (!string.IsNullOrEmpty(search))
        {
            var lowerSearch = search.ToLower();
            query = query.Where(m => m.NombreEmpleado.ToLower().Contains(lowerSearch));
        }

        int totalRegistros = await query.CountAsync();

        var registros = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    }

    //Consulta 2
    public async Task<IEnumerable<Object>> EmpleadosVigilantes()
    {
        var empleados = await (
            from e in _context.Personas
            where e.TipoPersona.Descripcion == "Empleado" && e.CategoriaPersona.NombreCategoria == "Vigilante"
            select new
            {
                NombreEmpleado = e.Nombre,
                IdEmpleado = e.IdPersona
            }).ToListAsync();

        return empleados;
    }

    //Consulta 2 con paginación
    public async Task<(int totalRegistros, IEnumerable<Object> registros)> EmpleadosVigilantesPaginated(int pageIndex, int pageSize, string search = null)
    {
        var query = from e in _context.Personas
                    where e.TipoPersona.Descripcion == "Empleado" && e.CategoriaPersona.NombreCategoria == "Vigilante"
                    select new
                    {
                        NombreEmpleado = e.Nombre,
                        IdEmpleado = e.IdPersona
                    };

        if (!string.IsNullOrEmpty(search))
        {
            var lowerSearch = search.ToLower();
            query = query.Where(m => m.NombreEmpleado.ToLower().Contains(lowerSearch));
        }

        int totalRegistros = await query.CountAsync();

        var registros = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    }

    //Consulta 3
    public async Task<IEnumerable<Object>> NumerosContactosEmpleadosVigilantes()
    {
        var empleados = await (
            from e in _context.Personas
            where e.TipoPersona.Descripcion == "Empleado" && e.CategoriaPersona.NombreCategoria == "Vigilante"
            select new
            {
                NombreEmpleado = e.Nombre,
                IdEmpleado = e.IdPersona,
                NumerosContacto = (
                    from nc in _context.ContactoPersonas
                    select new
                    {
                        Contacto1 = nc.Descripcion,
                        Contacto2 = nc.Descripcion
                    }
                ).Distinct()
                .ToList()
            }).ToListAsync();

        return empleados;
    }

    //Consulta 3 con paginación
    public async Task<(int totalRegistros, IEnumerable<Object> registros)> NumerosContactosEmpleadosVigilantesPaginated(int pageIndex, int pageSize, string search = null)
    {
        var query = from e in _context.Personas
                    where e.TipoPersona.Descripcion == "Empleado" && e.CategoriaPersona.NombreCategoria == "Vigilante"
                    select new
                    {
                        NombreEmpleado = e.Nombre,
                        IdEmpleado = e.IdPersona,
                        NumerosContacto = (
                            from nc in _context.ContactoPersonas
                            select new
                            {
                                Contacto1 = nc.Descripcion,
                                Contacto2 = nc.Descripcion
                            }
                        ).Distinct()
                        .ToList()
                    };

        if (!string.IsNullOrEmpty(search))
        {
            var lowerSearch = search.ToLower();
            query = query.Where(m => m.NombreEmpleado.ToLower().Contains(lowerSearch));
        }

        int totalRegistros = await query.CountAsync();

        var registros = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    }

    //Consulta 4
    public async Task<IEnumerable<Object>> ClientesEnBucaramanga()
    {
        var clientes = await (
            from c in _context.Personas
            where c.TipoPersona.Descripcion == "Cliente" && c.Ciudad.NombreCiudad == "Bucaramanga"
            select new
            {
                NombreCliente = c.Nombre,
                IdCliente = c.IdPersona,
                Ciudad = c.Ciudad.NombreCiudad
            }).ToListAsync();

        return clientes;
    }

    //Consulta 4 con paginación
    public async Task<(int totalRegistros, IEnumerable<Object> registros)> ClientesEnBucaramangaPaginated(int pageIndex, int pageSize, string search = null)
    {
        var query = from c in _context.Personas
                    where c.TipoPersona.Descripcion == "Cliente" && c.Ciudad.NombreCiudad == "Bucaramanga"
                    select new
                    {
                        NombreCliente = c.Nombre,
                        IdCliente = c.IdPersona,
                        Ciudad = c.Ciudad.NombreCiudad
                    };

        if (!string.IsNullOrEmpty(search))
        {
            var lowerSearch = search.ToLower();
            query = query.Where(m => m.Ciudad.ToLower().Contains(lowerSearch));
        }

        int totalRegistros = await query.CountAsync();

        var registros = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    }

    //Consulta 5
    public async Task<IEnumerable<Object>> EmpleadosEnGironYPiedecuesta()
    {
        var empleados = await (
            from e in _context.Personas
            where e.TipoPersona.Descripcion == "Empleado" && e.Ciudad.NombreCiudad == "Giron" || e.Ciudad.NombreCiudad == "Piedecuesta"
            select new
            {
                NombreEmpleado = e.Nombre,
                IdEmpleado = e.IdPersona,
                Ciudad = e.Ciudad.NombreCiudad
            }).ToListAsync();

        return empleados;
    }

    //Consulta 5 con paginación
    public async Task<(int totalRegistros, IEnumerable<Object> registros)> EmpleadosEnGironYPiedecuestaPaginated(int pageIndex, int pageSize, string search = null)
    {
        var query = from e in _context.Personas
                    where e.TipoPersona.Descripcion == "Empleado" && e.Ciudad.NombreCiudad == "Giron" || e.Ciudad.NombreCiudad == "Piedecuesta"
                    select new
                    {
                        NombreEmpleado = e.Nombre,
                        IdEmpleado = e.IdPersona,
                        Ciudad = e.Ciudad.NombreCiudad
                    };

        if (!string.IsNullOrEmpty(search))
        {
            var lowerSearch = search.ToLower();
            query = query.Where(m => m.Ciudad.ToLower().Contains(lowerSearch));
        }

        int totalRegistros = await query.CountAsync();

        var registros = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    }

    //Consulta 6
    public async Task<IEnumerable<Object>> ClientesConMasDe5Antiguedad()
    {
        DateOnly fecha = DateOnly.FromDateTime(DateTime.Now.AddYears(-5));

        var clientes = await (
            from c in _context.Personas
            where c.TipoPersona.Descripcion == "Clientes" && c.FechaRegistro < fecha
            select new
            {
                NombreEmpleado = c.Nombre,
                IdCliente = c.IdPersona
            }).ToListAsync();

        return clientes;
    }

    //Consulta 6 con paginación
    public async Task<(int totalRegistros, IEnumerable<Object> registros)> ClientesConMasDe5AntiguedadPaginated(int pageIndex, int pageSize, string search = null)
    {   
        DateOnly fecha = DateOnly.FromDateTime(DateTime.Now.AddYears(-5));

        var query = from c in _context.Personas
                    where c.TipoPersona.Descripcion == "Clientes" && c.FechaRegistro < fecha
                    select new
                    {
                        NombreEmpleado = c.Nombre,
                        IdCliente = c.IdPersona,
                        FechaIngreso = c.FechaRegistro
                    };

        if (!string.IsNullOrEmpty(search))
        {
            var lowerSearch = search.ToLower();
            query = query.Where(m => m.IdCliente.ToLower().Contains(lowerSearch));
        }

        int totalRegistros = await query.CountAsync();

        var registros = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    }

    public override async Task<IEnumerable<Persona>> GetAllAsync()
    {
        return await _context.Personas
            .ToListAsync();
    }

    public override async Task<Persona> GetByIdAsync(int id)
    {
        return await _context.Personas
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }

    public override async Task<(int totalRegistros, IEnumerable<Persona> registros)> GetAllAsync(int pageIndez, int pageSize, string search)
    {
        var query = _context.Personas as IQueryable<Persona>;

        if(!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.Id.ToString().ToLower().Contains(search));
        }

        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query 
            .Skip((pageIndez - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalRegistros, registros);
    }
}