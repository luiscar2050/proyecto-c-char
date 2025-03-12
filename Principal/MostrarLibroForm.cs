using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class MostrarLibroForm : Form
    {
        public MostrarLibroForm()
        {
            InitializeComponent();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController();
            var LibroActual = controller.MostrarLibro();
            lbResultado.Text = LibroActual.Name + " - " + LibroActual.Referencia;
        }
    }
}
