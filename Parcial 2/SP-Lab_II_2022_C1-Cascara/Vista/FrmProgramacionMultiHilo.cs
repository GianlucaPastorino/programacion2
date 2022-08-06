using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmProgramacionMultiHilo : Form
    {
        Task cargaAlumnos;   // no modificar
        CancellationTokenSource cts;  // no modificar 
        List<Alumno> listaAlumnos;  // no modificar

        public FrmProgramacionMultiHilo()
        {
            InitializeComponent();   // no modificar linea
            listaAlumnos = new List<Alumno>();  // no modificar linea
            cts = new CancellationTokenSource();
            cargaAlumnos = new Task(ComenzarCarga, cts.Token);
        }

        private void ComenzarCarga()
        {
            while (!cts.Token.IsCancellationRequested)
            {
                ActualizarDataGrid();
                Thread.Sleep(2000);
            }
        }
        
        private void ActualizarDataGrid()
        {
            if (InvokeRequired)
            {
                Action actualizar = ActualizarDataGrid;
                Invoke(actualizar);
            }
            else
            {
                listaAlumnos.Add(GeneradorDeDatos.GetUnAlumno);
                dtg_listadoDeAlumnos.DataSource = null;
                dtg_listadoDeAlumnos.DataSource = listaAlumnos;
            }
        }
        
        // no modificar metodo
        private void btn_comenzarCarga_Click(object sender, EventArgs e)
        {
            btn_comenzarCarga.Enabled = false;
            cargaAlumnos.Start();
        }


        // no modificar metodo
        private void btn_cancelarCarga_Click(object sender, EventArgs e)
        {
            btn_cancelarCarga.Enabled = false;
            cts.Cancel();
            MessageBox.Show("Carga de alumnos cancelada");

        }
    }
}
