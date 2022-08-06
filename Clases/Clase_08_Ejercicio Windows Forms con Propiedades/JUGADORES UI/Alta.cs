using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace JUGADORES_UI
{
    public partial class Alta : Form
    {
        Jugador jugCreado;

        public Jugador Jugador
        {
            get
            {
                return jugCreado;
            }
        }


        public Alta()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            EPosicion posSeleccionada = (EPosicion) this.cbxPosicion.SelectedItem;

            //MessageBox.Show(posSeleccionada.ToString());

            //int pos = (int)posSeleccionada;

            //MessageBox.Show(pos.ToString());


           // Jugador unJugador = new Jugador("pepe", "arquero", 1, 20, "argentino");
            
            
            jugCreado = new Jugador("pepe", posSeleccionada , 1, 20, "argentino");


            this.DialogResult = DialogResult.OK;
         

        }

        private void Alta_Load(object sender, EventArgs e)
        {

            this.cbxPosicion.DataSource = Enum.GetValues(typeof(EPosicion));

        }
    }
}
