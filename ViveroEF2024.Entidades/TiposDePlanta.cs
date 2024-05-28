using ViveroEF2024.Entidades;

namespace ViveroEF2024.Datos;

public partial class TipoDePlanta
{
    public int TipoDePlantaId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Planta> Plantas { get; set; } = new List<Planta>();
}
