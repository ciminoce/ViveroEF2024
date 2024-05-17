namespace ViveroEF2024.Windows
{
    partial class frmMostrarPlantas
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
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            colPlanta = new DataGridViewTextBoxColumn();
            colTipoPlanta = new DataGridViewTextBoxColumn();
            colTipoEnvase = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
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
            splitContainer1.Panel2MinSize = 10;
            splitContainer1.Size = new Size(873, 582);
            splitContainer1.SplitterDistance = 472;
            splitContainer1.TabIndex = 0;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colPlanta, colTipoPlanta, colTipoEnvase, colPrecio });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(873, 472);
            dgvDatos.TabIndex = 1;
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
            // frmMostrarPlantas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 582);
            Controls.Add(splitContainer1);
            Name = "frmMostrarPlantas";
            Text = "frmMostrarPlantas";
            Load += frmMostrarPlantas_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colPlanta;
        private DataGridViewTextBoxColumn colTipoPlanta;
        private DataGridViewTextBoxColumn colTipoEnvase;
        private DataGridViewTextBoxColumn colPrecio;
    }
}