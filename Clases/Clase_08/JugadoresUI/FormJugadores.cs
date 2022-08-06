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

namespace UI
{
    public partial class FormJugadores : Form
    {
        private Jugador nuevoJugadro;

        public FormJugadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jugador nuevoJugadro = new Jugador("pepe", "Arquero", 1, 20, "argentino");

            string nombre = nuevoJugadro.Nombre;
        }
    }
}
