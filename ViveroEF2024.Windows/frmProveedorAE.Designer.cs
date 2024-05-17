namespace ViveroEF2024.Windows
{
    partial class frmProveedorAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedorAE));
            txtMail = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label2 = new Label();
            txtProveedor = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtTelefono = new TextBox();
            btnCancelar = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Location = new Point(113, 113);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(433, 23);
            txtMail.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 116);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 33;
            label5.Text = "Mail:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(113, 72);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(433, 23);
            txtDireccion.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 75);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 34;
            label2.Text = "Dirección:";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(113, 34);
            txtProveedor.MaxLength = 100;
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(433, 23);
            txtProveedor.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 35;
            label1.Text = "Proveedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 160);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 33;
            label3.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(113, 157);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(433, 23);
            txtTelefono.TabIndex = 36;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(394, 206);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 54);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(67, 206);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(289, 54);
            btnOk.TabIndex = 40;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            // 
            // frmProveedorAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 281);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtMail);
            Controls.Add(label5);
            Controls.Add(txtDireccion);
            Controls.Add(label2);
            Controls.Add(txtProveedor);
            Controls.Add(label1);
            Name = "frmProveedorAE";
            Text = "frmProveedorAE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private Label label5;
        private TextBox txtDireccion;
        private Label label2;
        private TextBox txtProveedor;
        private Label label1;
        private Label label3;
        private TextBox txtTelefono;
        private Button btnCancelar;
        private Button btnOk;
    }
}