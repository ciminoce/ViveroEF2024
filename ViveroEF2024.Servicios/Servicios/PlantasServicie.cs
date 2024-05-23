using ViveroEF2024.Datos;
using ViveroEF2024.Datos.Interfaces;
using ViveroEF2024.Entidades;
using ViveroEF2024.Entidades.Dto;
using ViveroEF2024.Entidades.Enums;
using ViveroEF2024.Servicios.Intefaces;

namespace ViveroEF2024.Servicios.Servicios
{
    public class PlantasService : IPlantasService
    {
        private readonly IPlantasRepository _repository;
        private readonly IProveedoresRepository _proveedorRepository;
        private readonly IUnitOfWork _unitOfWork;
        public PlantasService(IPlantasRepository repository,
            IUnitOfWork unitOfWork,
            IProveedoresRepository proveedorRepository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _unitOfWork = unitOfWork;
            _proveedorRepository = proveedorRepository;
        }

        public void Borrar(Planta planta)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                // Eliminar las relaciones de
                // la planta con los proveedores
                if (planta.ProveedoresPlantas != null)
                {
                    foreach (var proveedorPlanta in
                        planta.ProveedoresPlantas.ToList())
                    {
                        planta.ProveedoresPlantas
                            .Remove(proveedorPlanta);
                    }
                }

                // Eliminar la planta
                _repository.Borrar(planta);

                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool Existe(Planta planta)
        {
            return _repository.Existe(planta);
        }

        public int GetCantidad(Func<Planta, bool>? filtro = null)
        {
            return _repository.GetCantidad(filtro);
        }


        public List<Planta> GetLista()
        {
            return _repository.GetLista();
        }

        public IEnumerable<object> GetListaAnonima()
        {
            return _repository.GetListaAnonima();
        }

        public List<PlantaListDto> GetListaDto()
        {
            return _repository.GetListaDto();
        }

        public void Guardar(Planta planta)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                if (planta.PlantaId == 0)
                {
                    _repository.Agregar(planta);
                }
                else
                {
                    _repository.Editar(planta);
                }
                _unitOfWork.Commit();

            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public List<PlantaListDto> GetListaPaginadaOrdenadaFiltrada(int page, int pageSize,
            Orden? orden = null, TipoDePlanta? tipoPlantaFiltro = null, TipoDeEnvase? tipoDeEnvaseFiltro = null)
        {
            return _repository.GetListaPaginadaOrdenadaFiltrada(page, pageSize,
                orden, tipoPlantaFiltro, tipoDeEnvaseFiltro);
        }

        public Planta? GetPlantaPorId(int plantaId)
        {
            return _repository.GetPlantaPorId(plantaId);
        }

        public void GuardarConProveedor(Planta planta, Proveedor proveedor)
        {

            try
            {
                _unitOfWork.BeginTransaction();
                // Agrega la planta
                _repository.Agregar(planta);

                // Agrega el proveedor
                if (proveedor.ProveedorId == 0)
                {
                    _proveedorRepository.Agregar(proveedor);

                }
                // Guardar los cambios en la base de datos
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                // En caso de error, revertir la transacción
                _unitOfWork.Rollback();
                throw;
            }

        }

        public List<PlantaListDto>? GetPlantasSinProveedor()
        {
            return _repository.GetPlantasSinProveedor();
        }

        public void AsignarProveedorAPlanta(Planta planta,
            Proveedor proveedor)
        {
            try
            {
                _unitOfWork.BeginTransaction();


                // Crear una nueva relación entre la planta y el proveedor
                ProveedorPlanta nuevaRelacion = new ProveedorPlanta
                {
                    Planta = planta,
                    Proveedor = proveedor
                };

                _repository.AgregarProveedorPlanta(nuevaRelacion);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public void Editar(Planta planta, int? proveedorId = null)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                // Editar la planta
                _repository.Editar(planta);

                if (proveedorId.HasValue)
                {
                    // Buscar el proveedor
                    var proveedor = _proveedorRepository
                        .GetProveedorPorId(proveedorId.Value);
                    if (proveedor != null)
                    {
                        // Crear la nueva relación si no existe
                        if (!planta.ProveedoresPlantas
                            .Any(pp => pp.ProveedorId == proveedorId))
                        {
                            var nuevaRelacion = new ProveedorPlanta
                            {
                                PlantaId = planta.PlantaId,
                                ProveedorId = proveedor.ProveedorId
                            };
                            _proveedorRepository.AgregarProveedorPlanta(nuevaRelacion);

                        }
                    }
                    else
                    {
                        throw new Exception("Proveedor no encontrado.");
                    }
                }

                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public IEnumerable<object> GetPlantasAgrupadasPorTipoDePlanta()
        {
            throw new NotImplementedException();
        }

        IEnumerable<IGrouping<int, Planta>> IPlantasService.GetPlantasAgrupadasPorTipoDePlanta()
        {
            return _repository.GetPlantasAgrupadasPorTipoDePlanta();
        }

        public List<Proveedor>? GetProveedoresPorPlanta(int plantaId)
        {
            return _repository.GetProveedoresPorPlanta(plantaId);
        }

        public bool ExisteRelacion(Planta planta, Proveedor proveedor)
        {
            return _repository.ExisteRelacion(planta, proveedor);
        }
    }
}
