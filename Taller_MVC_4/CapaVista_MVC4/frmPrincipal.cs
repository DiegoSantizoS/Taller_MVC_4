using CapaControlador_MVC4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_MVC4
{
    public partial class frmPrincipal : Form
    {
        string nombreTabla = "tbl_ciudad";
        Controlador controlador = new Controlador();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void actualizarDgv()
        {
            DataTable dtVista = controlador.llenarDgv(nombreTabla);
            dgvConsultarTabla.DataSource = dtVista;

        }

        private void btnConsultarCiudad_Click(object sender, EventArgs e)
        {
            actualizarDgv();
        }
    }
}
