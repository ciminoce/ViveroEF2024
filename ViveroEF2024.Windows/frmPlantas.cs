using Microsoft.Extensions.DependencyInjection;
using ViveroEF2024.Datos;
using ViveroEF2024.Entidades;
using ViveroEF2024.Entidades.Dto;
using ViveroEF2024.Entidades.Enums;
using ViveroEF2024.Servicios.Intefaces;
using ViveroEF2024.Windows.Helpers;
using ViveroEF2024.Windows.Properties;

namespace ViveroEF2024.Windows
{
    public partial class frmPlantas : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IPlantasService _servicio;
        private List<PlantaListDto>? lista;
        private Orden orden = Orden.SinOrden;
        private TipoDeEnvase? tipoDeEnvaseFiltro = null;
        private TipoDePlanta? tipoDePlantaFiltro = null;

        private bool FilterOn = false;

        private int pageCount;
        private int pageSize = 15;
        private int pageNum = 0;
        private int recordCount;
        public frmPlantas(IPlantasService servicio, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _servicio = servicio;
            _serviceProvider = serviceProvider;
        }

        private void frmPlantas_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboTiposEnvases(_serviceProvider, ref tcboTiposDeEnvases);
            CombosHelper.CargarComboTiposPlantas(_serviceProvider, ref tcboTiposDePlantas);
            RecargarGrillDeTodasLasPlantas();
        }

        private void RecargarGrillDeTodasLasPlantas()
        {
            try
            {
                recordCount = _servicio.GetCantidad();
                pageCount = FormHelper.CalcularPaginas(recordCount, pageSize);
                txtCantidadRegistros.Text = pageCount.ToString();
                CombosHelper.CargarCombosPaginas(pageCount, ref cboPaginas);

                // Obtener la lista paginada ordenada y filtrada por defecto (sin orden ni filtro)
                lista = _servicio.GetListaPaginadaOrdenadaFiltrada(pageNum, pageSize);
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ordenar de forma ascendente (A-Z)
            MostrarOrdenado(Orden.AZ);
        }

        private void zAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ordenar de forma descendente (Z-A)
            MostrarOrdenado(Orden.ZA);
        }

        private void menorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ordenar por menor precio
            MostrarOrdenado(Orden.MenorPrecio);
        }

        private void mayorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ordenar por mayor precio
            MostrarOrdenado(Orden.MayorPrecio);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Ir a la siguiente página
            pageNum++;
            if (pageNum > pageCount - 1) { pageNum = pageCount - 1; }
            cboPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            // Ir a la página anterior
            pageNum--;
            if (pageNum < 0) { pageNum = 0; }
            cboPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            // Ir a la primera página
            pageNum = 0;
            cboPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            // Ir a la última página
            pageNum = pageCount - 1;
            cboPaginas.SelectedIndex = pageNum;
            ActualizarListaPaginada();
        }

        private void cboPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cambiar a la página seleccionada
            pageNum = cboPaginas.SelectedIndex;
            ActualizarListaPaginada();
        }

        private void ActualizarListaPaginada()
        {
            // Actualizar la lista paginada según la página actual y tamaño de página
            lista = _servicio
                .GetListaPaginadaOrdenadaFiltrada(pageNum, pageSize, orden,
                tipoDePlantaFiltro, tipoDeEnvaseFiltro);
            MostrarDatosEnGrilla();
        }

        private void MostrarOrdenado(Orden orden)
        {
            // Mostrar la lista ordenada según el criterio seleccionado
            lista = _servicio.GetListaPaginadaOrdenadaFiltrada(pageNum, pageSize, orden);
            MostrarDatosEnGrilla();
        }
        //TODO:Hacer método Genérico!!!
        private void MostrarDatosEnGrilla()
        {
            // Mostrar los datos en la grilla
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
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmPlantasAE frm = new frmPlantasAE(_serviceProvider);
            DialogResult df = frm.ShowDialog(this);
            if (df == DialogResult.Cancel) { return; }
            try
            {
                var planta = frm.GetPlanta();
                if (!_servicio.Existe(planta))
                {
                    _servicio.Guardar(planta);
                    // Actualizar la lista después de agregar la planta
                    ActualizarListaDespuesAgregar(planta);
                }
                else
                {
                    MessageBox.Show("Planta existente!!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void ActualizarListaDespuesAgregar(Planta plantaAgregada)
        {
            // Obtener la página actual y actualizar la lista
            int paginaActual = pageNum;
            lista = _servicio.GetListaPaginadaOrdenadaFiltrada(paginaActual, pageSize);

            // Mostrar la lista actualizada en la grilla
            MostrarDatosEnGrilla();

            // Verificar si la planta agregada está en la página actual

            bool plantaAgregadaEnPaginaActual = lista
                .Any(p => p.PlantaId == plantaAgregada.PlantaId);

            if (!plantaAgregadaEnPaginaActual)
            {
                // Si la planta agregada no está en la página actual,
                // seleccionar la última página y actualizar la lista
                pageNum = pageCount - 1;
                cboPaginas.SelectedIndex = pageNum;
                //modifique los parámetros OJO!!!
                lista = _servicio
                    .GetListaPaginadaOrdenadaFiltrada(pageNum, pageSize, orden,
                    tipoDePlantaFiltro, tipoDeEnvaseFiltro);
                MostrarDatosEnGrilla();
            }
        }
        private void porTipoDeEnvaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {

        }

        private void tCboEnvases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FilterOn)
            {
                if (tcboTiposDeEnvases.SelectedIndex > 0)
                {
                    FilterOn = true;
                    var servicio = _serviceProvider
                        .GetService<ITiposDeEnvasesService>();
                    tipoDeEnvaseFiltro = servicio?
                        .GetTipoDeEnvasePorNombre(tcboTiposDeEnvases.Text);

                    recordCount = _servicio
                        .GetCantidad(p => p.TipoDeEnvase == tipoDeEnvaseFiltro);

                    pageCount = FormHelper
                        .CalcularPaginas(recordCount, pageSize);

                    txtCantidadRegistros.Text = pageCount.ToString();
                    CombosHelper.CargarCombosPaginas(pageCount, ref cboPaginas);

                    lista = _servicio
                        .GetListaPaginadaOrdenadaFiltrada(
                        pageNum, pageSize, orden, tipoDePlantaFiltro,
                        tipoDeEnvaseFiltro);
                    MostrarDatosEnGrilla();
                    tsbFiltrar.Image = Resources.filter_intense_40px;
                    tsbFiltrar.BackColor = Color.DarkGray;
                    tsbFiltrar.Enabled = false;
                }
                else
                {
                    tipoDeEnvaseFiltro = null;
                }

            }

            else
            {
                MessageBox.Show("Debe actualizar la grilla!!!", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void tcboTiposDePlantas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!FilterOn)
            {
                if (tcboTiposDePlantas.SelectedIndex > 0)
                {
                    FilterOn = true;
                    var servicio = _serviceProvider
                        .GetService<ITiposDePlantasService>();
                    tipoDePlantaFiltro = servicio?
                        .GetTipoDePlantaPorNombre(tcboTiposDePlantas.Text);

                    // Definir el filtro
                    Func<Planta, bool> filtro =
                        p => p.TipoDePlanta == tipoDePlantaFiltro;

                    // Obtener la cantidad de registros después de aplicar el filtro
                    recordCount = _servicio.GetCantidad(filtro);

                    // Recalcular el número de páginas
                    pageCount = FormHelper
                        .CalcularPaginas(recordCount, pageSize);

                    // Actualizar el texto del cuadro de texto de cantidad de registros
                    txtCantidadRegistros.Text = pageCount.ToString();

                    // Recargar el combo de páginas
                    CombosHelper.CargarCombosPaginas(pageCount,
                        ref cboPaginas);

                    // Obtener la lista paginada ordenada y filtrada
                    lista = _servicio
                        .GetListaPaginadaOrdenadaFiltrada(pageNum,
                        pageSize, orden, tipoDePlantaFiltro,
                        tipoDeEnvaseFiltro);
                    MostrarDatosEnGrilla();

                    tsbFiltrar.Image = Resources.filter_intense_40px;
                    tsbFiltrar.BackColor = Color.DarkGray;
                    tsbFiltrar.Enabled = false;
                }
                else
                {
                    tipoDePlantaFiltro = null;
                }
            }
            else
            {
                MessageBox.Show("Debe actualizar la grilla!!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tcboTiposDePlantas_Click(object sender, EventArgs e)
        {

        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            FilterOn = false;
            tsbFiltrar.Enabled = true;
            RecargarGrillDeTodasLasPlantas();
            tsbFiltrar.Image = Resources.filter_40px;
            tsbFiltrar.BackColor = SystemColors.Control;

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) { return; }
            var r = dgvDatos.SelectedRows[0];
            PlantaListDto plantaList = (PlantaListDto)r.Tag;
            var planta = _servicio.GetPlantaPorId(plantaList.PlantaId);
            frmPlantasAE frm = new frmPlantasAE(_serviceProvider)
            { Text = "Editar Planta" };
            frm.SetPlanta(planta);
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                planta = frm.GetPlanta();
                if (!_servicio.Existe(planta))
                {
                    _servicio.Guardar(planta);
                    ActualizarListaDespuesAgregar(planta);

                }
                else
                {
                    MessageBox.Show("Planta existente!!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsbProveedores_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            PlantaListDto plantaDto = (PlantaListDto)r.Tag;
            List<Proveedor>? proveedores = _servicio
                .GetProveedoresPorPlanta(plantaDto.PlantaId);
            if (proveedores is null || proveedores.Count == 0)
            {
                MessageBox.Show("Planta sin proveedores asignados",
                    "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmDetalleProveedor frm = new frmDetalleProveedor()
            { Text = $"Proveedores de la planta {plantaDto.Nombre}" };
            frm.SetDatos(proveedores);
            frm.ShowDialog(this);
        }

        private void tsbAsignarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            if (r.Tag is null) return;
            var plantaDto = (PlantaListDto)r.Tag;

            Planta? planta = _servicio.GetPlantaPorId(plantaDto?.PlantaId ?? 0);
            if (planta is null) return;
            frmAgregarProveedor frm = new frmAgregarProveedor(_serviceProvider) { Text = "Agregar Proveedor" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            try
            {
                Proveedor? proveedor = frm.GetProveedor();
                if (proveedor is null) return;
                if (!_servicio.ExisteRelacion(planta, proveedor))
                {
                    _servicio.AsignarProveedorAPlanta(planta, proveedor);
                    if (plantaDto is not null)
                    {
                        plantaDto.CantidadProveedores++;
                        GridHelper.SetearFila(r, plantaDto);
                    }
                    MessageBox.Show("Proveedor asignado a la planta!!!",
                        "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else {
                    MessageBox.Show("Asignación Existente!!!",
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                            "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }
    }
}
