namespace ViveroEF2024.Windows
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTiposDePlantas = new Button();
            btnTiposDeEnvases = new Button();
            btnPlantas = new Button();
            btnProveedores = new Button();
            SuspendLayout();
            // 
            // btnTiposDePlantas
            // 
            btnTiposDePlantas.Location = new Point(38, 41);
            btnTiposDePlantas.Name = "btnTiposDePlantas";
            btnTiposDePlantas.Size = new Size(109, 79);
            btnTiposDePlantas.TabIndex = 0;
            btnTiposDePlantas.Text = "Tipos de Plantas";
            btnTiposDePlantas.UseVisualStyleBackColor = true;
            btnTiposDePlantas.Click += btnTiposDePlantas_Click;
            // 
            // btnTiposDeEnvases
            // 
            btnTiposDeEnvases.Location = new Point(184, 41);
            btnTiposDeEnvases.Name = "btnTiposDeEnvases";
            btnTiposDeEnvases.Size = new Size(109, 79);
            btnTiposDeEnvases.TabIndex = 0;
            btnTiposDeEnvases.Text = "Tipos de Envases";
            btnTiposDeEnvases.UseVisualStyleBackColor = true;
            btnTiposDeEnvases.Click += btnTiposDeEnvases_Click;
            // 
            // btnPlantas
            // 
            btnPlantas.Location = new Point(329, 41);
            btnPlantas.Name = "btnPlantas";
            btnPlantas.Size = new Size(109, 79);
            btnPlantas.TabIndex = 0;
            btnPlantas.Text = "Plantas";
            btnPlantas.UseVisualStyleBackColor = true;
            btnPlantas.Click += btnPlantas_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(38, 158);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(109, 79);
            btnProveedores.TabIndex = 0;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnTiposDePlantas_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPlantas);
            Controls.Add(btnTiposDeEnvases);
            Controls.Add(btnProveedores);
            Controls.Add(btnTiposDePlantas);
            Name = "frmPrincipal";
            Text = "Menú Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTiposDePlantas;
        private Button btnTiposDeEnvases;
        private Button btnPlantas;
        private Button btnProveedores;
    }
}
