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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.txb_usuario.Text;
            
            if(usuario == "Pepe" && this.txb_password.Text == "RuFoSo")
            {
                //this.BackColor = Color.Green;
                //MessageBox.Show("¡Login exitoso!");
                MenuPrincipal frmMenuPrincipal = new MenuPrincipal(usuario);
                frmMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                //this.BackColor = Color.Red;        
                MessageBox.Show("Usuario o contraseña incorrecto.");
            }
        }

        private void btnRellenar_Click(object sender, EventArgs e)
        {
            this.txb_usuario.Text = "Pepe";
            this.txb_password.Text = "RuFoSo";
        }
    }
}
