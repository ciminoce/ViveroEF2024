namespace ViveroEF2024.Windows
{
    partial class frmEstadisticas
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
            splitContainer1 = new SplitContainer();
            btnCerrar = new Button();
            dgvDatos = new DataGridView();
            colTipo = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecioPromedio = new DataGridViewTextBoxColumn();
            colMaxPrecio = new DataGridViewTextBoxColumn();
            colMinPrecio = new DataGridViewTextBoxColumn();
            colVerDetalles = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnCerrar);
            splitContainer1.Size = new Size(800, 501);
            splitContainer1.SplitterDistance = 421;
            splitContainer1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(695, 22);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 33);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colTipo, colCantidad, colPrecioPromedio, colMaxPrecio, colMinPrecio, colVerDetalles });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.Size = new Size(800, 421);
            dgvDatos.TabIndex = 1;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo de Planta";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cant. Plantas";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colPrecioPromedio
            // 
            colPrecioPromedio.HeaderText = "Prom. Precio";
            colPrecioPromedio.Name = "colPrecioPromedio";
            colPrecioPromedio.ReadOnly = true;
            // 
            // colMaxPrecio
            // 
            colMaxPrecio.HeaderText = "Max. Precio";
            colMaxPrecio.Name = "colMaxPrecio";
            colMaxPrecio.ReadOnly = true;
            // 
            // colMinPrecio
            // 
            colMinPrecio.HeaderText = "Min. Precio";
            colMinPrecio.Name = "colMinPrecio";
            colMinPrecio.ReadOnly = true;
            // 
            // colVerDetalles
            // 
            colVerDetalles.HeaderText = "Ver Detalles";
            colVerDetalles.Name = "colVerDetalles";
            colVerDetalles.ReadOnly = true;
            // 
            // frmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(splitContainer1);
            Name = "frmEstadisticas";
            Text = "frmEstadisticas";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnCerrar;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecioPromedio;
        private DataGridViewTextBoxColumn colMaxPrecio;
        private DataGridViewTextBoxColumn colMinPrecio;
        private DataGridViewButtonColumn colVerDetalles;
    }
}