using System;
using System.Windows.Forms;

namespace EjercicioWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO : 1 - Detectar el texto del TEXTBOX
            string mensaje = this.txb_ingresoDatos.Text;
            //TODO : 2 - Reemplazar el texto en el LABEL
            this.lbl_texto.Text = mensaje;
        }

        private void btn_mensaje2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MI MONEY GO DUMB TENGO PLATA PELOTUDA");
        }
    }
}
