namespace ViveroEF2024.Windows
{
    partial class frmProveedores
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
            colProveedor = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colMail = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            panelToolBar = new Panel();
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbOrden = new ToolStripDropDownButton();
            aZToolStripMenuItem = new ToolStripMenuItem();
            zAToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbCerrar = new ToolStripButton();
            tsbFiltrar = new ToolStripButton();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panelToolBar.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvDatos);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 68);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(800, 382);
            panelGrilla.TabIndex = 10;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colProveedor, colDireccion, colMail, colTelefono });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 382);
            dgvDatos.TabIndex = 0;
            // 
            // colProveedor
            // 
            colProveedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProveedor.HeaderText = "Proveedor";
            colProveedor.Name = "colProveedor";
            colProveedor.ReadOnly = true;
            // 
            // colDireccion
            // 
            colDireccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDireccion.HeaderText = "Dirección";
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // colMail
            // 
            colMail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMail.HeaderText = "Mail";
            colMail.Name = "colMail";
            colMail.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTelefono.HeaderText = "Teléfono";
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            // 
            // panelToolBar
            // 
            panelToolBar.Controls.Add(toolStrip1);
            panelToolBar.Dock = DockStyle.Top;
            panelToolBar.Location = new Point(0, 0);
            panelToolBar.Name = "panelToolBar";
            panelToolBar.Size = new Size(800, 68);
            panelToolBar.TabIndex = 9;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbOrden, toolStripSeparator3, tsbCerrar });
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
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
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
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 62);
            // 
            // tsbOrden
            // 
            tsbOrden.DropDownItems.AddRange(new ToolStripItem[] { aZToolStripMenuItem, zAToolStripMenuItem });
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
            aZToolStripMenuItem.Size = new Size(180, 22);
            aZToolStripMenuItem.Text = "A-Z";
            // 
            // zAToolStripMenuItem
            // 
            zAToolStripMenuItem.Image = Properties.Resources.alphabetical_sorting_2_16px;
            zAToolStripMenuItem.Name = "zAToolStripMenuItem";
            zAToolStripMenuItem.Size = new Size(180, 22);
            zAToolStripMenuItem.Text = "Z-A";
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
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = Properties.Resources.filter_40px;
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(44, 59);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelGrilla);
            Controls.Add(panelToolBar);
            Name = "frmProveedores";
            Text = "frmProveedores";
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panelToolBar.ResumeLayout(false);
            panelToolBar.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGrilla;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colProveedor;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colMail;
        private DataGridViewTextBoxColumn colTelefono;
        private Panel panelToolBar;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton tsbOrden;
        private ToolStripMenuItem aZToolStripMenuItem;
        private ToolStripMenuItem zAToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbCerrar;
        private ToolStripButton tsbFiltrar;
    }
}