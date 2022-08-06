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
    public partial class FrmAlta : Form
    {
        int codigoJuego;
        public FrmAlta(int codigoJuego) : this()
        {
            btnGuardar.Text = "Modificar";
            cmbUsuarios.Hide();
            this.codigoJuego = codigoJuego;
            PintarForm();
        }

        private void PintarForm()
        {
            Juego auxJuego = JuegoDAO.LeerPorId(codigoJuego);
            txtNombre.Text = auxJuego.Nombre;
            txtGenero.Text = auxJuego.Genero;
            nupPrecio.Value = (decimal)auxJuego.Precio;
        }
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cmbUsuarios.DataSource = UsuarioDAO.Leer();
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario user = (Usuario)cmbUsuarios.SelectedItem;
            if(btnGuardar.Text == "Guardar")
            {
                JuegoDAO.Guardar(new Juego(user.CodigoUsuario, txtGenero.Text, txtNombre.Text, (double)nupPrecio.Value));
            }
            else
            {
                JuegoDAO.Modificar(new Juego(codigoJuego, user.CodigoUsuario, txtGenero.Text, txtNombre.Text, (double)nupPrecio.Value));
            }
            DialogResult = DialogResult.OK;
        }
    }
}
