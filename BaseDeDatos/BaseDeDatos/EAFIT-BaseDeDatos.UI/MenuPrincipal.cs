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
    public partial class MenuPrincipal : Form
    {
        Form InstanciaPpal;
        public MenuPrincipal(Form ppal)
        {
            InitializeComponent();
            InstanciaPpal = ppal;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            InstanciaPpal.Close();
        }



        private void PBProductos_Click(object sender, EventArgs e)
        {
            Productos FrmProductos = new Productos(InstanciaPpal);
            FrmProductos.Show();
            this.Close();
        }

        private void PBUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios Frmusuarios = new Usuarios(InstanciaPpal);
            Frmusuarios.Show();
            this.Close();

        }

        private void PBConfig_Click(object sender, EventArgs e)
        {
            Configuracion FrmConfiguracion = new Configuracion(InstanciaPpal);
            FrmConfiguracion.Show();
            this.Close();

        }

        private void PBCategorias_Click(object sender, EventArgs e)
        {
            Cateogias FrmCategorias = new Cateogias(InstanciaPpal);
            FrmCategorias.Show();
            this.Close();
        }
    }
}
