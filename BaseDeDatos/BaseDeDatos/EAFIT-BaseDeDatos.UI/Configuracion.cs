using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAFIT_BaseDeDatos.UI
{
    public partial class Configuracion : Form
    {
        Form InstanciaPpal;
        public Configuracion(Form ppal)
        {
            InitializeComponent();
            InstanciaPpal = ppal;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            InstanciaPpal.Close();
        }
    }
}
