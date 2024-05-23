using ViveroEF2024.Entidades;
using ViveroEF2024.Windows.Helpers;

namespace ViveroEF2024.Windows
{
    public partial class frmDetalleProveedor : Form
    {
        private List<Proveedor>? proveedores;
        public frmDetalleProveedor()
        {
            InitializeComponent();
        }

        public void SetDatos(List<Proveedor> proveedores)
        {
            this.proveedores = proveedores;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (proveedores != null)
            {
                GridHelper.MostrarDatosEnGrilla(proveedores, dgvDatos);
            }
        }
    }
}
