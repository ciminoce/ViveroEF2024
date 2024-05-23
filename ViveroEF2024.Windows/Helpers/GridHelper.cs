using ViveroEF2024.Datos;
using ViveroEF2024.Entidades;
using ViveroEF2024.Entidades.Dto;

namespace ViveroEF2024.Windows.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;

        }

        public static void QuitarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Remove(r);
        }
        public static void SetearFila(DataGridViewRow r, object item)
        {
            switch (item)
            {
                case TipoDePlanta tipoPlanta:
                    r.Cells[0].Value = tipoPlanta.Descripcion;
                    break;
                case TipoDeEnvase tipoEnvase:
                    r.Cells[0].Value = tipoEnvase.Descripcion;
                    break;
                case PlantaListDto planta:
                    r.Cells[0].Value=planta.Nombre;
                    r.Cells[1].Value = planta.Tipo;
                    r.Cells[2].Value=planta.Envase;
                    r.Cells[3].Value = planta.Precio.ToString("C");
                    r.Cells[4].Value = planta.CantidadProveedores;
                    break;
                case Planta planta:
                    r.Cells[0].Value = planta.Descripcion;
                    r.Cells[1].Value = planta.TipoDePlanta?.Descripcion;
                    r.Cells[2].Value = planta.TipoDeEnvase?.Descripcion;
                    r.Cells[3].Value = planta.PrecioVenta.ToString("C");
                    break;

                default:
                    break;

            }
            r.Tag = item;
        }

        public static void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

    }
}
