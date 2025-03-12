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
    public partial class CrearLibroFrom : Form
    {
        public CrearLibroFrom()
        {
            InitializeComponent();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController();
            string resultado = controller.GuardarLibro(tbNombre.Text, tbReferencia.Text);
            lbResultado.Text = resultado;
        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

    }
}
