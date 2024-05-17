namespace ViveroEF2024.Datos.Interfaces
{
    public interface ITiposDePlantaRepository
    {
        void Agregar(TipoDePlanta tipoDePlanta);
        void Borrar(TipoDePlanta tipoDePlanta);
        void Editar(TipoDePlanta tipoDePlanta);
        bool EstaRelacionado(TipoDePlanta tipoDePlanta);
        bool Existe(TipoDePlanta tipoDePlanta);
        int GetCantidad();
        List<TipoDePlanta> GetLista();
        TipoDePlanta? GetPlantaPorNombre(string tipoDescripcion);
        
        TipoDePlanta? GetTipoDePlantaPorId(int tipoDePlantaId);
    }
}
