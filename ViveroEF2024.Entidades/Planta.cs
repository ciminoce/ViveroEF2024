using ViveroEF2024.Entidades;

namespace ViveroEF2024.Datos;

public partial class Planta
{
    public int PlantaId { get; set; }

    public string Descripcion { get; set; } = null!;

    public int TipoDePlantaId { get; set; }

    public decimal PrecioCosto { get; set; }
    public decimal PrecioVenta { get; set; }
    public int TipoDeEnvaseId { get; set; }
    public TipoDePlanta? TipoDePlanta { get; set; } 
    public TipoDeEnvase? TipoDeEnvase { get; set; }
}
