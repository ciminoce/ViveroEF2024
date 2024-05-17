namespace ViveroEF2024.Windows
{
    partial class frmTiposDePlantasAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposDePlantasAE));
            label1 = new Label();
            txtTipoDePlanta = new TextBox();
            btnCancelar = new Button();
            btnOk = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 51);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Planta:";
            // 
            // txtTipoDePlanta
            // 
            txtTipoDePlanta.Location = new Point(137, 48);
            txtTipoDePlanta.MaxLength = 50;
            txtTipoDePlanta.Name = "txtTipoDePlanta";
            txtTipoDePlanta.Size = new Size(415, 23);
            txtTipoDePlanta.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.Cancelar;
            btnCancelar.Location = new Point(412, 132);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 54);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(97, 132);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(289, 54);
            btnOk.TabIndex = 10;
            btnOk.Text = "Ok";
            btnOk.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOK_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmTiposDePlantasAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 214);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txtTipoDePlanta);
            Controls.Add(label1);
            Name = "frmTiposDePlantasAE";
            Text = "frmTiposDePlantasAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTipoDePlanta;
        private Button btnCancelar;
        private Button btnOk;
        private ErrorProvider errorProvider1;
    }
}