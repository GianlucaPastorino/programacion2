
namespace EjercicioWindowsForms
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_mensaje2 = new System.Windows.Forms.Button();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.txb_ingresoDatos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "ACTUALIZAR ETIQUETA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mensaje2
            // 
            this.btn_mensaje2.Location = new System.Drawing.Point(263, 340);
            this.btn_mensaje2.Name = "btn_mensaje2";
            this.btn_mensaje2.Size = new System.Drawing.Size(236, 98);
            this.btn_mensaje2.TabIndex = 1;
            this.btn_mensaje2.Text = "MENSAJE 2";
            this.btn_mensaje2.UseVisualStyleBackColor = true;
            this.btn_mensaje2.Click += new System.EventHandler(this.btn_mensaje2_Click);
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_texto.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_texto.Location = new System.Drawing.Point(297, 47);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(187, 47);
            this.lbl_texto.TabIndex = 2;
            this.lbl_texto.Text = "ASHEEEEE";
            // 
            // txb_ingresoDatos
            // 
            this.txb_ingresoDatos.Location = new System.Drawing.Point(222, 21);
            this.txb_ingresoDatos.Name = "txb_ingresoDatos";
            this.txb_ingresoDatos.PlaceholderText = "Ingrese un mensaje";
            this.txb_ingresoDatos.Size = new System.Drawing.Size(362, 23);
            this.txb_ingresoDatos.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_ingresoDatos);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.btn_mensaje2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_mensaje2;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.TextBox txb_ingresoDatos;
    }
}

