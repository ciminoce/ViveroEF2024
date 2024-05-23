using ViveroEF2024.Entidades;
using ViveroEF2024.Windows.Helpers;

namespace ViveroEF2024.Windows
{
    public partial class frmAgregarProveedor : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Proveedor? proveedorSeleccionado;
        public frmAgregarProveedor(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboProveedores(_serviceProvider, ref cboProveedores);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            return valido;
        }

        private void cboProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProveedores.SelectedItem is not null)
            {
                proveedorSeleccionado = cboProveedores.SelectedIndex > 0 ?
            (Proveedor)cboProveedores.SelectedItem : null;

            }
        }

        public Proveedor? GetProveedor()
        {
            return proveedorSeleccionado;
        }
    }
}
