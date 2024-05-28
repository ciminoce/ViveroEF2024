
using ViveroEF2024.Datos;
using ViveroEF2024.Entidades;
using ViveroEF2024.Windows.Helpers;

namespace ViveroEF2024.Windows
{
    public partial class frmPlantasAE : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private TipoDePlanta? tipoDePlanta;
        private TipoDeEnvase? tipoDeEnvase;

        
        private (Planta? planta, List<Proveedor>? proveedores) p;
        public frmPlantasAE(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboTiposPlantas(_serviceProvider, ref cboTiposPlantas);
            CombosHelper.CargarComboTiposEnvases(_serviceProvider, ref cboTiposEnvases);
            ListBoxHelper.CargarDatosListBoxProveedores(_serviceProvider, ref clstProveedores);
            if (p.planta != null)
            {
                txtPlanta.Text = p.planta.Descripcion;
                txtPrecioCosto.Text = p.planta.PrecioCosto.ToString();
                txtPrecioVta.Text = p.planta.PrecioVenta.ToString();
                cboTiposEnvases.SelectedValue = p.planta.TipoDeEnvaseId;
                cboTiposPlantas.SelectedValue = p.planta.TipoDePlantaId;
                tipoDePlanta = p.planta.TipoDePlanta;
                tipoDeEnvase = p.planta.TipoDeEnvase;
            }
            if(p.proveedores != null && p.proveedores.Any())
            {
                // Recorre todos los ítems del CheckedListBox
                for (int i = 0; i < clstProveedores.Items.Count; i++)
                {
                    // Obtén el proveedor actual del CheckedListBox
                    var itemProveedor = clstProveedores.Items[i] as Proveedor;

                    if (itemProveedor != null)
                    {
                        // Verifica si el proveedor actual está en la lista de proveedores
                        if (p.proveedores
                            .Any(p => p.ProveedorId == itemProveedor.ProveedorId))
                        {
                            // Selecciona el ítem si el proveedor está en la lista
                            clstProveedores.SetItemChecked(i, true);
                        }
                        else
                        {
                            // Desmarca el ítem si el proveedor no está en la lista
                            clstProveedores.SetItemChecked(i, false);
                        }
                    }
                }
            }
        }

        public (Planta?, List<Proveedor>?) GetPlantaProveedores()
        {
            return p;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (p.planta == null)
                {
                    p.planta = new Planta();
                }
                p.planta.Descripcion = txtPlanta.Text;
                p.planta.TipoDePlanta = tipoDePlanta;
                p.planta.TipoDeEnvase = tipoDeEnvase;
                p.planta.PrecioCosto = decimal.Parse(txtPrecioCosto.Text);
                p.planta.PrecioVenta = decimal.Parse(txtPrecioVta.Text);
                p.planta.TipoDeEnvaseId = tipoDeEnvase?.TipoDeEnvaseId ?? 0;
                p.planta.TipoDePlantaId = tipoDePlanta?.TipoDePlantaId ?? 0;

                //Se checka que la lista tenga algún item seleccionado
                if (clstProveedores.CheckedItems.Count > 0)
                {
                    p.proveedores = new List<Proveedor>();
                    //Se itera sobre los proveedores seleccionados
                    foreach (var item in clstProveedores.CheckedItems)
                    {
                        //Se almacenan los proveedores seleccionados

                        p.proveedores.Add((Proveedor)item);

                    }
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtPlanta.Text) ||
                string.IsNullOrWhiteSpace(txtPlanta.Text))
            {
                valido = false;
                errorProvider1.SetError(txtPlanta, "Nombre de planta requerido");
            }

            if (!decimal.TryParse(txtPrecioCosto.Text, out decimal pCosto) ||
                (pCosto <= 0))
            {
                valido = false;
                errorProvider1.SetError(txtPrecioCosto, "Precio de costo no válido o mal ingresado");

            }
            if (!decimal.TryParse(txtPrecioVta.Text, out decimal pVenta) ||
                (pVenta <= pCosto))
            {
                valido = false;
                errorProvider1.SetError(txtPrecioVta, "Precio de vennta no válido o mal ingresado");

            }
            if (cboTiposEnvases.SelectedIndex == 0 && tipoDeEnvase == null)
            {
                valido = false;
                errorProvider1.SetError(cboTiposEnvases, "Debe seleccionar un tipo de envase");

            }
            if (cboTiposPlantas.SelectedIndex == 0 && tipoDePlanta == null)
            {
                valido = false;
                errorProvider1.SetError(cboTiposPlantas, "Debe seleccionar un tipo de planta");

            }
            return valido;
        }

        private void btnAgregarTipoPlanta_Click(object sender, EventArgs e)
        {
            frmTiposDePlantasAE frm = new frmTiposDePlantasAE();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            tipoDePlanta = frm.GetTipoDePlanta();

            cboTiposPlantas.Enabled = false;
            lblNuevoTipoDePlanta.Visible = true;
        }

        private void btnAgregarEnvase_Click(object sender, EventArgs e)
        {
            frmTiposDeEnvasesAE frm = new frmTiposDeEnvasesAE();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            tipoDeEnvase = frm.GetTipoDeEnvase();
            cboTiposEnvases.Enabled = false;
            lblNuevoTipoDeEnvase.Visible = true;

        }

        private void cboTiposPlantas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTiposPlantas.SelectedIndex > 0)
            {
                tipoDePlanta = (TipoDePlanta?)cboTiposPlantas.SelectedItem;
            }
            else
            {
                tipoDePlanta = null;
            }
        }

        private void cboTiposEnvases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTiposEnvases.SelectedIndex > 0)
            {
                tipoDeEnvase = (TipoDeEnvase?)cboTiposEnvases.SelectedItem;
            }
            else { tipoDeEnvase = null; }
        }


        public void SetPlantaProveedores(
            (Planta? planta, List<Proveedor>? proveedores)p)
        {
            this.p= p;
        }
    }
}
