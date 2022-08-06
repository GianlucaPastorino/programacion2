using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I01_ElDelegado
{
    public partial class FrmTestDelegados : Form
    {
        private Action<string> delegadoUpdateNombre; 

        public FrmTestDelegados(Action<string> delegado)
        {
            delegadoUpdateNombre = delegado;
            InitializeComponent();   
        }

        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            delegadoUpdateNombre.Invoke(txtNombre.Text);
        }
    }
}
