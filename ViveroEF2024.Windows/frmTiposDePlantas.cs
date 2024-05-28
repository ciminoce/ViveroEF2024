using ViveroEF2024.Datos;
using ViveroEF2024.Entidades;
using ViveroEF2024.Servicios.Intefaces;
using ViveroEF2024.Windows.Helpers;

namespace ViveroEF2024.Windows
{
    public partial class frmTiposDePlantas : Form
    {

        private readonly ITiposDePlantasService _servicio;
        private List<TipoDePlanta>? lista;
        private List<Planta>? listaPlantas;
        public frmTiposDePlantas(ITiposDePlantasService servicio)
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
            frmTiposDePlantasAE frm = new frmTiposDePlantasAE() { Text = "Agregar Tipo" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                TipoDePlanta tipoDePlanta = frm.GetTipoDePlanta();

                if (!_servicio.Existe(tipoDePlanta))
                {
                    _servicio.Guardar(tipoDePlanta);
                    var r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, tipoDePlanta);
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

        private void frmTipoDePlantaes_Load(object sender, EventArgs e)
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
            TipoDePlanta tipoDePlanta = (TipoDePlanta)r.Tag;
            DialogResult dr = MessageBox.Show($"¿Desea dar de baja a {tipoDePlanta.Descripcion}?",
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


                if (!_servicio.EstaRelacionado(tipoDePlanta))
                {
                    _servicio.Borrar(tipoDePlanta);

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

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            TipoDePlanta tipoDePlanta = (TipoDePlanta)r.Tag;
            frmTiposDePlantasAE frm = new frmTiposDePlantasAE() { Text = "Editar Tipo" };
            frm.SetTipoDePlanta(tipoDePlanta);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                tipoDePlanta = frm.GetTipoDePlanta();

                if (!_servicio.Existe(tipoDePlanta))
                {
                    _servicio.Guardar(tipoDePlanta);

                    GridHelper.SetearFila(r, tipoDePlanta);
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

        private void plantasPorTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsbConsultar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            TipoDePlanta tipo = (TipoDePlanta)r.Tag;
            var tipoEnDB = _servicio.GetTipoDePlantaPorId(tipo.TipoDePlantaId);
            listaPlantas = _servicio.GetPlantas(tipoEnDB);
            
            frmMostrarPlantas frm= new frmMostrarPlantas();
            frm.SetLista(listaPlantas);
            frm.ShowDialog(this);
        }

    }
}
