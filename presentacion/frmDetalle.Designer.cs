namespace presentacion
{
    partial class frmDetalle
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
            this.lblCat = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblMarcado = new System.Windows.Forms.Label();
            this.lblNombramiento = new System.Windows.Forms.Label();
            this.lblCodificado = new System.Windows.Forms.Label();
            this.txtCodificado = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtNombramiento = new System.Windows.Forms.TextBox();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtMarcado = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(27, 152);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(69, 16);
            this.lblCat.TabIndex = 0;
            this.lblCat.Text = "Categoria:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 115);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(82, 16);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Descripción:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(47, 229);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(49, 16);
            this.lblCosto.TabIndex = 2;
            this.lblCosto.Text = "Precio:";
            // 
            // lblMarcado
            // 
            this.lblMarcado.AutoSize = true;
            this.lblMarcado.Location = new System.Drawing.Point(48, 189);
            this.lblMarcado.Name = "lblMarcado";
            this.lblMarcado.Size = new System.Drawing.Size(48, 16);
            this.lblMarcado.TabIndex = 3;
            this.lblMarcado.Text = "Marca:";
            // 
            // lblNombramiento
            // 
            this.lblNombramiento.AutoSize = true;
            this.lblNombramiento.Location = new System.Drawing.Point(37, 77);
            this.lblNombramiento.Name = "lblNombramiento";
            this.lblNombramiento.Size = new System.Drawing.Size(59, 16);
            this.lblNombramiento.TabIndex = 4;
            this.lblNombramiento.Text = "Nombre:";
            // 
            // lblCodificado
            // 
            this.lblCodificado.AutoSize = true;
            this.lblCodificado.Location = new System.Drawing.Point(42, 38);
            this.lblCodificado.Name = "lblCodificado";
            this.lblCodificado.Size = new System.Drawing.Size(54, 16);
            this.lblCodificado.TabIndex = 5;
            this.lblCodificado.Text = "Código:";
            // 
            // txtCodificado
            // 
            this.txtCodificado.Location = new System.Drawing.Point(111, 38);
            this.txtCodificado.Name = "txtCodificado";
            this.txtCodificado.Size = new System.Drawing.Size(156, 22);
            this.txtCodificado.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(111, 112);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(156, 22);
            this.txtDescription.TabIndex = 7;
            // 
            // txtNombramiento
            // 
            this.txtNombramiento.Location = new System.Drawing.Point(111, 74);
            this.txtNombramiento.Name = "txtNombramiento";
            this.txtNombramiento.Size = new System.Drawing.Size(156, 22);
            this.txtNombramiento.TabIndex = 8;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(112, 149);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(155, 22);
            this.txtCat.TabIndex = 9;
            // 
            // txtMarcado
            // 
            this.txtMarcado.Location = new System.Drawing.Point(111, 186);
            this.txtMarcado.Name = "txtMarcado";
            this.txtMarcado.Size = new System.Drawing.Size(156, 22);
            this.txtMarcado.TabIndex = 10;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(111, 226);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(156, 22);
            this.txtCosto.TabIndex = 11;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 289);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtMarcado);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtNombramiento);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCodificado);
            this.Controls.Add(this.lblCodificado);
            this.Controls.Add(this.lblNombramiento);
            this.Controls.Add(this.lblMarcado);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCat);
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del Artículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblMarcado;
        private System.Windows.Forms.Label lblNombramiento;
        private System.Windows.Forms.Label lblCodificado;
        private System.Windows.Forms.TextBox txtCodificado;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNombramiento;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtMarcado;
        private System.Windows.Forms.TextBox txtCosto;
    }
}