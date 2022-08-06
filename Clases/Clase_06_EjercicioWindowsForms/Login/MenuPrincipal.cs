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
    public partial class MenuPrincipal : Form
    {
        Alumno[] alumnos;
        private string usuario;

        private MenuPrincipal() // Lo pongo privado para que si o si tenga que inicializar desde el otro ctor y tenga que pasarle un nombre de usuario.
        {
            InitializeComponent();
            alumnos = new Alumno[10];
            Carga();
        }

        public MenuPrincipal(string nombreUsuario) : this()
        {
            this.usuario = nombreUsuario;
        }

        private void Carga()
        {
            alumnos[0] = new Alumno("Pepe", "Martinez", 12345679);
            alumnos[1] = new Alumno("Juana", "Rufosa", 198749821);
            alumnos[2] = new Alumno("Carlos", "Vibes", 65656984);
            alumnos[3] = new Alumno("Johny", "Bravo", 66980409);
            alumnos[4] = new Alumno("Pablo", "Riquielme", 21654908);
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Esto es para matar la ejecución y que no me quede abierto por culpa del hide 
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.lbl_Welcome.Text = "Welcome " + this.usuario;

            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i] != null)
                {
                    this.rtbInformacion.Text += alumnos[i].MostraInfo() + "\n";
                }
            }
        }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaAlumno frmAltaAlumno = new AltaAlumno();

            if (frmAltaAlumno.ShowDialog() == DialogResult.OK)
            {
                int posLibre = ProximaPos();
                if (posLibre != -1)
                {
                    alumnos[posLibre] = frmAltaAlumno.GetAlumno();
                    this.rtbInformacion.Text += alumnos[posLibre].MostraInfo() + "\n";
                }
                else
                {
                    MessageBox.Show("No hay más lugar");
                }
            }
            else
            {
                MessageBox.Show("Carga cancelada");
            }
        }

        private int ProximaPos()
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
