using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class AltaAlumno : Form
    {
        private Alumno alumnoCreado;

        public AltaAlumno()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Falta validar que nosea null y eso

            
            string nomb = this.txbNombre.Text;
            string ape = this.txbApellido.Text;
            int.TryParse(this.txbDni.Text, out int numDoc);
            int.TryParse(this.txbTelefono.Text, out int tel);
            string dire = this.txbDireccion.Text;

            if(tel == 0 || string.IsNullOrEmpty(dire))
            {
                 alumnoCreado = new Alumno(nomb, ape, numDoc);
            }
            else
            {
                alumnoCreado = new Alumno(nomb, ape, numDoc, tel, dire);
            }

            this.DialogResult = DialogResult.OK;
        }

        public Alumno GetAlumno()
        {
            return alumnoCreado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
