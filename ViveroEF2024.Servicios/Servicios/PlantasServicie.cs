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
        private readonly IUnitOfWork _unitOfWork;
        public PlantasService(IPlantasRepository repository, 
            IUnitOfWork unitOfWork)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _unitOfWork = unitOfWork;
        }

        public void Borrar(Planta planta)
        {
            try
            {
                _unitOfWork.BeginTransaction();
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
            Orden? orden = null, TipoDePlanta? tipoPlantaFiltro = null, TipoDeEnvase? tipoDeEnvaseFiltro=null )
        {
            return _repository.GetListaPaginadaOrdenadaFiltrada(page, pageSize,
                orden, tipoPlantaFiltro, tipoDeEnvaseFiltro);
        }

        public Planta? GetPlantaPorId(int plantaId)
        {
            return _repository.GetPlantaPorId(plantaId);
        }
    }
}
