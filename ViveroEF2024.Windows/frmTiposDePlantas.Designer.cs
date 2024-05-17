namespace ViveroEF2024.Windows
{
    partial class frmTiposDePlantas
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
            panelNavegacion = new Panel();
            panelGrilla = new Panel();
            dgvDatos = new DataGridView();
            colTipoPlanta = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton6 = new ToolStripButton();
            panelToolBar = new Panel();
            tsbConsultar = new ToolStripButton();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            toolStrip1.SuspendLayout();
            panelToolBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavegacion
            // 
            panelNavegacion.Dock = DockStyle.Bottom;
            panelNavegacion.Location = new Point(0, 411);
            panelNavegacion.Name = "panelNavegacion";
            panelNavegacion.Size = new Size(800, 75);
            panelNavegacion.TabIndex = 0;
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvDatos);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 68);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(800, 343);
            panelGrilla.TabIndex = 2;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colTipoPlanta });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 343);
            dgvDatos.TabIndex = 0;
            // 
            // colTipoPlanta
            // 
            colTipoPlanta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipoPlanta.HeaderText = "Tipo de Planta";
            colTipoPlanta.Name = "colTipoPlanta";
            colTipoPlanta.ReadOnly = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripSeparator1, tsbConsultar, toolStripButton5, toolStripSeparator2, toolStripButton6 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 62);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.Nuevo;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(46, 59);
            toolStripButton1.Text = "Nuevo";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += tsbNuevo_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.Delete;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(44, 59);
            toolStripButton2.Text = "Borrar";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton2.Click += tsbBorrar_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = Properties.Resources.Edit;
            toolStripButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(44, 59);
            toolStripButton3.Text = "Editar";
            toolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton3.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = Properties.Resources.Update;
            toolStripButton5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(63, 59);
            toolStripButton5.Text = "Actualizar";
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 62);
            // 
            // toolStripButton6
            // 
            toolStripButton6.Image = Properties.Resources.Close;
            toolStripButton6.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(44, 59);
            toolStripButton6.Text = "Salir";
            toolStripButton6.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton6.Click += tsbCerrar_Click;
            // 
            // panelToolBar
            // 
            panelToolBar.Controls.Add(toolStrip1);
            panelToolBar.Dock = DockStyle.Top;
            panelToolBar.Location = new Point(0, 0);
            panelToolBar.Name = "panelToolBar";
            panelToolBar.Size = new Size(800, 68);
            panelToolBar.TabIndex = 1;
            // 
            // tsbConsultar
            // 
            tsbConsultar.Image = Properties.Resources.view_details_40px;
            tsbConsultar.ImageScaling = ToolStripItemImageScaling.None;
            tsbConsultar.ImageTransparentColor = Color.Magenta;
            tsbConsultar.Name = "tsbConsultar";
            tsbConsultar.Size = new Size(58, 59);
            tsbConsultar.Text = "Consulta";
            tsbConsultar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbConsultar.Click += tsbConsultar_Click;
            // 
            // frmTiposDePlantas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(panelGrilla);
            Controls.Add(panelToolBar);
            Controls.Add(panelNavegacion);
            Name = "frmTiposDePlantas";
            Text = "frmTiposDePlantas";
            Load += frmTipoDePlantaes_Load;
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelToolBar.ResumeLayout(false);
            panelToolBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavegacion;
        private Panel panelGrilla;
        private DataGridView dgvDatos;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton6;
        private Panel panelToolBar;
        private DataGridViewTextBoxColumn colTipoPlanta;
        private ToolStripButton tsbConsultar;
    }
}