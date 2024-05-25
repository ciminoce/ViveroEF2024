namespace ViveroEF2024.Windows
{
    partial class frmPlantasAE
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlantasAE));
            errorProvider1 = new ErrorProvider(components);
            btnCancelar = new Button();
            btnOk = new Button();
            cboTiposEnvases = new ComboBox();
            label4 = new Label();
            cboTiposPlantas = new ComboBox();
            label3 = new Label();
            txtPrecioVta = new TextBox();
            label5 = new Label();
            txtPrecioCosto = new TextBox();
            label2 = new Label();
            txtPlanta = new TextBox();
            label1 = new Label();
            btnAgregarTipoPlanta = new Button();
            btnAgregarEnvase = new Button();
            lblNuevoTipoDePlanta = new Label();
            lblNuevoTipoDeEnvase = new Label();
            label6 = new Label();
            clstProveedores = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(412, 423);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 54);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(85, 423);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(289, 54);
            btnOk.TabIndex = 9;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // cboTiposEnvases
            // 
            cboTiposEnvases.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTiposEnvases.FormattingEnabled = true;
            cboTiposEnvases.Location = new Point(118, 201);
            cboTiposEnvases.Name = "cboTiposEnvases";
            cboTiposEnvases.Size = new Size(272, 23);
            cboTiposEnvases.TabIndex = 5;
            cboTiposEnvases.SelectedIndexChanged += cboTiposEnvases_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 202);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 33;
            label4.Text = "Envase:";
            // 
            // cboTiposPlantas
            // 
            cboTiposPlantas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTiposPlantas.FormattingEnabled = true;
            cboTiposPlantas.Location = new Point(118, 142);
            cboTiposPlantas.Name = "cboTiposPlantas";
            cboTiposPlantas.Size = new Size(272, 23);
            cboTiposPlantas.TabIndex = 3;
            cboTiposPlantas.SelectedIndexChanged += cboTiposPlantas_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 143);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 34;
            label3.Text = "Tipo:";
            // 
            // txtPrecioVta
            // 
            txtPrecioVta.Location = new Point(116, 100);
            txtPrecioVta.Name = "txtPrecioVta";
            txtPrecioVta.Size = new Size(433, 23);
            txtPrecioVta.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 103);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 27;
            label5.Text = "P. Vta:";
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(116, 59);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(433, 23);
            txtPrecioCosto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 62);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 28;
            label2.Text = "P. Costo:";
            // 
            // txtPlanta
            // 
            txtPlanta.Location = new Point(116, 21);
            txtPlanta.MaxLength = 100;
            txtPlanta.Name = "txtPlanta";
            txtPlanta.Size = new Size(433, 23);
            txtPlanta.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 24);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 29;
            label1.Text = "Planta:";
            // 
            // btnAgregarTipoPlanta
            // 
            btnAgregarTipoPlanta.Image = Properties.Resources.plus_24px;
            btnAgregarTipoPlanta.Location = new Point(412, 136);
            btnAgregarTipoPlanta.Name = "btnAgregarTipoPlanta";
            btnAgregarTipoPlanta.Size = new Size(57, 32);
            btnAgregarTipoPlanta.TabIndex = 4;
            btnAgregarTipoPlanta.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarTipoPlanta.UseVisualStyleBackColor = true;
            btnAgregarTipoPlanta.Click += btnAgregarTipoPlanta_Click;
            // 
            // btnAgregarEnvase
            // 
            btnAgregarEnvase.Image = Properties.Resources.plus_24px;
            btnAgregarEnvase.Location = new Point(412, 195);
            btnAgregarEnvase.Name = "btnAgregarEnvase";
            btnAgregarEnvase.Size = new Size(57, 32);
            btnAgregarEnvase.TabIndex = 6;
            btnAgregarEnvase.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregarEnvase.UseVisualStyleBackColor = true;
            btnAgregarEnvase.Click += btnAgregarEnvase_Click;
            // 
            // lblNuevoTipoDePlanta
            // 
            lblNuevoTipoDePlanta.AutoSize = true;
            lblNuevoTipoDePlanta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNuevoTipoDePlanta.ForeColor = Color.Red;
            lblNuevoTipoDePlanta.Location = new Point(118, 176);
            lblNuevoTipoDePlanta.Name = "lblNuevoTipoDePlanta";
            lblNuevoTipoDePlanta.Size = new Size(123, 15);
            lblNuevoTipoDePlanta.TabIndex = 41;
            lblNuevoTipoDePlanta.Text = "Nuevo tipo de Planta";
            lblNuevoTipoDePlanta.Visible = false;
            // 
            // lblNuevoTipoDeEnvase
            // 
            lblNuevoTipoDeEnvase.AutoSize = true;
            lblNuevoTipoDeEnvase.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNuevoTipoDeEnvase.ForeColor = Color.Red;
            lblNuevoTipoDeEnvase.Location = new Point(118, 236);
            lblNuevoTipoDeEnvase.Name = "lblNuevoTipoDeEnvase";
            lblNuevoTipoDeEnvase.Size = new Size(127, 15);
            lblNuevoTipoDeEnvase.TabIndex = 42;
            lblNuevoTipoDeEnvase.Text = "Nuevo tipo de Envase";
            lblNuevoTipoDeEnvase.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 267);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 33;
            label6.Text = "Proveedor:";
            // 
            // clstProveedores
            // 
            clstProveedores.FormattingEnabled = true;
            clstProveedores.Location = new Point(131, 276);
            clstProveedores.Name = "clstProveedores";
            clstProveedores.Size = new Size(338, 130);
            clstProveedores.TabIndex = 43;
            // 
            // frmPlantasAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 516);
            Controls.Add(clstProveedores);
            Controls.Add(lblNuevoTipoDeEnvase);
            Controls.Add(lblNuevoTipoDePlanta);
            Controls.Add(btnAgregarEnvase);
            Controls.Add(btnAgregarTipoPlanta);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(label6);
            Controls.Add(cboTiposEnvases);
            Controls.Add(label4);
            Controls.Add(cboTiposPlantas);
            Controls.Add(label3);
            Controls.Add(txtPrecioVta);
            Controls.Add(label5);
            Controls.Add(txtPrecioCosto);
            Controls.Add(label2);
            Controls.Add(txtPlanta);
            Controls.Add(label1);
            Name = "frmPlantasAE";
            Text = "frmPlantasAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnOk;
        private ComboBox cboTiposEnvases;
        private Label label4;
        private ComboBox cboTiposPlantas;
        private Label label3;
        private TextBox txtPrecioVta;
        private Label label5;
        private TextBox txtPrecioCosto;
        private Label label2;
        private TextBox txtPlanta;
        private Label label1;
        private Button btnAgregarTipoPlanta;
        private Button btnAgregarEnvase;
        private Label lblNuevoTipoDePlanta;
        private Label lblNuevoTipoDeEnvase;
        private Label label6;
        private CheckedListBox clstProveedores;
    }
}