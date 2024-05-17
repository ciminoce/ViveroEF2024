using ViveroEF2024.Datos;
using ViveroEF2024.Entidades;
using ViveroEF2024.Entidades.Dto;
using ViveroEF2024.Entidades.Enums;

namespace ViveroEF2024.Servicios.Intefaces
{
    public interface IPlantasService
    {
        int GetCantidad(Func<Planta, bool>? filtro = null);
        void Guardar(Planta planta);
        void Borrar(Planta planta);
        List<PlantaListDto> GetListaPaginadaOrdenadaFiltrada(int page,
            int pageSize, Orden? orden = null, TipoDePlanta? tipoPlantaFiltro = null,
            TipoDeEnvase? tipoEnvaseFiltro=null);

        List<Planta> GetLista();
        IEnumerable<object> GetListaAnonima();
        bool Existe(Planta planta);
        List<PlantaListDto> GetListaDto();
        Planta? GetPlantaPorId(int plantaId);
    }
}
