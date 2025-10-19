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
    public partial class Logeo : Form
    {

        public Logeo()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<bool, string> EsCorrecto = new Dictionary<bool, string>();
                bool existe;
                EAFIT_BaseDeDatos.Core.EAFIT_FACADE.FacadeLogin ValidateLogin = new Core.EAFIT_FACADE.FacadeLogin();
                EsCorrecto = ValidateLogin.ValidarLogin(string.IsNullOrEmpty(TxtUsuario.Text) ? string.Empty : TxtUsuario.Text, string.IsNullOrEmpty(TxtPassword.Text) ? string.Empty : TxtPassword.Text);
                existe = EsCorrecto.ContainsValue("LogeoCorrecto");// EsCorrecto.TryGetValue(true, out string MensajeLogeo);
                EsCorrecto.TryGetValue(false, out string MensajeLogeo);

                if (existe)
                {
                    MenuPrincipal NuevoMenu = new MenuPrincipal(this);
                    NuevoMenu.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Logeo incorrecto, valide sus credenciales" + Environment.NewLine + MensajeLogeo, "Error de logeo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message + Environment.NewLine + exc.StackTrace, "Error controlado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                BtnIngresar_Click(sender, e);
            }
        }
    }
}
