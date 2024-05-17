namespace ViveroEF2024.Windows
{
    partial class frmTiposDeEnvasesAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposDeEnvasesAE));
            btnCancelar = new Button();
            btnOk = new Button();
            txtTipoDeEnvase = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(429, 139);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 54);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(114, 139);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(289, 54);
            btnOk.TabIndex = 14;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOK_Click;
            // 
            // txtTipoDeEnvase
            // 
            txtTipoDeEnvase.Location = new Point(154, 55);
            txtTipoDeEnvase.MaxLength = 50;
            txtTipoDeEnvase.Name = "txtTipoDeEnvase";
            txtTipoDeEnvase.Size = new Size(415, 23);
            txtTipoDeEnvase.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 58);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 11;
            label1.Text = "Tipo de Envase:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmTiposDeEnvasesAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 231);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txtTipoDeEnvase);
            Controls.Add(label1);
            Name = "frmTiposDeEnvasesAE";
            Text = "frmTiposDeEnvasesAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOk;
        private TextBox txtTipoDeEnvase;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}