namespace TPWinForm_Equipo22B
{
    partial class frmGestionArticulo
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.lblComboBoxCategoria = new System.Windows.Forms.Label();
            this.lblComboBoxMarca = new System.Windows.Forms.Label();
            this.txtPrecioArticulo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nombreNuevoArticulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(151, 136);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(179, 20);
            this.txtDescripcion.TabIndex = 27;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(63, 139);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 26;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(185, 239);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(145, 21);
            this.comboBoxCategoria.TabIndex = 25;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(183, 201);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(147, 21);
            this.comboBoxMarca.TabIndex = 24;
            // 
            // lblComboBoxCategoria
            // 
            this.lblComboBoxCategoria.AutoSize = true;
            this.lblComboBoxCategoria.Location = new System.Drawing.Point(63, 242);
            this.lblComboBoxCategoria.Name = "lblComboBoxCategoria";
            this.lblComboBoxCategoria.Size = new System.Drawing.Size(113, 13);
            this.lblComboBoxCategoria.TabIndex = 23;
            this.lblComboBoxCategoria.Text = "Categoría del artículo:";
            // 
            // lblComboBoxMarca
            // 
            this.lblComboBoxMarca.AutoSize = true;
            this.lblComboBoxMarca.Location = new System.Drawing.Point(63, 204);
            this.lblComboBoxMarca.Name = "lblComboBoxMarca";
            this.lblComboBoxMarca.Size = new System.Drawing.Size(96, 13);
            this.lblComboBoxMarca.TabIndex = 22;
            this.lblComboBoxMarca.Text = "Marca del artículo:";
            // 
            // txtPrecioArticulo
            // 
            this.txtPrecioArticulo.Location = new System.Drawing.Point(152, 169);
            this.txtPrecioArticulo.Name = "txtPrecioArticulo";
            this.txtPrecioArticulo.Size = new System.Drawing.Size(179, 20);
            this.txtPrecioArticulo.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 100);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(151, 56);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(179, 20);
            this.txtCodigo.TabIndex = 19;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(248, 303);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(83, 23);
            this.botonCancelar.TabIndex = 18;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(62, 303);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(83, 23);
            this.botonAceptar.TabIndex = 17;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(63, 172);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(79, 13);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio artículo:";
            // 
            // nombreNuevoArticulo
            // 
            this.nombreNuevoArticulo.AutoSize = true;
            this.nombreNuevoArticulo.Location = new System.Drawing.Point(63, 103);
            this.nombreNuevoArticulo.Name = "nombreNuevoArticulo";
            this.nombreNuevoArticulo.Size = new System.Drawing.Size(86, 13);
            this.nombreNuevoArticulo.TabIndex = 15;
            this.nombreNuevoArticulo.Text = "Nombre artículo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(63, 56);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(82, 13);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Código artículo:";
            // 
            // frmGestionArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 383);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.lblComboBoxCategoria);
            this.Controls.Add(this.lblComboBoxMarca);
            this.Controls.Add(this.txtPrecioArticulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.nombreNuevoArticulo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmGestionArticulo";
            this.Text = "Agregar articulo";
            this.Load += new System.EventHandler(this.frmGestionArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label lblComboBoxCategoria;
        private System.Windows.Forms.Label lblComboBoxMarca;
        private System.Windows.Forms.TextBox txtPrecioArticulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label nombreNuevoArticulo;
        private System.Windows.Forms.Label lblCodigo;
    }
}