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
    public partial class VistaPrestamo : Form
    {
        private GestorPrestamo gestorPrestamo; 

        public VistaPrestamo()
        {
            InitializeComponent();
            gestorPrestamo = new GestorPrestamo(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
