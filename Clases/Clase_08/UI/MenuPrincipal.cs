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
using JugadoresUI;

namespace UI
{
    public partial class MenuPrincipal : Form
    {
        private List<Jugador> jugadores;

        public MenuPrincipal()
        {
            InitializeComponent();
            jugadores = new List<Jugador>();
    }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            JugadoresUI.FormJugadores frm = new JugadoresUI.FormJugadores();
            DialogResult resultado = frm.ShowDialog();


        }


    }
}
