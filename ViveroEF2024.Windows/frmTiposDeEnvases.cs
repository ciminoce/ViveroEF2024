using ViveroEF2024.Entidades;
using ViveroEF2024.Servicios.Intefaces;
using ViveroEF2024.Servicios.Servicios;
using ViveroEF2024.Windows.Helpers;

namespace ViveroEF2024.Windows
{
    public partial class frmTiposDeEnvases : Form
    {
        private readonly ITiposDeEnvasesService _servicio;
        private List<TipoDeEnvase>? lista;
        public frmTiposDeEnvases(ITiposDeEnvasesService servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }


        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmTiposDeEnvasesAE frm = new frmTiposDeEnvasesAE() { Text = "Agregar Envase" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                TipoDeEnvase?tipoDeEnvase = frm.GetTipoDeEnvase();

                if (tipoDeEnvase is not null)
                {
                    if (!_servicio.Existe(tipoDeEnvase))
                    {
                        _servicio.Guardar(tipoDeEnvase);
                        var r = GridHelper.ConstruirFila(dgvDatos);
                        GridHelper.SetearFila(r, tipoDeEnvase);
                        GridHelper.AgregarFila(r, dgvDatos);
                        MessageBox.Show("Registro Agregado Satisfactoriamente!!!",
                            "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Registro Duplicado",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    }

                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }


        private void RecargarGrilla()
        {
            try
            {
                lista = _servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            if (lista is not null)
            {
                foreach (var item in lista)
                {
                    DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, item);
                    GridHelper.AgregarFila(r, dgvDatos);
                }

            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {

        }

        private void frmTipoDeEnvasees_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if(r.Tag is not null)
            {
                TipoDeEnvase tipoDeEnvase = (TipoDeEnvase)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea dar de baja a {tipoDeEnvase.Descripcion}?",
                    "Confirmar Operación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                try
                {


                    if (!_servicio.EstaRelacionado(tipoDeEnvase))
                    {
                        _servicio.Borrar(tipoDeEnvase);

                        GridHelper.QuitarFila(r, dgvDatos);
                        MessageBox.Show("Registro Borrado Satisfactoriamente!!!",
                            "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Registro Relacionado...Baja denegada!!!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }

            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag == null) { return; }
            TipoDeEnvase? tipoDeEnvase = (TipoDeEnvase)r.Tag;
            frmTiposDeEnvasesAE frm = new frmTiposDeEnvasesAE() { Text = "Editar País" };
            frm.SetTipoDeEnvase(tipoDeEnvase);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                tipoDeEnvase = frm.GetTipoDeEnvase();

                if (!_servicio.Existe(tipoDeEnvase))
                {
                    _servicio.Guardar(tipoDeEnvase);

                    GridHelper.SetearFila(r, tipoDeEnvase);
                    MessageBox.Show("Registro Editado Satisfactoriamente!!!",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Registro duplicado",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

    }
}
