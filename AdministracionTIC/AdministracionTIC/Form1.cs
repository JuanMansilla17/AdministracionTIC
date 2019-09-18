using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionTIC
{
    public partial class VistaPrincipal : Form
    {
        

        public VistaPrincipal()
        {
            InitializeComponent();

            
        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaRecursos vistaRecursos = new VistaRecursos();
            vistaRecursos.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaPrestamo vistaPrestamo = new VistaPrestamo();
            vistaPrestamo.Show();
        }

        

        private void aBMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VistaSolicitante vistaSolicitantes = new VistaSolicitante();
            vistaSolicitantes.Show();
        }
    }
}
