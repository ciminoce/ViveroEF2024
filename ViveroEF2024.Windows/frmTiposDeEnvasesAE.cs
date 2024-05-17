using System.Windows.Forms;
using ViveroEF2024.Entidades;

namespace ViveroEF2024.Windows
{
    public partial class frmTiposDeEnvasesAE : Form
    {
        private TipoDeEnvase? tipoEnvase;
        public frmTiposDeEnvasesAE()
        {
            InitializeComponent();
        }

        public TipoDeEnvase? GetTipoDeEnvase()
        {
            return tipoEnvase;
        }

        public void SetTipoDeEnvase(TipoDeEnvase? tipoDeEnvase)
        {
            tipoEnvase = tipoDeEnvase;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoEnvase != null)
            {
                txtTipoDeEnvase.Text = tipoEnvase.Descripcion;
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
                if (tipoEnvase == null)
                {
                    tipoEnvase = new TipoDeEnvase();

                }
                tipoEnvase.Descripcion = txtTipoDeEnvase.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valid = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtTipoDeEnvase.Text))
            {
                valid = false;
                errorProvider1.SetError(txtTipoDeEnvase, "Nombre de Envase requerido!!!");
            }
            return valid;
        }

    }
}
