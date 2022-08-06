
namespace Login
{
    partial class AltaAlumno
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
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(12, 12);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.PlaceholderText = "Nombre";
            this.txbNombre.Size = new System.Drawing.Size(261, 23);
            this.txbNombre.TabIndex = 0;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(12, 41);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.PlaceholderText = "Apellido";
            this.txbApellido.Size = new System.Drawing.Size(261, 23);
            this.txbApellido.TabIndex = 1;
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(12, 70);
            this.txbDni.Name = "txbDni";
            this.txbDni.PlaceholderText = "Dni";
            this.txbDni.Size = new System.Drawing.Size(261, 23);
            this.txbDni.TabIndex = 2;
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(12, 99);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.PlaceholderText = "Teléfono";
            this.txbTelefono.Size = new System.Drawing.Size(261, 23);
            this.txbTelefono.TabIndex = 3;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(12, 128);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.PlaceholderText = "Dirección";
            this.txbDireccion.Size = new System.Drawing.Size(261, 23);
            this.txbDireccion.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(24, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(177, 169);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // AltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 204);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.txbDni);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaAlumno";
            this.Text = "AltaAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}