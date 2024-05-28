using ViveroEF2024.Entidades;
using ViveroEF2024.Windows.Helpers;

namespace ViveroEF2024.Windows
{
    public partial class frmMostrarPlantas : Form
    {
        private List<Planta>? lista;
        public frmMostrarPlantas()
        {
            InitializeComponent();
        }

        public void SetLista(List<Planta>? listaPlantas)
        {
            lista = listaPlantas;
        }
        private void MostrarPlantasEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            foreach (var item in lista)
            {
                var r = GridHelper.ConstruirFila(dgvDatos);
                GridHelper.SetearFila(r, item);
                GridHelper.AgregarFila(r, dgvDatos);
            }
        }

        private void frmMostrarPlantas_Load(object sender, EventArgs e)
        {
            if (lista!=null)
            {
                MostrarPlantasEnGrilla();
            }
        }
    }
}
