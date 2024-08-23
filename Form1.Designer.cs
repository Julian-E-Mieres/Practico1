namespace Practico1
{
    partial class Form1
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
            this.LNombre = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.textBoxMultiline = new System.Windows.Forms.TextBox();
            this.Bsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.Location = new System.Drawing.Point(149, 62);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(117, 22);
            this.LNombre.TabIndex = 0;
            // 
            // LApellido
            // 
            this.LApellido.Location = new System.Drawing.Point(149, 131);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(117, 22);
            this.LApellido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(55, 188);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(86, 30);
            this.BGuardar.TabIndex = 4;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(174, 188);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(92, 30);
            this.BEliminar.TabIndex = 5;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // textBoxMultiline
            // 
            this.textBoxMultiline.Location = new System.Drawing.Point(353, 62);
            this.textBoxMultiline.Multiline = true;
            this.textBoxMultiline.Name = "textBoxMultiline";
            this.textBoxMultiline.Size = new System.Drawing.Size(268, 156);
            this.textBoxMultiline.TabIndex = 6;
            // 
            // Bsalir
            // 
            this.Bsalir.Location = new System.Drawing.Point(557, 269);
            this.Bsalir.Name = "Bsalir";
            this.Bsalir.Size = new System.Drawing.Size(86, 32);
            this.Bsalir.TabIndex = 7;
            this.Bsalir.Text = "Salir";
            this.Bsalir.UseVisualStyleBackColor = true;
            this.Bsalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.Bsalir);
            this.Controls.Add(this.textBoxMultiline);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Name = "Form1";
            this.Text = "Mi Primer Forms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LNombre;
        private System.Windows.Forms.TextBox LApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.TextBox textBoxMultiline;
        private System.Windows.Forms.Button Bsalir;
    }
}

