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

namespace Vista
{
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarBiblioteca();
        }

        private void RefrescarBiblioteca()
        {
            dtgvBiblioteca.DataSource = JuegoDAO.Leer();
            dtgvBiblioteca.Update();
            dtgvBiblioteca.Refresh();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Biblioteca biblioteca = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;
            JuegoDAO.Eliminar(biblioteca.CodigoJuego);
            RefrescarBiblioteca();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = new FrmAlta();

            if(frmAlta.ShowDialog() == DialogResult.OK)
            {
                RefrescarBiblioteca();
            }    
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Biblioteca biblioteca = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;
            FrmAlta frmModif = new FrmAlta(biblioteca.CodigoJuego);

            if (frmModif.ShowDialog() == DialogResult.OK)
            {
                RefrescarBiblioteca();
            }
        }
    }
}
