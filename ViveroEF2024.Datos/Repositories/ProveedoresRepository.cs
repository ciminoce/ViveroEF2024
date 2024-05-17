using ViveroEF2024.Datos.Interfaces;
using ViveroEF2024.Entidades;

namespace ViveroEF2024.Datos.Repositories
{
    public class ProveedoresRepository : IProveedoresRepository
    {
        private readonly ViveroDbContext _context;

        public ProveedoresRepository(ViveroDbContext context)
        {
            _context = context;
        }

        public void Agregar(Proveedor proveedor)
        {
            _context.Proveedores.Add(proveedor);
        }

        public void Borrar(Proveedor proveedor)
        {
            _context.Proveedores.Remove(proveedor);
        }

        public void Editar(Proveedor proveedor)
        {
            _context.Proveedores.Update(proveedor);
        }

        public bool Existe(Proveedor proveedor)
        {
            return _context.Proveedores
                .Any(p => p.Nombre == proveedor.Nombre 
                && p.ProveedorId != proveedor.ProveedorId);
        }

        public List<Proveedor> GetLista()
        {
            return _context.Proveedores.ToList();
        }

        public Proveedor? GetProveedorPorId(int id)
        {
            return _context.Proveedores
                .FirstOrDefault(p => p.ProveedorId == id);
        }
    }
}
