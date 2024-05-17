using Microsoft.EntityFrameworkCore;
using ViveroEF2024.Datos.Interfaces;
using ViveroEF2024.Entidades;

namespace ViveroEF2024.Datos.Repositories
{
    public class TiposDeEnvasesRepository : ITiposDeEnvasesRepository
    {
        private readonly ViveroDbContext _context;

        public TiposDeEnvasesRepository(ViveroDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Agregar(TipoDeEnvase tipoDeEnvase)
        {
            _context.TiposDeEnvases.Add(tipoDeEnvase);
        }

        public void Borrar(TipoDeEnvase tipoDeEnvase)
        {
            _context.TiposDeEnvases.Remove(tipoDeEnvase);
        }

        public void Editar(TipoDeEnvase tipoDeEnvase)
        {
            _context.TiposDeEnvases.Update(tipoDeEnvase);
        }

        public bool EstaRelacionado(TipoDeEnvase tipoDeEnvase)
        {
            return _context
                .Plantas
                .Any(p=>p.TipoDeEnvaseId==tipoDeEnvase.TipoDeEnvaseId);
        }

        public bool Existe(TipoDeEnvase tipoEnvase)
        {
            if (tipoEnvase.TipoDeEnvaseId==0)
            {
                return _context.TiposDeEnvases
                    .Any(te => te.Descripcion == tipoEnvase.Descripcion);
            }
            return _context.TiposDeEnvases
                .Any(te=>te.Descripcion==tipoEnvase.Descripcion && 
                te.TipoDeEnvaseId!=tipoEnvase.TipoDeEnvaseId);
        }

        public TipoDeEnvase? GetEnvasePorId(int idEditar)
        {
            return _context.TiposDeEnvases
                .SingleOrDefault(te => te.TipoDeEnvaseId == idEditar);
        }

        public List<TipoDeEnvase> GetLista()
        {
            return _context.TiposDeEnvases
                .OrderBy(te=>te.TipoDeEnvaseId)
                .AsNoTracking()
                .ToList();
        }

        public TipoDeEnvase? GetTipoDeEnvasePorNombre(string tipoDeEnvase)
        {
            return _context.TiposDeEnvases.AsNoTracking()
                .FirstOrDefault(te => te.Descripcion == tipoDeEnvase);
        }
    }
}
