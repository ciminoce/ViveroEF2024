namespace ViveroEF2024.Windows
{
    partial class frmPlantas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelGrilla = new Panel();
            dgvDatos = new DataGridView();
            colPlanta = new DataGridViewTextBoxColumn();
            colTipoPlanta = new DataGridViewTextBoxColumn();
            colTipoEnvase = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            panelToolBar = new Panel();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripDropDownButton();
            porTipoDeEnvaseToolStripMenuItem = new ToolStripMenuItem();
            tcboTiposDeEnvases = new ToolStripComboBox();
            porTipoDePlantaToolStripMenuItem = new ToolStripMenuItem();
            tcboTiposDePlantas = new ToolStripComboBox();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbProveedores = new ToolStripButton();
            tsbAsignarProveedor = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            tsbOrden = new ToolStripDropDownButton();
            aZToolStripMenuItem = new ToolStripMenuItem();
            zAToolStripMenuItem = new ToolStripMenuItem();
            menorPrecioToolStripMenuItem = new ToolStripMenuItem();
            mayorPrecioToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbCerrar = new ToolStripButton();
            panelNavegacion = new Panel();
            txtCantidadRegistros = new TextBox();
            cboPaginas = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            tsbQuitarProveedor = new ToolStripButton();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panelToolBar.SuspendLayout();
            toolStrip1.SuspendLayout();
            panelNavegacion.SuspendLayout();
            SuspendLayout();
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvDatos);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 68);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(800, 307);
            panelGrilla.TabIndex = 8;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colPlanta, colTipoPlanta, colTipoEnvase, colPrecio, colCantidad });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 307);
            dgvDatos.TabIndex = 0;
            // 
            // colPlanta
            // 
            colPlanta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPlanta.HeaderText = "Planta";
            colPlanta.Name = "colPlanta";
            colPlanta.ReadOnly = true;
            // 
            // colTipoPlanta
            // 
            colTipoPlanta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipoPlanta.HeaderText = "Tipo de Planta";
            colTipoPlanta.Name = "colTipoPlanta";
            colTipoPlanta.ReadOnly = true;
            // 
            // colTipoEnvase
            // 
            colTipoEnvase.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipoEnvase.HeaderText = "Tipo de Envase";
            colTipoEnvase.Name = "colTipoEnvase";
            colTipoEnvase.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPrecio.HeaderText = "P. Vta";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 62;
            // 
            // colCantidad
            // 
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colCantidad.HeaderText = "Cant.Prov";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 84;
            // 
            // panelToolBar
            // 
            panelToolBar.Controls.Add(toolStrip1);
            panelToolBar.Dock = DockStyle.Top;
            panelToolBar.Location = new Point(0, 0);
            panelToolBar.Name = "panelToolBar";
            panelToolBar.Size = new Size(800, 68);
            panelToolBar.TabIndex = 7;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbProveedores, tsbAsignarProveedor, tsbQuitarProveedor, toolStripSeparator4, tsbOrden, toolStripSeparator3, tsbCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 62);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.Nuevo;
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 59);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.Delete;
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(44, 59);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.Edit;
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(44, 59);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { porTipoDeEnvaseToolStripMenuItem, porTipoDePlantaToolStripMenuItem });
            tsbFiltrar.Image = Properties.Resources.filter_40px;
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(53, 59);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // porTipoDeEnvaseToolStripMenuItem
            // 
            porTipoDeEnvaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tcboTiposDeEnvases });
            porTipoDeEnvaseToolStripMenuItem.Name = "porTipoDeEnvaseToolStripMenuItem";
            porTipoDeEnvaseToolStripMenuItem.Size = new Size(174, 22);
            porTipoDeEnvaseToolStripMenuItem.Text = "Por Tipo De Envase";
            // 
            // tcboTiposDeEnvases
            // 
            tcboTiposDeEnvases.DropDownStyle = ComboBoxStyle.DropDownList;
            tcboTiposDeEnvases.Name = "tcboTiposDeEnvases";
            tcboTiposDeEnvases.Size = new Size(121, 23);
            tcboTiposDeEnvases.SelectedIndexChanged += tCboEnvases_SelectedIndexChanged;
            // 
            // porTipoDePlantaToolStripMenuItem
            // 
            porTipoDePlantaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tcboTiposDePlantas });
            porTipoDePlantaToolStripMenuItem.Name = "porTipoDePlantaToolStripMenuItem";
            porTipoDePlantaToolStripMenuItem.Size = new Size(174, 22);
            porTipoDePlantaToolStripMenuItem.Text = "Por Tipo De Planta";
            // 
            // tcboTiposDePlantas
            // 
            tcboTiposDePlantas.DropDownStyle = ComboBoxStyle.DropDownList;
            tcboTiposDePlantas.Name = "tcboTiposDePlantas";
            tcboTiposDePlantas.Size = new Size(121, 23);
            tcboTiposDePlantas.SelectedIndexChanged += tcboTiposDePlantas_SelectedIndexChanged;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.Update;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 59);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 62);
            // 
            // tsbProveedores
            // 
            tsbProveedores.Image = Properties.Resources.supplier_40px;
            tsbProveedores.ImageScaling = ToolStripItemImageScaling.None;
            tsbProveedores.ImageTransparentColor = Color.Magenta;
            tsbProveedores.Name = "tsbProveedores";
            tsbProveedores.Size = new Size(76, 59);
            tsbProveedores.Text = "Proveedores";
            tsbProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbProveedores.Click += tsbProveedores_Click;
            // 
            // tsbAsignarProveedor
            // 
            tsbAsignarProveedor.Image = Properties.Resources.add_user_male_40px;
            tsbAsignarProveedor.ImageScaling = ToolStripItemImageScaling.None;
            tsbAsignarProveedor.ImageTransparentColor = Color.Magenta;
            tsbAsignarProveedor.Name = "tsbAsignarProveedor";
            tsbAsignarProveedor.Size = new Size(83, 59);
            tsbAsignarProveedor.Text = "Agregar Prov.";
            tsbAsignarProveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbAsignarProveedor.Click += tsbAsignarProveedor_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 62);
            // 
            // tsbOrden
            // 
            tsbOrden.DropDownItems.AddRange(new ToolStripItem[] { aZToolStripMenuItem, zAToolStripMenuItem, menorPrecioToolStripMenuItem, mayorPrecioToolStripMenuItem });
            tsbOrden.Image = Properties.Resources.list_40px;
            tsbOrden.ImageScaling = ToolStripItemImageScaling.None;
            tsbOrden.ImageTransparentColor = Color.Magenta;
            tsbOrden.Name = "tsbOrden";
            tsbOrden.Size = new Size(53, 59);
            tsbOrden.Text = "Orden";
            tsbOrden.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // aZToolStripMenuItem
            // 
            aZToolStripMenuItem.Image = Properties.Resources.alphabetical_sorting_16px;
            aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            aZToolStripMenuItem.Size = new Size(145, 22);
            aZToolStripMenuItem.Text = "A-Z";
            aZToolStripMenuItem.Click += aZToolStripMenuItem_Click;
            // 
            // zAToolStripMenuItem
            // 
            zAToolStripMenuItem.Image = Properties.Resources.alphabetical_sorting_2_16px;
            zAToolStripMenuItem.Name = "zAToolStripMenuItem";
            zAToolStripMenuItem.Size = new Size(145, 22);
            zAToolStripMenuItem.Text = "Z-A";
            zAToolStripMenuItem.Click += zAToolStripMenuItem_Click;
            // 
            // menorPrecioToolStripMenuItem
            // 
            menorPrecioToolStripMenuItem.Image = Properties.Resources.numerical_sorting_12_16px;
            menorPrecioToolStripMenuItem.Name = "menorPrecioToolStripMenuItem";
            menorPrecioToolStripMenuItem.Size = new Size(145, 22);
            menorPrecioToolStripMenuItem.Text = "Menor Precio";
            menorPrecioToolStripMenuItem.Click += menorPrecioToolStripMenuItem_Click;
            // 
            // mayorPrecioToolStripMenuItem
            // 
            mayorPrecioToolStripMenuItem.Image = Properties.Resources.numerical_sorting_21_16px;
            mayorPrecioToolStripMenuItem.Name = "mayorPrecioToolStripMenuItem";
            mayorPrecioToolStripMenuItem.Size = new Size(145, 22);
            mayorPrecioToolStripMenuItem.Text = "Mayor Precio";
            mayorPrecioToolStripMenuItem.Click += mayorPrecioToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 62);
            // 
            // tsbCerrar
            // 
            tsbCerrar.Image = Properties.Resources.Close;
            tsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbCerrar.ImageTransparentColor = Color.Magenta;
            tsbCerrar.Name = "tsbCerrar";
            tsbCerrar.Size = new Size(44, 59);
            tsbCerrar.Text = "Salir";
            tsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbCerrar.Click += tsbCerrar_Click;
            // 
            // panelNavegacion
            // 
            panelNavegacion.Controls.Add(txtCantidadRegistros);
            panelNavegacion.Controls.Add(cboPaginas);
            panelNavegacion.Controls.Add(label2);
            panelNavegacion.Controls.Add(label1);
            panelNavegacion.Controls.Add(btnUltimo);
            panelNavegacion.Controls.Add(btnSiguiente);
            panelNavegacion.Controls.Add(btnAnterior);
            panelNavegacion.Controls.Add(btnPrimero);
            panelNavegacion.Dock = DockStyle.Bottom;
            panelNavegacion.Location = new Point(0, 375);
            panelNavegacion.Name = "panelNavegacion";
            panelNavegacion.Size = new Size(800, 75);
            panelNavegacion.TabIndex = 6;
            // 
            // txtCantidadRegistros
            // 
            txtCantidadRegistros.Location = new Point(160, 27);
            txtCantidadRegistros.Name = "txtCantidadRegistros";
            txtCantidadRegistros.ReadOnly = true;
            txtCantidadRegistros.Size = new Size(85, 23);
            txtCantidadRegistros.TabIndex = 3;
            // 
            // cboPaginas
            // 
            cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaginas.FormattingEnabled = true;
            cboPaginas.Location = new Point(57, 27);
            cboPaginas.Name = "cboPaginas";
            cboPaginas.Size = new Size(68, 23);
            cboPaginas.TabIndex = 2;
            cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 30);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 1;
            label2.Text = "de:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "Pág.:";
            // 
            // btnUltimo
            // 
            btnUltimo.Image = Properties.Resources.last_24px;
            btnUltimo.Location = new Point(675, 22);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(75, 41);
            btnUltimo.TabIndex = 0;
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Image = Properties.Resources.next_24px;
            btnSiguiente.Location = new Point(594, 22);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 41);
            btnSiguiente.TabIndex = 0;
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Image = Properties.Resources.previous_24px;
            btnAnterior.Location = new Point(513, 22);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 41);
            btnAnterior.TabIndex = 0;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Image = Properties.Resources.first_24px;
            btnPrimero.Location = new Point(432, 22);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(75, 41);
            btnPrimero.TabIndex = 0;
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // tsbQuitarProveedor
            // 
            tsbQuitarProveedor.Image = Properties.Resources.remove_user_male_40px;
            tsbQuitarProveedor.ImageScaling = ToolStripItemImageScaling.None;
            tsbQuitarProveedor.ImageTransparentColor = Color.Magenta;
            tsbQuitarProveedor.Name = "tsbQuitarProveedor";
            tsbQuitarProveedor.Size = new Size(74, 59);
            tsbQuitarProveedor.Text = "Quitar Prov.";
            tsbQuitarProveedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // frmPlantas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelGrilla);
            Controls.Add(panelToolBar);
            Controls.Add(panelNavegacion);
            Name = "frmPlantas";
            Text = "frmPlantas";
            Load += frmPlantas_Load;
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panelToolBar.ResumeLayout(false);
            panelToolBar.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelNavegacion.ResumeLayout(false);
            panelNavegacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGrilla;
        private DataGridView dgvDatos;
        private Panel panelToolBar;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbCerrar;
        private Panel panelNavegacion;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private ComboBox cboPaginas;
        private Label label1;
        private ToolStripDropDownButton tsbOrden;
        private ToolStripMenuItem aZToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem zAToolStripMenuItem;
        private ToolStripMenuItem menorPrecioToolStripMenuItem;
        private ToolStripMenuItem mayorPrecioToolStripMenuItem;
        private TextBox txtCantidadRegistros;
        private Label label2;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripMenuItem porTipoDeEnvaseToolStripMenuItem;
        private ToolStripMenuItem porTipoDePlantaToolStripMenuItem;
        private ToolStripComboBox tcboTiposDeEnvases;
        private ToolStripComboBox tcboTiposDePlantas;
        private ToolStripButton tsbProveedores;
        private ToolStripButton tsbAsignarProveedor;
        private ToolStripSeparator toolStripSeparator4;
        private DataGridViewTextBoxColumn colPlanta;
        private DataGridViewTextBoxColumn colTipoPlanta;
        private DataGridViewTextBoxColumn colTipoEnvase;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCantidad;
        private ToolStripButton tsbQuitarProveedor;
    }
}