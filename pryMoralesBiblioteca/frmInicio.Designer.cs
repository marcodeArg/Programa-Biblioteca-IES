namespace pryMoralesBiblioteca
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodLibro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodEditorial = new System.Windows.Forms.Label();
            this.lblCodAutor = new System.Windows.Forms.Label();
            this.lblCodDistribuidor = new System.Windows.Forms.Label();
            this.txtCodLibro = new System.Windows.Forms.TextBox();
            this.txtCodEditorial = new System.Windows.Forms.TextBox();
            this.txtCodAutor = new System.Windows.Forms.TextBox();
            this.txtCodDistribuidor = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodLibro
            // 
            this.lblCodLibro.AutoSize = true;
            this.lblCodLibro.Location = new System.Drawing.Point(22, 124);
            this.lblCodLibro.Name = "lblCodLibro";
            this.lblCodLibro.Size = new System.Drawing.Size(117, 20);
            this.lblCodLibro.TabIndex = 0;
            this.lblCodLibro.Text = "Código del libro";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(123, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del libro";
            // 
            // lblCodEditorial
            // 
            this.lblCodEditorial.AutoSize = true;
            this.lblCodEditorial.Location = new System.Drawing.Point(22, 169);
            this.lblCodEditorial.Name = "lblCodEditorial";
            this.lblCodEditorial.Size = new System.Drawing.Size(156, 20);
            this.lblCodEditorial.TabIndex = 2;
            this.lblCodEditorial.Text = "Código de la editorial";
            // 
            // lblCodAutor
            // 
            this.lblCodAutor.AutoSize = true;
            this.lblCodAutor.Location = new System.Drawing.Point(22, 214);
            this.lblCodAutor.Name = "lblCodAutor";
            this.lblCodAutor.Size = new System.Drawing.Size(125, 20);
            this.lblCodAutor.TabIndex = 3;
            this.lblCodAutor.Text = "Código del autor";
            // 
            // lblCodDistribuidor
            // 
            this.lblCodDistribuidor.AutoSize = true;
            this.lblCodDistribuidor.Location = new System.Drawing.Point(22, 259);
            this.lblCodDistribuidor.Name = "lblCodDistribuidor";
            this.lblCodDistribuidor.Size = new System.Drawing.Size(165, 20);
            this.lblCodDistribuidor.TabIndex = 4;
            this.lblCodDistribuidor.Text = "Código del distribuidor";
            // 
            // txtCodLibro
            // 
            this.txtCodLibro.Location = new System.Drawing.Point(226, 121);
            this.txtCodLibro.Name = "txtCodLibro";
            this.txtCodLibro.ReadOnly = true;
            this.txtCodLibro.Size = new System.Drawing.Size(85, 26);
            this.txtCodLibro.TabIndex = 5;
            // 
            // txtCodEditorial
            // 
            this.txtCodEditorial.Location = new System.Drawing.Point(226, 166);
            this.txtCodEditorial.Name = "txtCodEditorial";
            this.txtCodEditorial.ReadOnly = true;
            this.txtCodEditorial.Size = new System.Drawing.Size(85, 26);
            this.txtCodEditorial.TabIndex = 7;
            // 
            // txtCodAutor
            // 
            this.txtCodAutor.Location = new System.Drawing.Point(226, 211);
            this.txtCodAutor.Name = "txtCodAutor";
            this.txtCodAutor.ReadOnly = true;
            this.txtCodAutor.Size = new System.Drawing.Size(85, 26);
            this.txtCodAutor.TabIndex = 8;
            // 
            // txtCodDistribuidor
            // 
            this.txtCodDistribuidor.Location = new System.Drawing.Point(226, 256);
            this.txtCodDistribuidor.Name = "txtCodDistribuidor";
            this.txtCodDistribuidor.ReadOnly = true;
            this.txtCodDistribuidor.Size = new System.Drawing.Size(85, 26);
            this.txtCodDistribuidor.TabIndex = 9;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(163, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(88, 29);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Libros";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(226, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(184, 26);
            this.txtNombre.TabIndex = 12;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(326, 305);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(84, 36);
            this.btnSiguiente.TabIndex = 13;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(211, 305);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(84, 36);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 359);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtCodDistribuidor);
            this.Controls.Add(this.txtCodAutor);
            this.Controls.Add(this.txtCodEditorial);
            this.Controls.Add(this.txtCodLibro);
            this.Controls.Add(this.lblCodDistribuidor);
            this.Controls.Add(this.lblCodAutor);
            this.Controls.Add(this.lblCodEditorial);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodLibro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInicio";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodLibro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodEditorial;
        private System.Windows.Forms.Label lblCodAutor;
        private System.Windows.Forms.Label lblCodDistribuidor;
        private System.Windows.Forms.TextBox txtCodLibro;
        private System.Windows.Forms.TextBox txtCodEditorial;
        private System.Windows.Forms.TextBox txtCodAutor;
        private System.Windows.Forms.TextBox txtCodDistribuidor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
    }
}

