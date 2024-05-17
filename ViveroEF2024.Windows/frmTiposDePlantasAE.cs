using ViveroEF2024.Datos;
using ViveroEF2024.Entidades;

namespace ViveroEF2024.Windows
{
    public partial class frmTiposDePlantasAE : Form
    {
        private TipoDePlanta? tipoPlanta;
        public frmTiposDePlantasAE()
        {
            InitializeComponent();
        }

        public TipoDePlanta? GetTipoDePlanta()
        {
            return tipoPlanta;
        }

        public void SetTipoDePlanta(TipoDePlanta? tipoDePlanta)
        {
            tipoPlanta = tipoDePlanta;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoPlanta != null)
            {
                txtTipoDePlanta.Text = tipoPlanta.Descripcion;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoPlanta == null)
                {
                    tipoPlanta = new TipoDePlanta();

                }
                tipoPlanta.Descripcion = txtTipoDePlanta.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtTipoDePlanta.Text))
            {
                valid = false;
                errorProvider1.SetError(txtTipoDePlanta, "Nombre de Tipo requerido!!!");
            }
            return valid;
        }

    }
}
