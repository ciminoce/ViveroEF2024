namespace ViveroEF2024.Windows
{
    partial class frmAgregarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarProveedor));
            btnCancelar = new Button();
            btnOk = new Button();
            cboProveedores = new ComboBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(393, 118);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 54);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(66, 118);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(289, 54);
            btnOk.TabIndex = 15;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // cboProveedores
            // 
            cboProveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProveedores.FormattingEnabled = true;
            cboProveedores.Location = new Point(126, 52);
            cboProveedores.Name = "cboProveedores";
            cboProveedores.Size = new Size(383, 23);
            cboProveedores.TabIndex = 14;
            cboProveedores.SelectedIndexChanged += cboProveedores_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 55);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 13;
            label1.Text = "Proveedor:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAgregarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 215);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(cboProveedores);
            Controls.Add(label1);
            Name = "frmAgregarProveedor";
            Text = "frmAgregarProveedor";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOk;
        private ComboBox cboProveedores;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}