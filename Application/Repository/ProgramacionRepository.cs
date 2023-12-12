using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository;

public class ProgramacionRepository : GenericRepository<Programacion>, IProgramacion
{
    private readonly ApiContext _context;

    public ProgramacionRepository(ApiContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Programacion>> GetAllAsync()
    {
        return await _context.Programaciones
            .ToListAsync();
    }

    public override async Task<Programacion> GetByIdAsync(int id)
    {
        return await _context.Programaciones
        .FirstOrDefaultAsync(p =>  p.Id == id);
    }

    public override async Task<(int totalRegistros, IEnumerable<Programacion> registros)> GetAllAsync(int pageIndez, int pageSize, string search)
    {
        var query = _context.Programaciones as IQueryable<Programacion>;

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