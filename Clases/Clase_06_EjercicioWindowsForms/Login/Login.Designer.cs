
namespace Login
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_password = new System.Windows.Forms.TextBox();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.btn_loguear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRellenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(61, 103);
            this.txb_password.Name = "txb_password";
            this.txb_password.PasswordChar = '*';
            this.txb_password.PlaceholderText = "Contraseña";
            this.txb_password.Size = new System.Drawing.Size(217, 23);
            this.txb_password.TabIndex = 1;
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(61, 74);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.PlaceholderText = "Usuario";
            this.txb_usuario.Size = new System.Drawing.Size(217, 23);
            this.txb_usuario.TabIndex = 0;
            // 
            // btn_loguear
            // 
            this.btn_loguear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_loguear.Location = new System.Drawing.Point(26, 142);
            this.btn_loguear.Name = "btn_loguear";
            this.btn_loguear.Size = new System.Drawing.Size(288, 53);
            this.btn_loguear.TabIndex = 2;
            this.btn_loguear.Text = "LOGUEAR";
            this.btn_loguear.UseVisualStyleBackColor = true;
            this.btn_loguear.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "INICIAR SESIÓN";
            // 
            // btnRellenar
            // 
            this.btnRellenar.Location = new System.Drawing.Point(130, 201);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(75, 23);
            this.btnRellenar.TabIndex = 4;
            this.btnRellenar.Text = "Rellenar";
            this.btnRellenar.UseVisualStyleBackColor = true;
            this.btnRellenar.Click += new System.EventHandler(this.btnRellenar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 228);
            this.Controls.Add(this.btnRellenar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_loguear);
            this.Controls.Add(this.txb_usuario);
            this.Controls.Add(this.txb_password);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.TextBox txb_usuario;
        private System.Windows.Forms.Button btn_loguear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRellenar;
    }
}

