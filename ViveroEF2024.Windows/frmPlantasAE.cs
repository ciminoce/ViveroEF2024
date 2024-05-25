
using ViveroEF2024.Datos;
using ViveroEF2024.Entidades;
using ViveroEF2024.Windows.Helpers;

namespace ViveroEF2024.Windows
{
    public partial class frmPlantasAE : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Planta? planta;
        private TipoDePlanta? tipoDePlanta;
        private TipoDeEnvase? tipoDeEnvase;
        private Proveedor? proveedor;
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
            CombosHelper.CargarComboProveedores(_serviceProvider, ref cboProveedores);
            if (planta!=null)
            {
                txtPlanta.Text = planta.Descripcion;
                txtPrecioCosto.Text = planta.PrecioCosto.ToString();
                txtPrecioVta.Text = planta.PrecioVenta.ToString();
                cboTiposEnvases.SelectedValue = planta.TipoDeEnvaseId;
                cboTiposPlantas.SelectedValue = planta.TipoDePlantaId;
                tipoDePlanta = planta.TipoDePlanta;
                tipoDeEnvase = planta.TipoDeEnvase;
            }
        }

        public Planta? GetPlanta()
        {
            return planta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (planta == null)
                {
                    planta = new Planta();
                }
                planta.Descripcion = txtPlanta.Text;
                planta.TipoDePlanta = tipoDePlanta;
                planta.TipoDeEnvase = tipoDeEnvase;
                planta.PrecioCosto = decimal.Parse(txtPrecioCosto.Text);
                planta.PrecioVenta = decimal.Parse(txtPrecioVta.Text);
                planta.TipoDeEnvaseId = tipoDeEnvase?.TipoDeEnvaseId??0;
                planta.TipoDePlantaId = tipoDePlanta?.TipoDePlantaId??0;

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
            if (cboTiposEnvases.SelectedIndex>0)
            {
                tipoDeEnvase=(TipoDeEnvase?)cboTiposEnvases.SelectedItem;
            }else { tipoDeEnvase = null; }
        }

        internal void SetPlanta(Planta? planta)
        {
            this.planta = planta;
        }
    }
}
